using CoffeeShopWebApp.Models;

namespace CoffeeShopWebApp
{
    public class ProductRepository
    {
        private List<ProductViewModel> _mockProducts;

        public ProductRepository()
        {
            CreateMockStudentList();
        }
        private void CreateMockStudentList()
        {
            _mockProducts = new List<ProductViewModel>();
            _mockProducts.Add(new ProductViewModel { Id = 1,
                                                     Name = "Caramel Latte", 
                                                     Description = "Steamed Milk, 3 shots espressol, 3 pumps caramel syrup",
                                                     Price = 4.95,
                                                     Category = "Drink" });
            _mockProducts.Add(new ProductViewModel { Id = 2,
                                                     Name = "Scone", 
                                                     Description = "Flour, butter, sugar, sawdust",
                                                     Price = 2.95,
                                                     Category = "Baked goods" });
            _mockProducts.Add(new ProductViewModel { Id = 3,
                                                     Name = "Commemorative cup",
                                                     Description = "Coffee shop cup with logo, 14 oz.",
                                                     Price = 24.95,
                                                     Category = "Swag"
                                                   });
            _mockProducts.Add(new ProductViewModel { Id = 4,
                                                     Name = "Hard Drive",
                                                     Description = "Western Digital 1T",
                                                     Price = 10.39,
                                                     Category = "Hardware"
                                                   });
        }
        public IEnumerable<ProductViewModel> GetMockProducts()
        {
            return _mockProducts;
        }

        public void UpdateProduct(ProductViewModel product)
        {
            int index = _mockProducts.FindIndex(x => x.Id == product.Id);
            _mockProducts[index] = product;
        }

        public void DeleteProduct(int id)
        {
            int index = _mockProducts.FindIndex(x => x.Id == id);
            _mockProducts.RemoveAt(index);
        }
        public void CreateStudent(ProductViewModel product)
        {
            // get next student Id (I don't think we'd need this with a live DB)
            product.Id = _mockProducts.Max(x => x.Id) + 1;
            _mockProducts.Add(product);


        }
    }
}
