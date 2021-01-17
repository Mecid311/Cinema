using System.Collections.Generic;

namespace CinemaPro.Domain.Entity
{
    public class Format
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Mformat> Mformats { get; set; }
    }
}
