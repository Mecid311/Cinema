using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaPro.Domain.Entity
{
    public class Cast
    {
        public int Id { get; set; }

        public string Fullname { get; set; }

        public string Rolename { get; set; }

        public string Image { get; set; }

        [NotMapped]
        public string ImagePathTemp { get; set; }

        public virtual ICollection<Mcast> Mcasts { get; set; }
    }
}
