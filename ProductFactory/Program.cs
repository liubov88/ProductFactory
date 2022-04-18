namespace ProductFactory;
static class Program
{
  public static void Main(String[] args)
  {
    try
    {
      IList<ProductWrapper> products = new List<ProductWrapper>();
      products = ListAllProducts();

      if (products == null || products.Count() == 0)
      {
        Console.WriteLine("There are no products available at this time of day");
      }
      else
      {
        System.Console.WriteLine("Products available current time of day:");

        ProductActions app = new ProductActions(products);
        app.UpdateValuesForProducts();
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine("Error: " + ex.Message);
    }
    Console.ReadKey();
  }

  public static IList<ProductWrapper> ListAllProducts()
  {
    IList<ProductWrapper> products = new List<ProductWrapper>{
       StaticProductFactory.CreateProduct("Orange Juice", "AllDay"),
      StaticProductFactory.CreateProduct("Breakfast Burrito", "Limited", 8, 12),
      StaticProductFactory.CreateProduct("Steak & Chips", "Limited", 12, 21),
      StaticProductFactory.CreateProduct("Chicken Sandwich", "Limited", 11, 19),
      StaticProductFactory.CreateProduct("Sam Adams Seasonal", "Limited", 17, 23),
      };
    return products;
  }
}