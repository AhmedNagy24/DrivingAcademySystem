using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class AppDbContext : IdentityDbContext<User>
    {
    }
}
