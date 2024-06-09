import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatTabsModule, MatSidenavModule, MatToolbarModule  } from '@angular/material';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    MatTabsModule,
    MatSidenavModule,
    MatToolbarModule 
  ],  
  exports: [
    MatTabsModule,
    MatSidenavModule,
    MatToolbarModule 
  ]
})
export class MaterialModule { }
