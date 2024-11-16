namespace Vo;

public class StaticDefinition
{
  public enum eStockStatus
  {
    IN_STOCK = 1,
    OUT_OF_STOCK ,
    LOW_STOCK
  }

  public enum eDbAction
  {
    insert=1,
    update=2,
    delete=3
  }
  
  public enum eErroType
  {
    none =0,
    NotFound = 1,
    Formaterror,
    Validation,
    Connection,
    TimeOut,
    Unknown=99
  }

  public class schema
  {
    public static readonly string Products = "Products";
    public static readonly string ProductsConf = "Products_Conf";
    public static readonly string Order = "Order";
    public static readonly string Order_items = "Order_items";
    public static readonly string Cart = "Cart";
    public static readonly string Cart_items = "Cart_items";
    
  }
  public class Procedure
  {
    public static readonly string Insert = "Insert";
    public static readonly string Update = "Update";
    public static readonly string Delete = "Delete";
    public static readonly string GetById = "GetById";
    public static readonly string GetAll = "GetAll";
    
    
  }
}