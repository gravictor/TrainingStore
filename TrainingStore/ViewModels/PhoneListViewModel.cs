using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingStore.Data.Models;

namespace TrainingStore.ViewModels
{
    public class PhonesListViewModel
    {
        public IEnumerable<Phone> AllPhones { get; set; }
        public string PhoneCategory { get; set; }
    }
}
