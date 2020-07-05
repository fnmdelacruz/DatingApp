using DatingApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatingApp.Infra.Data.Context
{
    public class SampleDBContext : DbContext
    {
        public SampleDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Sample> Samples { get; set; }
    }

}
