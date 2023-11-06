import { Component, OnInit } from '@angular/core';
import { Hotel } from 'src/app/interface/hotel';
import { HotelService } from 'src/app/services/hotel.service';

@Component({
  selector: 'app-hotel',
  templateUrl: './hotel.component.html',
  styleUrls: ['./hotel.component.css']
})
export class HotelComponent implements OnInit {

  hotelList: Hotel[] = [];

  constructor(private _hotelService: HotelService ){}

  ngOnInit(): void {
    this.getListHotels();
  }

  getListHotels(){
    this._hotelService.getHotelList().subscribe((data: Hotel[])=>{
      this.hotelList = data;
      console.log(this.hotelList)
    })
  }
}
