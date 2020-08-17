import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { NotFoundComponent } from './not-found.component';

const appRoutes: Routes = [
    {
        path: '**', component: NotFoundComponent
    },
];

@NgModule({
    imports: [
        RouterModule.forRoot(appRoutes)
    ],
    declarations: [
        NotFoundComponent,
    ],
})
export class ErrorsModule { }