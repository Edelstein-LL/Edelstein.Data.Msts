using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(Id), nameof(Number))]
public class LotteryPriceMst : ISerializable
{
    public uint Id { get; init; }
    public uint Number { get; init; }
    public ConsumeType ConsumeType { get; init; }
    public int Count { get; init; }
    public int Price { get; init; }
    public int LimitCount { get; init; }
    public int DailyLimitCount { get; init; }
    public uint MasterItemId { get; init; }
    public uint MasterLotteryRewardId { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public LotteryPriceMst() { }

    protected LotteryPriceMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Number = info.GetUInt32("_number");
        ConsumeType = (ConsumeType)info.GetValue("_consumeType", typeof(ConsumeType))!;
        Count = info.GetInt32("_count");
        Price = info.GetInt32("_price");
        LimitCount = info.GetInt32("_limitCount");
        DailyLimitCount = info.GetInt32("_dailyLimitCount");
        MasterItemId = info.GetUInt32("_masterItemId");
        MasterLotteryRewardId = info.GetUInt32("_masterLotteryRewardId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_number", Number);
        info.AddValue("_consumeType", ConsumeType);
        info.AddValue("_count", Count);
        info.AddValue("_price", Price);
        info.AddValue("_limitCount", LimitCount);
        info.AddValue("_dailyLimitCount", DailyLimitCount);
        info.AddValue("_masterItemId", MasterItemId);
        info.AddValue("_masterLotteryRewardId", MasterLotteryRewardId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
