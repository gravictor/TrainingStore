using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingStore.Data.Interfaces;
using TrainingStore.ViewModels;

namespace TrainingStore.Controllers
{
    public class PhonesController: Controller
    {
        private readonly IAllPhones _allPhones;
        private readonly IPhonesCategory _allCategories;

        public PhonesController(IAllPhones iAllCars, IPhonesCategory iPhonesCategory)
        {
            _allPhones = iAllCars;
            _allCategories = iPhonesCategory;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Страница с смартфонами";
            PhonesListViewModel obj = new PhonesListViewModel();
            obj.AllPhones = _allPhones.phones;
            obj.PhoneCategory = "Смартфоны";
            return View(obj);
        }
    }
}
