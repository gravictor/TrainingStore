using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingStore.Data.Interfaces;
using TrainingStore.Data.Models;

namespace TrainingStore.Data.Mocks
{
    public class MockPhones : IAllPhones
    {
        private readonly IPhonesCategory _categoryPhones = new MockCategory();
        public int trarr;
        public IEnumerable<Phone> phones
        {
            get
            {
                return new List<Phone>
                {
                    new Phone
                    {
                        Name = "iPhone 11",
                        ShortDesc ="Cупермощное яблоко с двойной камерой",
                        LongDesc="В сентябре 2019 года презентован супермощный «яблочный» телефон с двойной передней камерой и ярким жидкокристаллическим экраном. Коммуникатор получил улучшенные технические показатели, энергоемкую батарею и инновационную операционную систему IOS 13. iPhone 11 128 GB Black оборудован умным чипсетом, современными детекторами и беспроводными коммуникациями. Благодаря встроенному сенсору распознавания лица Face ID можно легко разблокировать девайс и запустить приложения при помощи одного взгляда.",
                        Image = "/img/iPhone11.jpg",
                        Price = 950,
                        IsFavourite= true,
                        Aviable = true,
                        Category = _categoryPhones.AllCategories.First()
                    },
                    new Phone
                    {
                        Name = "iPhone 8+",
                        ShortDesc = "Уникальный дизайн и большой дисплей",
                        LongDesc = "Отличительная особенность айфона восьмого поколения – дизайн. Тыльная и фронтальная стороны изготовлены из сверхпрочного и надежного армированного стекла. Компания Apple использует этот материал для всех своих гаджетов.",
                        Image = "/img/iPhone8plus.jpg",
                        Price = 700,
                        IsFavourite = false,
                        Aviable = true,
                        Category = _categoryPhones.AllCategories.First()
                    },
                    new Phone
                    {
                        Name = "Samsung Galaxy s10+",
                        ShortDesc = "Габариты изогнутого экрана и невероятная производительность девайса.",
                        LongDesc = "Девайс производится с чипом Exynos 9820 и графическим модулем Mali-G76 MP12 либо с чипсетом Snapdragon 855 и видеоускорителем Adreno 640. Флагман получил 8 GB оперативной памяти, а внутренний накопитель способен хранить информацию, объем которой не превышает 128 ГБ.",
                        Image = "/img/s10plus.jpg",
                        Price = 1100,
                        IsFavourite = true,
                        Aviable = true,
                        Category = _categoryPhones.AllCategories.Last()
                    },
                    new Phone
                    {
                        Name = "Samsung galaxy note 4",
                        ShortDesc = "Это уже даже не просто смартфон.",
                        LongDesc = "Обновленный дизайн заставляет влюбиться в Samsung Galaxy Note 4 N910H буквально с первого взгляда. На его внешний облик сильно повлиял большой 5,7 дюймовый экран. ",
                        Image = "/img/galaxy4note.jpg",
                        Price = 300,
                        IsFavourite = false,
                        Aviable = false,
                        Category = _categoryPhones.AllCategories.Last()
                    }
                };
            }
        }
        public IEnumerable<Phone> GetFavPhones { get; set; }

        public Phone GetObjectPhone(int PhoneId)
        {
            throw new NotImplementedException();
        }
    }
}
