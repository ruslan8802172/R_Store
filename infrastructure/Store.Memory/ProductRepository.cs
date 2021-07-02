using R_Store;
using System;
using System.Linq;
namespace Store.Memory
{
    public class ProductRepository : IProduct_Repository
    {
        private readonly Product[] products = new[]
        {
            new Product(1, "Смартфон DEXP G450 8 ГБ серый [4x1.3 ГГц, 1 Гб, 2 SIM, TN, 854x480, камера 2 Мп, 3G, GPS, FM, 2000 мА*ч]"),
            new Product(2, "Смартфон DEXP G450 8 ГБ синий [4x1.3 ГГц, 1 Гб, 2 SIM, TN, 854x480, камера 2 Мп, 3G, GPS, FM, 2000 мА*ч]"),
            new Product(3, "Смартфон BQ 4030G Nice Mini 16 ГБ золотистый [4x1.3 ГГц, 1 Гб, 2 SIM, TN, 800x480, камера 2 Мп, 3G, GPS, 1550 мА*ч]"),
            new Product(4, "Смартфон BQ 4030G Nice Mini 16 ГБ синий [4x1.3 ГГц, 1 Гб, 2 SIM, TN, 800x480, камера 2 Мп, 3G, GPS, 1550 мА*ч]"),
        };

        public Product[] GetAllByTitle(string titlePart)
        {
            return products.Where(Product => Product.Title.Contains(titlePart))
                .ToArray();
        }
    }
}
