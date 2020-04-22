using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingStore.Data.Interfaces;
using TrainingStore.Data.Models;

namespace TrainingStore.Data.Mocks
{
    public class MockCategory : IPhonesCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{ CategoryName = "IOS", Description = "Телефоны на ОС IOS"},
                    new Category{CategoryName = "Android", Description="Телефоны на OC Android"}
                };
            }
        }

    }
}
