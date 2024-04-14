using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LiveEffectValueMst : ISerializable
{
    [Key]
    public int Id { get; init; }

    public required string EffectObjectName { get; init; }
    public required string BaseColor { get; init; }
    public required string ChangeColor { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public LiveEffectValueMst() { }

    protected LiveEffectValueMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetInt32("_id");
        EffectObjectName = info.GetString("_effectObjectName")!;
        BaseColor = info.GetString("_baseColor")!;
        ChangeColor = info.GetString("_changeColor")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_effectObjectName", EffectObjectName);
        info.AddValue("_baseColor", BaseColor);
        info.AddValue("_changeColor", ChangeColor);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
