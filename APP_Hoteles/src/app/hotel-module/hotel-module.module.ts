import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HotelComponent } from './components/hotel/hotel.component';
import { HotelCardComponent } from './components/hotel-card/hotel-card.component';
import {MatSnackBarModule} from '@angular/material/snack-bar';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    HotelComponent,
    HotelCardComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
    MatSnackBarModule
    
  ],
  exports:[
    HotelComponent,
    MatSnackBarModule
  ],
})
export class HotelModule { }
