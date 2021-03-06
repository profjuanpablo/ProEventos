import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './eventos.component.html',
  styleUrls: ['./eventos.component.scss']
})
export class EventosComponent implements OnInit {

  public eventos: any=[];
  public eventosFiltrados: any = [];

  marginImg: number=2;
  widthImg: number=150;
  mostrarImagem: boolean = true;
  private _filtroLista: string = '';


  public get filtroLista(): string{
    return this._filtroLista;
   }

   public set filtroLista(value: string){
    this._filtroLista = value;
    this.eventosFiltrados = this.filtroLista ? this.filtrarEventos(this.filtroLista): this.eventos;
   }

    filtrarEventos(filtrarPor: string): any {
        filtrarPor= filtrarPor.toLocaleLowerCase();
        return this.eventos.filter(
          // (evento: any) => evento.tema.toLocaleLowerCase().indexof(filtroPor) !== -1
          //  (evento:{tema: string;local:string})  => evento.tema.toLocaleLowerCase().indexOf(filtroPor) !== -1);

        (evento:{tema: string;local:string;lote:string})  => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
       evento.local.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
       evento.lote.toLocaleLowerCase().indexOf(filtrarPor) !== -1

        );
    }

  constructor(private htpp: HttpClient) { }

  ngOnInit(): void {
    this.getEventos();
  }

    alterarImagem() {
        this.mostrarImagem=!this.mostrarImagem;

    }

    public getEventos(): void {
    this.htpp.get('https://localhost:5001/api/Eventos').subscribe(
      response => {
        this.eventos = response;
        this.eventosFiltrados = this.eventos;
      },
      error => console.log(error));


  }
}
