import { Component, OnInit } from '@angular/core';
import { DataService } from './data.service';

@Component({
    selector: 'app',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css'],
    providers: [DataService],
})
export class AppComponent implements OnInit {


    tableMode: boolean = true;          // табличный режим

    constructor(private dataService: DataService) { }


    ngOnInit() {

        // this.loadProducts();    // загрузка данных при старте компонента  
    }
    // получаем данные через сервис
    loadProducts() {


        this.dataService.getProducts()
            .subscribe();
        // .subscribe((data: Product[]) => this.products = data);
    }
}