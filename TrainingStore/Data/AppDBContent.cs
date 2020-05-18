using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TrainingStore.Data.Models;

namespace TrainingStore.Data
{
    public class AppDBContent : Microsoft.EntityFrameworkCore.DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public Microsoft.EntityFrameworkCore.DbSet<Phone> Phone {get; set;}
        public Microsoft.EntityFrameworkCore.DbSet<Category> Category { get; set; }


    }
}
