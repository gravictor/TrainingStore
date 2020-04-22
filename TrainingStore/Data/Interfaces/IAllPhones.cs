using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingStore.Data.Models;

namespace TrainingStore.Data.Interfaces
{
    interface IAllPhones
    {
        IEnumerable<Phone> phones { get; }
        IEnumerable<Phone> GetFavPhones { get; set; }
        Phone GetObjectPhone(int PhoneId);
    }
}
