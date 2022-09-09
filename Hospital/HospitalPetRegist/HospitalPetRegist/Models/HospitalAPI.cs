using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalPetRegist.Models
{
    public class HospitalAPI
    {

        [Key]
        public int NumberId { get; set; }





        [Column(TypeName = "nvarchar(8)")]
        public string OwnersName { get; set; }


        [Column(TypeName = "nvarchar(10)")]
        public string OwnersLastname { get; set; }


        [Column(TypeName = "nvarchar(8)")]
        public string PetsName { get; set; }


        [Column(TypeName = "nvarchar(10)")]
        public string MobileNumber { get; set; }


        [Column(TypeName = "nvarchar(10)")]
        public string Data { get; set; }


        [Column(TypeName = "nvarchar(5)")]
        public string Time { get; set; }


        [Column(TypeName = "nvarchar(15)")]
        public string Services { get; set; }
    }
}
