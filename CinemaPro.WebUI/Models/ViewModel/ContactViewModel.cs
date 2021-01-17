using CinemaPro.Domain.Entity;
using System.Collections.Generic;

namespace CinemaPro.Domain.ViewModel
{
    public class ContactViewModel
    {
        public Contact Contact { get; set; }
        public Contactus Contactus { get; set; }
        public List<Socialmedia> Socialmedia { get; set; }
    }
}
