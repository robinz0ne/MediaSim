import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { TargetingGroupModule } from './targetingGroup/targetingGroup.module'
import { HomeModule } from './home/home.module'
import { ErrorsModule } from './errors/errors.module'

import { AppComponent } from './app.component';


import { RouterModule } from '@angular/router';


@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        HttpClientModule,
        BrowserAnimationsModule,
        RouterModule,
        
        TargetingGroupModule,
        HomeModule,
        ErrorsModule,
    ],


    declarations: [
        AppComponent,
    ],
    bootstrap: [AppComponent]
})
export class AppModule { }

