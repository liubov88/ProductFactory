namespace ProductFactory;
class ProductActions
{
  private IList<ProductWrapper> products;

  public ProductActions(IList<ProductWrapper> products)
  {
    this.products = products;  
  }

  public void UpdateValuesForProducts()
  {
    int hourNow = DateTime.Now.Hour;
    for (int i = 0; i < products.Count; i++)
    {
      if (products[i].ProductType == "AllDay" || (products[i].StartHour <= hourNow && products[i].EndHour >= hourNow))
      {
       products[i].DisplayValue();
      }      
    }
  }
}