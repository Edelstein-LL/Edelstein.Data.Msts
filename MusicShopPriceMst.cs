using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class MusicShopPriceMst : IGameMst, ISerializable
{
    public uint MasterMusicId { get; set; }

    public ConsumeType ConsumeType { get; set; }
    public uint Value { get; set; }
    public int Amount { get; set; }
    public int Priority { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
