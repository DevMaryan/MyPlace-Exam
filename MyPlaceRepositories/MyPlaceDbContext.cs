using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyPlaceModels;

namespace MyPlaceRepositories
{
    public class MyPlaceDbContext : IdentityDbContext
    {
        public MyPlaceDbContext(DbContextOptions<MyPlaceDbContext> options) : base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }

    }
}
