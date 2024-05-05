using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LotteryStepupMst : ISerializable
{
    [Key]
    public uint MasterLotteryId { get; set; }

    public int Count { get; set; }
    public int NextCount { get; set; }
    public uint MasterLotteryPriceId { get; set; }
    public uint MasterLotteryRarityId { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
