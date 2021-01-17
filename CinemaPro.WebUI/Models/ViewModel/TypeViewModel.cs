using CinemaPro.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaPro.WebUI.Models.ViewModel
{
    public class TypeViewModel
    {
        public Moviedetail Moviedetail { get; set; }
        public Seat Seat { get; set; }
        public Extra Extra { get; set; }
        public string Cat { get; set; }
        public string Format { get; set; }
        public int Totalamount { get; set; }

        public int Ticketid { get; set; }


    }
}
