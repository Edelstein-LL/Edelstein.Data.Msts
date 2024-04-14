using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LotteryStepupMst : ISerializable
{
    [Key]
    public uint MasterLotteryId { get; init; }

    public int Count { get; init; }
    public int NextCount { get; init; }
    public uint MasterLotteryPriceId { get; init; }
    public uint MasterLotteryRarityId { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public LotteryStepupMst() { }

    protected LotteryStepupMst(SerializationInfo info, StreamingContext context)
    {
        MasterLotteryId = info.GetUInt32("_masterLotteryId");
        Count = info.GetInt32("_count");
        NextCount = info.GetInt32("_nextCount");
        MasterLotteryPriceId = info.GetUInt32("_masterLotteryPriceId");
        MasterLotteryRarityId = info.GetUInt32("_masterLotteryRarityId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterLotteryId", MasterLotteryId);
        info.AddValue("_count", Count);
        info.AddValue("_nextCount", NextCount);
        info.AddValue("_masterLotteryPriceId", MasterLotteryPriceId);
        info.AddValue("_masterLotteryRarityId", MasterLotteryRarityId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
