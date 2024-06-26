using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LotteryMst : IGameMst, ISerializable
{
    public uint Id { get; set; }

    public required string Name { get; set; }
    public uint MasterLotteryInfoId { get; set; }
    public uint MasterCautionId { get; set; }
    public uint Category { get; set; }
    public LotteryType Type { get; set; }
    public int Priority { get; set; }
    public uint MasterLotteryPriceId { get; set; }
    public uint MasterLotteryRarityId { get; set; }
    public uint MasterLotteryImageId { get; set; }
    public required string BalloonSpriteName { get; set; }
    public uint StartdashTime { get; set; }
    public uint StartdashExpireTime { get; set; }
    public uint CheckDisplayableLottery { get; set; }
    public uint Repeat { get; set; }
    public uint ExchangeMasterItemId { get; set; }
    public uint MasterLotteryEffMovieId { get; set; }
    public uint MasterLotteryEffMovieRatioId { get; set; }
    public uint StoreReviewFlag { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
