using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Serialization;
namespace Vo;
[DataContract]

public class Cart_items
{
    [DataMember(EmitDefaultValue = false)]
    public int Id { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public int CartId { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public int ProductId { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public int Quantity{ get; set; }
    [DataMember(EmitDefaultValue = false)]
    public double price { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public DateTime Created_At { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public DateTime Update_At { get; set; }
}