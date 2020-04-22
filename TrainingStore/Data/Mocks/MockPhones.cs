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
                        Name = "Iphone 11",
                        ShortDesc ="Cупермощный «яблочный» телефон с двойной передней камерой",
                        LongDesc="В сентябре 2019 года презентован супермощный «яблочный» телефон с двойной передней камерой и ярким жидкокристаллическим экраном. Коммуникатор получил улучшенные технические показатели, энергоемкую батарею и инновационную операционную систему IOS 13. iPhone 11 128 GB Black оборудован умным чипсетом, современными детекторами и беспроводными коммуникациями. Благодаря встроенному сенсору распознавания лица Face ID можно легко разблокировать девайс и запустить приложения при помощи одного взгляда.",
                        Image = "https://estore.ua/media/catalog/product/cache/8/small_image/295x295/9df78eab33525d08d6e5fb8d27136e95/i/p/iphone11-black-select1-2019_2.jpeg",
                        Price = 950,
                        IsFavourite= true,
                        Aviable = true,
                        Category = _categoryPhones.AllCategories.First()
                    },
                    new Phone
                    {
                        Name = "Ipone 8+",
                        ShortDesc = "Уникальный дизайн и большой дисплей",
                        LongDesc = "Отличительная особенность айфона восьмого поколения – дизайн. Тыльная и фронтальная стороны изготовлены из сверхпрочного и надежного армированного стекла. Компания Apple использует этот материал для всех своих гаджетов.",
                        Image = "https://estore.ua/media/catalog/product/cache/8/small_image/295x295/9df78eab33525d08d6e5fb8d27136e95/4/b/4bf0ff4a0ac294b8751e185554ab8737_1.jpg",
                        Price = 700,
                        IsFavourite = false,
                        Aviable = true,
                        Category = _categoryPhones.AllCategories.First()
                    },
                    new Phone
                    {
                        Name = "Samsung Galaxy s10+",
                        ShortDesc = "Внушительные габариты изогнутого безрамочного экрана и невероятная производительность девайса покорили каждого.",
                        LongDesc = "Девайс производится с чипом Exynos 9820 и графическим модулем Mali-G76 MP12 либо с чипсетом Snapdragon 855 и видеоускорителем Adreno 640. Флагман получил 8 GB оперативной памяти, а внутренний накопитель способен хранить информацию, объем которой не превышает 128 ГБ.",
                        Image = "https://estore.ua/media/catalog/product/cache/8/small_image/295x295/9df78eab33525d08d6e5fb8d27136e95/i/m/image_product_key_visual_beyond_s10_product_image_black_181211_sm_g973_galaxys10_front_black.jpg",
                        Price = 1100,
                        IsFavourite = true,
                        Aviable = true,
                        Category = _categoryPhones.AllCategories.Last()
                    },
                    new Phone
                    {
                        Name = "Samsung galaxy note 4",
                        ShortDesc = "Это уже даже не просто смартфон, а вполне себе полноценный фаблет со всеми вытекающими отсюда возможностями.",
                        LongDesc = "Обновленный дизайн заставляет влюбиться в Samsung Galaxy Note 4 N910H буквально с первого взгляда. На его внешний облик сильно повлиял большой 5,7 дюймовый экран. ",
                        Image = "https://i.allo.ua/media/images/products/SamsungGalaxyNote4N910H/4444.jpg",
                        Price = 300,
                        IsFavourite = false,
                        Aviable = false,
                        Category = _categoryPhones.AllCategories.Last()
                    },
                    new Phone
                    {
                        Name = "Samsung galaxy a51",
                        ShortDesc = "Классный бюджетник",
                        LongDesc = "Экран (6.5, Super AMOLED, 2400x1080)/ Samsung Exynos 9611 (2.3 ГГц + 1.7 ГГц)/ основная квадро-камера: 48 Мп + 12 Мп + 5 Мп + 5 Мп",
                        Image = "https://i8.rozetka.ua/goods/16041151/copy_samsung_sm_a515fzwusek_5e04c47d16006_images_16041151799.jpg",
                        Price = 250,
                        IsFavourite = true,
                        Aviable = true,
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
