import {TemplateRef, ViewChild} from '@angular/core';
import {Component, OnInit} from '@angular/core';
import {People} from './people/people';
import {PeoplesService} from './peoples.service';
import {Observable} from 'rxjs';
   
@Component({
    selector: 'peoples-app',
    templateUrl: './peoples.component.html',
    styleUrls: ['./peoples.component.css'],
    providers: [PeoplesService],
})
export class PeoplesComponent implements OnInit {
    //типы шаблонов
    @ViewChild('readOnlyTemplate', {static: false}) readOnlyTemplate: TemplateRef<any>;
    @ViewChild('editTemplate', {static: false}) editTemplate: TemplateRef<any>;
       
    editedPeople: People;
    peoples: Array<People>;
    isNewRecord: boolean;
    statusMessage: string;
       
    constructor(private serv: PeoplesService) {
        this.peoples = new Array<People>();
    }
       
    ngOnInit() {

        this.loadPeoples();
    }
       
    //загрузка пользователей
    private loadPeoples() {

        this.serv.getPeoples().subscribe((data: People[]) => {
            
                this.peoples = data; 
            });

            var foo =  this.peoples;

            debugger;

    }
    // добавление пользователя
    addPeople() {
        this.editedPeople = new People("as","",0);
        this.peoples.push(this.editedPeople);
        this.isNewRecord = true;
    }
    
    // редактирование пользователя
    editPeople(people: People) {
        this.editedPeople = new People(people.peopleId, people.name, people.age);
    }
    // загружаем один из двух шаблонов
    loadTemplate(people: People) {
        if (this.editedPeople && this.editedPeople.peopleId === people.peopleId) {
            return this.editTemplate;
        } else {
            return this.readOnlyTemplate;
        }
    }
    // сохраняем пользователя
    savePeople() {
        if (this.isNewRecord) {
            // добавляем пользователя
            this.serv.createPeople(this.editedPeople).subscribe(data => {
                this.statusMessage = 'Данные успешно добавлены',
                this.loadPeoples();
            });
            this.isNewRecord = false;
            this.editedPeople = null;
        } else {
            // изменяем пользователя
            this.serv.updatePeople(this.editedPeople.peopleId, this.editedPeople).subscribe(data => {
                this.statusMessage = 'Данные успешно обновлены',
                this.loadPeoples();
            });
            this.editedPeople = null;
        }
    }
    // отмена редактирования
    cancel() {
        // если отмена при добавлении, удаляем последнюю запись
        if (this.isNewRecord) {
            this.peoples.pop();
            this.isNewRecord = false;
        }
        this.editedPeople = null;
    }
    // удаление пользователя
    deletePeople(people: People) {
        this.serv.deletePeople(people.peopleId).subscribe(data => {
            this.statusMessage = 'Данные успешно удалены',
            this.loadPeoples();
        });
    }
}