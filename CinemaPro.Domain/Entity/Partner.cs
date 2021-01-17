using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaPro.Domain.Entity
{
    public class Partner
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        [NotMapped]
        public string LogoTemp { get; set; }
    }
}
