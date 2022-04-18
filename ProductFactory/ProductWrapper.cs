namespace ProductFactory;
class ProductWrapper : Product
{
  //set base class
  public ProductWrapper(string productName, string productType, int startHour, int endHour) : base()
  {
    this.ProductName = productName;
    this.ProductType = productType;
    this.StartHour = startHour;
    this.EndHour = endHour;
  }

  public ProductWrapper(string productName, string productType) : base()
  {
    this.ProductName = productName;
    this.ProductType = productType;
  }


  public virtual void DisplayValue()
  {
    string displayName = this.ProductName;

    if (this.ProductType != "AllDay")
    {
      displayName += " (" + this.StartHour + ":00" + "-" + this.EndHour + ":00" + ")";
    }
    Console.WriteLine(displayName);
  }
}