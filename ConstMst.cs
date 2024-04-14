using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ConstMst : ISerializable
{
    [Key]
    public required string Id { get; init; }

    public required string Value { get; init; }
    public uint MasterReleaseLabelId { get; init; }

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
