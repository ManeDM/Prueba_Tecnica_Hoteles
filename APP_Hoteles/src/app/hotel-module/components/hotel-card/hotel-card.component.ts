import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Hotel } from 'src/app/interface/hotel';
import { HotelService } from 'src/app/services/hotel.service';

@Component({
  selector: 'app-hotel-card',
  templateUrl: './hotel-card.component.html',
  styleUrls: ['./hotel-card.component.css']
})
export class HotelCardComponent implements OnInit {

  id: number;
  hotel! : Hotel;

  constructor(
    private _hotelService: HotelService,
    private _aRoute: ActivatedRoute
  ){
    this.id = Number(this._aRoute.snapshot.paramMap.get('id'))
  }

  ngOnInit(): void{
    this.getHotel(this.id);
  }

  getHotel(id: number){
    this._hotelService.getHotel(id).subscribe(data => {
      this.hotel = data;
      console.log(data)
    })
  }
}
