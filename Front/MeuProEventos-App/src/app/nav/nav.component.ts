// import { Component, OnInit } from '@angular/core';

// @Component({
//   selector: 'app-nav',
//   templateUrl: './nav.component.html',
//   styleUrls: ['./nav.component.scss']
// })
// export class NavComponent implements OnInit {

//   constructor() { }

//   ngOnInit(): void {
//   }

// }

import { Component } from '@angular/core';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.scss'],
})
export class NavComponent {
  isMenuActive = false;

  toggleMenu() {
    this.isMenuActive = !this.isMenuActive;
    const navUl = document.querySelector('nav ul');
    if (navUl) {
      navUl.classList.toggle('active', this.isMenuActive);
    }
  }
}
