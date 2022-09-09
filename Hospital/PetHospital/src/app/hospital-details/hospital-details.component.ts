import { Component, OnInit } from '@angular/core';
import { HospitalDetailService } from '../shared/hospital-detail.service';

@Component({
  selector: 'app-hospital-details',
  templateUrl: './hospital-details.component.html',
  styles: [
  ]
})
export class HospitalDetailsComponent implements OnInit {

  constructor(public service: HospitalDetailService) { }

  ngOnInit(): void {
    this.service.refreshList();
  }

}
