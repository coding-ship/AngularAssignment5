import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Userdata } from './userdata';

@Injectable({
  providedIn: 'root'
})
export class CustomerdashboardService {
 // http://localhost:53226/api/Customer/DeleteTracer?id=3
private url='http://localhost:53226/api/Customer/';
  constructor(private http:HttpClient) { }
  getdata():Observable<Userdata[]>
  {
    return this.http.get<Userdata[]>(this.url+'Getdetails');
  }
  deletedata(id:number):Observable<Userdata>
  {
  return this.http.delete<Userdata>(this.url+'DeleteTracer?id='+id,{
    headers:new HttpHeaders({
      'Content-Type':'application/json'
    })
  });
  }
}
