using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrainingStore.Data.Models;

namespace TrainingStore.Data
{
    public class DBObjects
    {
        public static void Initial(IApplicationBuilder app)
        {
            AppDBContent content;
            using (var scope = app.ApplicationServices.CreateScope())
            {
                 content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
            }
            

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }
            if (!content.Phone.Any())
            {
                content.AddRange(
                    new Phone
                    {
                        Name = "iPhone 11",
                        ShortDesc = "Cупермощное яблоко с двойной камерой",
                        LongDesc = "В сентябре 2019 года презентован супермощный «яблочный» телефон с двойной передней камерой и ярким жидкокристаллическим экраном. Коммуникатор получил улучшенные технические показатели, энергоемкую батарею и инновационную операционную систему IOS 13. iPhone 11 128 GB Black оборудован умным чипсетом, современными детекторами и беспроводными коммуникациями. Благодаря встроенному сенсору распознавания лица Face ID можно легко разблокировать девайс и запустить приложения при помощи одного взгляда.",
                        Image = "/img/iPhone11.jpg",
                        Price = 950,
                        IsFavourite = true,
                        Aviable = true,
                        Category = Categories["IOS"]
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
                        Category = Categories["IOS"]
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
                        Category = Categories["Android"]
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
                        Category = Categories["Android"]
                    }
                    );
            }


        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories 
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category {CategoryName = "IOS", Description ="Смартфоны на ОС IOS"},
                        new Category {CategoryName ="Android", Description ="Смартфоны на ОС Android"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.CategoryName, el);
                }
                return category;
            }
        }

    }
}
