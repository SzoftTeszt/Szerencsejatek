import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BaseService {
  jatekosokSub = new BehaviorSubject(null)
  constructor(private http:HttpClient) { 
    this.loadJatekosok()
  }

  getJatekosok(){
    return this.jatekosokSub
  }

  loadJatekosok(){
    this.http.get("https://localhost:5000/api/Jatekos").subscribe(
      (res:any)=>this.jatekosokSub.next(res)
    )
  }

}
