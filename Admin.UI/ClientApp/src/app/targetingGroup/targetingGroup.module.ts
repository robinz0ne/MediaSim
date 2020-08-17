import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import { TargetingGroupComponent } from './targetingGroup.component';
import { PeoplesComponent } from './peoples/peoples.component'

const appRoutes: Routes = [
    {
        path: 'targetingGroup', component: TargetingGroupComponent
    },
];

@NgModule({
    imports: [
        RouterModule.forRoot(appRoutes),
        BrowserModule,
        FormsModule
    ],
    declarations: [
        TargetingGroupComponent,
        PeoplesComponent,
    ],
})
export class TargetingGroupModule { }

