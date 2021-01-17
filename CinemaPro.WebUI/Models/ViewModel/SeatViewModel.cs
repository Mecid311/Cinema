using CinemaPro.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaPro.Domain.ViewModel
{
    public class SeatViewModel
    {
        public int ExtraId { get; set; }
        public List<Seat> SeatC1 { get; set; }
        public List<Seat> SeatC2 { get; set; }
        public List<Seat> SeatC3 { get; set; }
        public List<Seat> SeatB1 { get; set; }
        public List<Seat> SeatB2 { get; set; }
        public List<Seat> SeatB3 { get; set; }
        public List<Seat> SeatA1 { get; set; }
        public List<Seat> SeatA2 { get; set; }
        public List<Seat> SeatA3 { get; set; }
        public List<Ticket> Tickets { get; set; }
        public int MovieId { get; set; }
        



    }
}
