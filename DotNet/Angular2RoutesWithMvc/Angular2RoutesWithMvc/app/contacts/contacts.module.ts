import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';


import { ContactsRoutingModule } from './contacts-routing.module';
import { ContactsComponent } from './contacts.component';


@NgModule({
    imports: [
        FormsModule,
        ContactsRoutingModule
    ],
    declarations: [
        ContactsComponent
    ]
})
export class ContactsModule {
}
