using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CinemaPro.Domain.Entity.Membership
{
    [Table(name: "RoleClaims", Schema = "Membership")]
   public class CpRoleClaim: IdentityRoleClaim<int>
    {
    }
}
