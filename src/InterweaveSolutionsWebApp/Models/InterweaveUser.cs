using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterweaveSolutionsWebApp.Models
{
    public class InterweaveUser : IdentityUser
    {
        public string CertificateID { get; set; }
    }
}
