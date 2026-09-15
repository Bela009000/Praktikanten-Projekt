import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';
import { CommonModule } from '@angular/common';

@Component({
  imports: [FormsModule, RouterLink, CommonModule],
  selector: 'app-register',
  styleUrl: './register.css',
  templateUrl: './register.html',
})
export class Register {
  username = '';
  password = '';
  message = '';
  isSuccess = false;

  onSubmit() {
    const users = JSON.parse(localStorage.getItem('users') || '[]');

    const usernameExists = users.some((u: any) => u.username === this.username);
    if (usernameExists) {
      this.message = 'Dieser Benutzername ist bereits vergeben.';
      this.isSuccess = false;
      return;
    }

    users.push({
      username: this.username,
      password: this.password,
    });

    localStorage.setItem('users', JSON.stringify(users));

    this.message = 'Registrierung erfolgreich!';
    this.isSuccess = true;
  }
}