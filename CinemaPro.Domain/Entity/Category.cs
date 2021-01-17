using System.Collections.Generic;

namespace CinemaPro.Domain.Entity
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Mcat> Mcats { get; set; }




    }
}
