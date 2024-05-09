using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ConstMst : IGameMst, ISerializable
{
    [Key]
    public required string Id { get; set; }

    public required string Value { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public ConstMst() { }

    protected ConstMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetString("_id")!;
        Value = info.GetString("_value")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_value", Value);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
