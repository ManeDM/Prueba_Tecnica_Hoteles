import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HotelComponent } from './hotel-module/components/hotel/hotel.component';
import { HotelCardComponent } from './hotel-module/components/hotel-card/hotel-card.component';

const routes: Routes = [
  {path: '', redirectTo: '/hotelList', pathMatch: 'full'},
  {path: 'hotelList', component: HotelComponent},
  {path: 'hotelCard/:id', component: HotelCardComponent},
  {path: '**', redirectTo: '/hotelList', pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
