import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss'],
})
export class EventosComponent implements OnInit {
  public eventos: any = [];
  public eventosFiltered: any = []; // Array filtrado
  widthImg: number = 150;
  marginImg: number = 2;
  showImage: boolean = true;

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.getEventos();
  }

  alterImage() {
    this.showImage = !this.showImage;
  }

  public getEventos(): void {
    this.http.get('https://localhost:7175/api/eventos').subscribe(
      (response) => {
        this.eventos = response;
        this.eventosFiltered = [...this.eventos]; // Inicializa o filtro com todos os eventos
      },
      (error) => console.log(error)
    );
  }

  // Função para filtrar os eventos com base no texto de busca
  filterEventos(filterText: string): void {
    if (!filterText) {
      this.eventosFiltered = [...this.eventos]; // Se o filtro estiver vazio, mostra todos os eventos
    } else {
      this.eventosFiltered = this.eventos.filter((evento: any) =>
        this.eventoContainsText(evento, filterText)
      );
    }
  }

  // Função auxiliar para verificar se um evento contém o texto de busca
  eventoContainsText(evento: any, filterText: string): boolean {
    return (
      evento.tema.toLowerCase().includes(filterText.toLowerCase()) ||
      evento.local.toLowerCase().includes(filterText.toLowerCase()) ||
      evento.dataEvento.toLowerCase().includes(filterText.toLowerCase()) ||
      evento.qtdPessoas.toString().includes(filterText) || // Converte para string para busca numérica
      evento.lote.toString().includes(filterText) // Converte para string para busca numérica
    );
  }
}
