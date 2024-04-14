using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LotteryMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string Name { get; init; }
    public uint MasterLotteryInfoId { get; init; }
    public uint MasterCautionId { get; init; }
    public uint Category { get; init; }
    public LotteryType Type { get; init; }
    public int Priority { get; init; }
    public uint MasterLotteryPriceId { get; init; }
    public uint MasterLotteryRarityId { get; init; }
    public uint MasterLotteryImageId { get; init; }
    public required string BalloonSpriteName { get; init; }
    public uint StartdashTime { get; init; }
    public uint StartdashExpireTime { get; init; }
    public uint CheckDisplayableLottery { get; init; }
    public uint Repeat { get; init; }
    public uint ExchangeMasterItemId { get; init; }
    public uint MasterLotteryEffMovieId { get; init; }
    public uint MasterLotteryEffMovieRatioId { get; init; }
    public uint StoreReviewFlag { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public LotteryMst() { }

    protected LotteryMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Name = info.GetString("_name")!;
        MasterLotteryInfoId = info.GetUInt32("_masterLotteryInfoId");
        MasterCautionId = info.GetUInt32("_masterCautionId");
        Category = info.GetUInt32("_category");
        Type = (LotteryType)info.GetValue("_type", typeof(LotteryType))!;
        Priority = info.GetInt32("_priority");
        MasterLotteryPriceId = info.GetUInt32("_masterLotteryPriceId");
        MasterLotteryRarityId = info.GetUInt32("_masterLotteryRarityId");
        MasterLotteryImageId = info.GetUInt32("_masterLotteryImageId");
        BalloonSpriteName = info.GetString("_balloonSpriteName")!;
        StartdashTime = info.GetUInt32("_startdashTime");
        StartdashExpireTime = info.GetUInt32("_startdashExpireTime");
        CheckDisplayableLottery = info.GetUInt32("_checkDisplayableLottery");
        Repeat = info.GetUInt32("_repeat");
        ExchangeMasterItemId = info.GetUInt32("_exchangeMasterItemId");
        MasterLotteryEffMovieId = info.GetUInt32("_masterLotteryEffMovieId");
        MasterLotteryEffMovieRatioId = info.GetUInt32("_masterLotteryEffMovieRatioId");
        StoreReviewFlag = info.GetUInt32("_storeReviewFlag");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_name", Name);
        info.AddValue("_masterLotteryInfoId", MasterLotteryInfoId);
        info.AddValue("_masterCautionId", MasterCautionId);
        info.AddValue("_category", Category);
        info.AddValue("_type", Type);
        info.AddValue("_priority", Priority);
        info.AddValue("_masterLotteryPriceId", MasterLotteryPriceId);
        info.AddValue("_masterLotteryRarityId", MasterLotteryRarityId);
        info.AddValue("_masterLotteryImageId", MasterLotteryImageId);
        info.AddValue("_balloonSpriteName", BalloonSpriteName);
        info.AddValue("_startdashTime", StartdashTime);
        info.AddValue("_startdashExpireTime", StartdashExpireTime);
        info.AddValue("_checkDisplayableLottery", CheckDisplayableLottery);
        info.AddValue("_repeat", Repeat);
        info.AddValue("_exchangeMasterItemId", ExchangeMasterItemId);
        info.AddValue("_masterLotteryEffMovieId", MasterLotteryEffMovieId);
        info.AddValue("_masterLotteryEffMovieRatioId", MasterLotteryEffMovieRatioId);
        info.AddValue("_storeReviewFlag", StoreReviewFlag);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
