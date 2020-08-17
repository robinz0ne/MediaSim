import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
// import { Product } from './product';

 
@Injectable()
export class DataService {
 
    private url = "https://localhost:44375/api/mediaSim";
  // private url = "http://numbersapi.com/3/1";
  // public _url: string = "https://jsonplaceholder.typicode.com/photos";
 
    constructor(private http: HttpClient) {
    }
 
    getProducts() {
        var foo = this.http.get(this.url);
        return foo;
    }

}
// https://localhost:44395/
// https://localhost:44375/