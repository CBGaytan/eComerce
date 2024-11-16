
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Serialization;

namespace Vo;
using static Vo.StaticDefinition;
[DataContract]

public class Products
{
    [DataMember(EmitDefaultValue = false)]
    public int Id { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string name { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string Description { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public double price { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public int courrentStock { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public int maxstock { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public int minStock { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public eStockStatus eStockStatusid { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public double imgPath { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public DateTime Created_At { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public DateTime Update_At { get; set; }
    
    
}