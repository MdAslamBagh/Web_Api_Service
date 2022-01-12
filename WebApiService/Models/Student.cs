using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;  //needed for DisplayName annotation

namespace WebApiService.Models
{
    public class Student
    {
        public int Id { get; set; }

        public string StudentRegNo { get; set; }

        public string Name { get; set; }



        public string Email { get; set; }


        public string Contact { get; set; }


        public string Address { get; set; }
    }
}