import { Component } from '@angular/core';
import { RouterLink, Router } from '@angular/router';
import { CommonModule } from '@angular/common';
import { createIcons, PlayingCardsFan, BookOpen, Target } from 'lucide';
interface Topic {
  id: number;
  name: string;
}

@Component({
  imports: [RouterLink, CommonModule],
  selector: 'app-home',
  styleUrl: './home.css',
  templateUrl: './home.html',
})
export class Home {
  username = localStorage.getItem('currentUser') || '';
  topics: Topic[] = [];
  recentTopics: Topic[] = [];

  constructor(private router: Router) {}

  ngOnInit() {
    const saved = localStorage.getItem('topics');
    if (saved) {
      this.topics = JSON.parse(saved);
      this.recentTopics = this.topics.slice(-3).reverse();
    }
  }
  ngAfterViewInit() {
  createIcons({
    icons: {
      PlayingCardsFan,
      BookOpen,
      Target
    }
  });
}

  logout() {
    localStorage.removeItem('currentUser');
    this.router.navigate(['/login']);
  }
}