import { Injectable } from '@angular/core';
import { HospitalDetail } from './hospital-detail.model';
import { HttpClient } from "@angular/common/http";

@Injectable({
  providedIn: 'root'
})
export class HospitalDetailService {

  constructor(private http:HttpClient) { }


  formData:HospitalDetail = new HospitalDetail();
   readonly baseURL= 'https://localhost:44362/api/HospitalAPI'
list : HospitalDetail[];

  postHospitalDetail(){
   return this.http.post(this.baseURL,this.formData);

  }

  refreshList(){
    this.http.get(this.baseURL)
    .toPromise()
    .then(res => this.list = res as HospitalDetail[]);
  }
}
