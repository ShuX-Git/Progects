import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';
import { HospitalDetail } from 'src/app/shared/hospital-detail.model';
import { HospitalDetailService } from 'src/app/shared/hospital-detail.service';


@Component({
  selector: 'app-hospital-detail-form',
  templateUrl: './hospital-detail-form.component.html',
  styles: [
  ]
})
export class HospitalDetailFormComponent implements OnInit {

  constructor(public service:HospitalDetailService, private toastr:ToastrService) { }

  ngOnInit(): void {
  }


  onSubmit(form:NgForm){
  this.service.postHospitalDetail().subscribe(
   res =>{
    this.resetForm(form);
    this.toastr.success('Submitted successfully','Hospital Register')  
   },
    err =>{console.log(err);}
  );
 }

resetForm(form:NgForm){
  form.form.reset();
  this.service.formData =new HospitalDetail
}



}
