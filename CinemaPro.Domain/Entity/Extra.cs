using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaPro.Domain.Entity
{
    public class Extra
    {
        public int Id { get; set; }

        public string Packet { get; set; }

        public string Cost { get; set; }

        public string Desc { get; set; }

        public string Image { get; set; }
        [NotMapped]
        public string ImageTemp { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }




    }
}
