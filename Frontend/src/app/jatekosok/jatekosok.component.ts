import { Component, OnDestroy } from '@angular/core';
import { BaseService } from '../base.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-jatekosok',
  templateUrl: './jatekosok.component.html',
  styleUrls: ['./jatekosok.component.css']
})
export class JatekosokComponent implements OnDestroy{
  jatekosok:any
  feliratkozas= new Subscription()

  constructor(private base:BaseService){
    this.feliratkozas= this.base.getJatekosok().subscribe(
      (res)=>{
        this.jatekosok=res
        for (let i = 0; i < this.jatekosok.Length; i++) 
          this.jatekosok.tippLatszik=false
          
        
      }
    )
  }

  ngOnDestroy(): void {
    this.feliratkozas.unsubscribe();
  }
}
