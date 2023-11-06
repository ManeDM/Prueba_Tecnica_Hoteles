import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HotelComponent } from './components/hotel/hotel.component';



@NgModule({
  declarations: [
    HotelComponent
  ],
  imports: [
    CommonModule
  ],
  exports:[
    HotelComponent
  ],
})
export class HotelModule { }
