using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ExchangeItemMst : IGameMst, ISerializable
{
    public uint Id { get; set; }

    public ConsumeType ConsumeType { get; set; }
    public uint Value { get; set; }
    public int Amount { get; set; }
    public uint MasterExchangeItemRewardId { get; set; }
    public int ExchangeLimit { get; set; }
    public TimeResetType TimeResetType { get; set; }
    public required string RecommendMarkClosedAt { get; set; }
    public uint MasterEventId { get; set; }
    public int Priority { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public ExchangeItemMst() { }

    protected ExchangeItemMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        ConsumeType = (ConsumeType)info.GetValue("_consumeType", typeof(ConsumeType))!;
        Value = info.GetUInt32("_value");
        Amount = info.GetInt32("_amount");
        MasterExchangeItemRewardId = info.GetUInt32("_masterExchangeItemRewardId");
        ExchangeLimit = info.GetInt32("_exchangeLimit");
        TimeResetType = (TimeResetType)info.GetValue("_timeResetType", typeof(TimeResetType))!;
        RecommendMarkClosedAt = info.GetString("_recommendMarkClosedAt")!;
        MasterEventId = info.GetUInt32("_masterEventId");
        Priority = info.GetInt32("_priority");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_consumeType", ConsumeType);
        info.AddValue("_value", Value);
        info.AddValue("_amount", Amount);
        info.AddValue("_masterExchangeItemRewardId", MasterExchangeItemRewardId);
        info.AddValue("_exchangeLimit", ExchangeLimit);
        info.AddValue("_timeResetType", TimeResetType);
        info.AddValue("_recommendMarkClosedAt", RecommendMarkClosedAt);
        info.AddValue("_masterEventId", MasterEventId);
        info.AddValue("_priority", Priority);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
