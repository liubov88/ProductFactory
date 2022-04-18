//Here I used overloading class (overloading when I have two/more methods with the same name but different signatures (or arguments) 
namespace ProductFactory;
static class StaticProductFactory
{
  public static ProductWrapper CreateProduct(String productName, string productType, int startHour, int endHour)
  {
    return new ProductWrapper(productName, productType, startHour, endHour);
  }

  //for ptoductType="AllDay" we dont need to have startHour & endHour 
  public static ProductWrapper CreateProduct(String productName, string productType)
  {
    return new ProductWrapper(productName, productType);
  }
}