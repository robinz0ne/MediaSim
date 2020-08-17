import {Injectable} from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {People} from './people/people';
    
@Injectable()
export class PeoplesService{
    private url = "/api/people"
    constructor(private http: HttpClient){ }
       
    getPeoples(){
        var p = this.http.get(this.url);
        return p;
    }
   
    createPeople(people: People){
        const myHeaders = new HttpHeaders().set("Content-Type", "application/json");
        return this.http.post(this.url, JSON.stringify(people), {headers: myHeaders}); 
    }
    updatePeople(id: string, people: People) {
        const myHeaders = new HttpHeaders().set("Content-Type", "application/json");
        return this.http.put(this.url, JSON.stringify(people), {headers:myHeaders});
    }
    deletePeople(id: string){
        return this.http.delete(this.url + '/' + id);
    }
}