using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Serialization;

namespace Vo;
[DataContract]
public class Order
{
    [DataMember(EmitDefaultValue = false)]
    public int Id { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public double TotalPrice { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string Status { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public DateTime Created_At { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public DateTime Update_At { get; set; }

}