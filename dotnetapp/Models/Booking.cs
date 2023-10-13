
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dotnetapp.Models
{
    public class Booking
    {
        //write class here...
        public int BookingID { get; set; }  
        public int SlotID { get; set; }
        public string UserID { get; set; }

        [ForeignKey("SlotID")]
        public Slot slots { get; set; }
    }
}