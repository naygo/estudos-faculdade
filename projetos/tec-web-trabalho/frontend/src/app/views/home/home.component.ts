import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  cabecalho =[
    'Nome',
    'Categoria',
    'Curtidas',
    'Ações'
  ]

  items = [
    {name: 'Naruto', category: 'Anime', likes: 1686},
    {name: 'Sword Art Online', category: 'Anime', likes: 4942},
    {name: 'Tartarugas Ninja', category: 'Filme', likes: 4784},
    {name: 'Lucifer', category: 'Seriado', likes: 126},
  ]

  constructor() { }

  ngOnInit(): void {
  }

}
