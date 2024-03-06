import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-tippek',
  templateUrl: './tippek.component.html',
  styleUrls: ['./tippek.component.css']
})
export class TippekComponent {
@Input() tippek:any
ujTipp:any={}

oszlopok =[
  {key:"sz1", text:"Szám1"},
  {key:"sz2", text:"Szám2"},
  {key:"sz3", text:"Szám3"},
  {key:"sz4", text:"Szám4"},
  {key:"sz5", text:"Szám5"},
]
}
