import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RandomPairingListComponent } from './random-pairing-list/random-pairing-list.component';
import { FormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    RandomPairingListComponent
  ],
  imports: [
    CommonModule,
    FormsModule
  ],
  exports:[
    RandomPairingListComponent
  ]
})
export class RandomPairingsModule { }
