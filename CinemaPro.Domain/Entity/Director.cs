using System.Collections.Generic;

namespace CinemaPro.Domain.Entity
{
    public class Director
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Moviedetail> Moviedetails { get; set; }


    }
}
