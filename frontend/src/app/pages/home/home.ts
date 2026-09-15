import { Component } from '@angular/core';
import { RouterLink, Router } from '@angular/router';

@Component({
  imports: [RouterLink],
  selector: 'app-home',
  styleUrl: './home.css',
  templateUrl: './home.html',
})
export class Home {
  username = localStorage.getItem('currentUser') || '';

  constructor(private router: Router) {}

  logout() {
    localStorage.removeItem('currentUser');
    this.router.navigate(['/login']);
  }
}