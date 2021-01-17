using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CinemaPro.Domain.Entity.Membership
{
    [Table(name: "UserLogins", Schema = "Membership")]
   public class CpUserLogin : IdentityUserLogin<int>
    {
    }
}
