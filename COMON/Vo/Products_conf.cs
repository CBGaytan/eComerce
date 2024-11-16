
using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Serialization;
namespace Vo;
[DataContract]
public class Products_conf
{
    [DataMember(EmitDefaultValue = false)]
    public int Id { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public int ProductId { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public string Configuration_name { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public double value { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public DateTime Created_At { get; set; }
    [DataMember(EmitDefaultValue = false)]
    public DateTime Update_At { get; set; }

}