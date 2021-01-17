using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CinemaPro.Domain.Entity.Membership
{
    [Table(name: "Users", Schema = "Membership")]
   public class CpUser: IdentityUser<int>
    {
    }
}
