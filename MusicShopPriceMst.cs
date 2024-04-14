using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class MusicShopPriceMst : ISerializable
{
    [Key]
    public uint MasterMusicId { get; init; }

    public ConsumeType ConsumeType { get; init; }
    public uint Value { get; init; }
    public int Amount { get; init; }
    public int Priority { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public MusicShopPriceMst() { }

    protected MusicShopPriceMst(SerializationInfo info, StreamingContext context)
    {
        MasterMusicId = info.GetUInt32("_masterMusicId");
        ConsumeType = (ConsumeType)info.GetValue("_consumeType", typeof(ConsumeType))!;
        Value = info.GetUInt32("_value");
        Amount = info.GetInt32("_amount");
        Priority = info.GetInt32("_priority");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterMusicId", MasterMusicId);
        info.AddValue("_consumeType", ConsumeType);
        info.AddValue("_value", Value);
        info.AddValue("_amount", Amount);
        info.AddValue("_priority", Priority);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
