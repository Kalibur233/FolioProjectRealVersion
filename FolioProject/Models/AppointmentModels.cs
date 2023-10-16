using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FolioProject.Models
{
    public class AppointmentModels
    {
        public int Id { get; set; }
        public MedicImage MedicImage { get; set; }
        //public int MedicImage MedicImageId { get; set; }
        //[Required]
        //public DateTime AppointmentTime { get; set; }

        //public String Description { get; set; }

    }

}