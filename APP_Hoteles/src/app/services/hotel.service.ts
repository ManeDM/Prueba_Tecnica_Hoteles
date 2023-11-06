import { Injectable } from '@angular/core';
import { environment } from '../environment/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Hotel } from '../interface/hotel';

@Injectable({
  providedIn: 'root'
})
export class HotelService {

  private MyAppUrl = environment.endpoint;
  private MyApiUrl = 'api/Hotel/'

  constructor(private http: HttpClient) { }

  getHotelList():Observable<Hotel[]>{
    return this.http.get<Hotel[]>(`${this.MyAppUrl}${this.MyApiUrl}`)
  }

  getHotel(id: number): Observable<Hotel>{
    return this.http.get<Hotel>(`${this.MyAppUrl}${this.MyApiUrl}${id}`)
  }
}
