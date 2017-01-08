import { Component, OnInit } from '@angular/core';

@Component({
    moduleId: module.id,
    selector: 'sample-contacts',
    templateUrl: 'contacts.component.html'
})
export class ContactsComponent implements OnInit {

    message = "This is a message.";

    constructor() {
    }

    ngOnInit() {
    }
}
