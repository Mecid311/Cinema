using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaPro.Domain.Entity
{
    public class Seat
    {
        public int Id { get; set; }

        public string Row { get; set; }

        public int Column { get; set; }

        public string No { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }

    }
}
