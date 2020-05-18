using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using TrainingStore.Data.Interfaces;
using TrainingStore.Data.Models;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace TrainingStore.Data.Repository
{
    public class PhoneRepository : IAllPhones
    {
        private readonly AppDBContent appDBContent;
        public PhoneRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        Phone phone;
        public IEnumerable<Phone> phones => appDBContent.Phone.Where(c => c.Aviable);

        public IEnumerable<Phone> GetFavPhones => appDBContent.Phone.Where(p => p.IsFavourite);

        public Phone GetObjectPhone(int phoneId) => appDBContent.Phone.FirstOrDefault(p =>p.ID == phoneId);

    }
}
