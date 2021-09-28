import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-dress',
  templateUrl: './dress.component.html',
  styleUrls: ['./dress.component.css']
})
export class DressComponent implements OnInit {

  product1 = {dressId:1, dressName:'mini dress', categoryId:1, unitPrice:3}
  product2 = {dressId:2, dressName:'midi dress', categoryId:2, unitPrice:3}
  product3 = {dressId:3, dressName:'maxi dress', categoryId:4, unitPrice:3}

  products = [
    this.product1,
    this.product2,
    this.product3
  ];
  constructor() { }

  ngOnInit(): void {
  }

}
