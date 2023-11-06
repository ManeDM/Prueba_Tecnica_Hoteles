import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HotelModule } from './hotel-module/hotel-module.module';


import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http'
import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    AppRoutingModule,
    BrowserModule,
    HotelModule,
    HttpClientModule
  ],
  exports:[
    HotelModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
