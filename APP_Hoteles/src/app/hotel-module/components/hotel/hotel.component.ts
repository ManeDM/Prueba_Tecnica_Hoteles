import { Component, OnInit } from '@angular/core';
import { Hotel } from 'src/app/interface/hotel';
import { HotelService } from 'src/app/services/hotel.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import { catchError } from 'rxjs/operators';

@Component({
  selector: 'app-hotel',
  templateUrl: './hotel.component.html',
  styleUrls: ['./hotel.component.css']
})
export class HotelComponent implements OnInit {

  hotelList: Hotel[] = [];

  constructor(
    private _snackBar: MatSnackBar,
    private _hotelService: HotelService ){}

  ngOnInit(): void {
    this.getListHotels();
    
  }

  getListHotels() {
    this._hotelService.getHotelList()
      .pipe(
        catchError(error => {
          this._snackBar.open('Error al conseguir la data, por favor habilite el servidor en el puerto 7145', '', {
            duration: 5000,
            horizontalPosition: 'center',
            verticalPosition: 'top',
            politeness: 'assertive',
            panelClass: 'app-notification-error',
          });
          throw error;
        })
      )
      .subscribe((data: Hotel[]) => {
        this.hotelList = data;
        console.log(this.hotelList);
      });
  }

  addtHotel(){
    this._snackBar.open('Funcionalidad en construcción, pronto podras añadir Hoteles a la tabla', '', {
      duration: 3500,
      horizontalPosition: 'center',
      verticalPosition: 'top',
      politeness: 'assertive',
      panelClass: 'app-notification-inprogress',
    });
  }

  editHotel(){
    this._snackBar.open('Funcionalidad en construcción, pronto podras editar la información de los Hoteles', '', {
      duration: 3500,
      horizontalPosition: 'center',
      verticalPosition: 'top',
      politeness: 'assertive',
      panelClass: 'app-notification-inprogress',
    });
  }

  deleteHotel(){
    this._snackBar.open('Funcionalidad en construcción, pronto podras eliminar Hoteles de la lista', '', {
      duration: 3500,
      horizontalPosition: 'center',
      verticalPosition: 'top',
      politeness: 'assertive',
      panelClass: 'app-notification-inprogress',
    });
  }
}
