using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingStore.Data.Models;

namespace TrainingStore.Data.Interfaces
{
    interface IPhonesCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
