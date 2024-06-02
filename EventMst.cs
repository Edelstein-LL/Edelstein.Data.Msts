using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class EventMst : IGameMst, ISerializable
{
    public uint Id { get; set; }

    public required string Name { get; set; }
    public EventType Type { get; set; }
    public MemberRankingType MemberRankingType { get; set; }
    public required string ResultClosedDate { get; set; }
    public required string AggregationDate { get; set; }
    public uint[] RewardMemberMasterCardIdList { get; set; } = [];
    public uint MasterEventPointSettingsId { get; set; }
    public required string OpeningObjName { get; set; }
    public BandCategory OpeningGroupBg { get; set; }
    public uint[] FavoriteMemberSettingCharacterIds { get; set; } = [];
    public uint MasterReleaseLabelId { get; set; }

    public EventMst() { }

    protected EventMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Name = info.GetString("_name")!;
        Type = (EventType)info.GetValue("_type", typeof(EventType))!;
        MemberRankingType = (MemberRankingType)info.GetValue("_memberRankingType", typeof(MemberRankingType))!;
        ResultClosedDate = info.GetString("_resultClosedDate")!;
        AggregationDate = info.GetString("_aggregationDate")!;
        RewardMemberMasterCardIdList = (uint[])info.GetValue("_rewardMemberMasterCardIdList", typeof(uint[]))!;
        MasterEventPointSettingsId = info.GetUInt32("_masterEventPointSettingsId");
        OpeningObjName = info.GetString("_openingObjName")!;
        OpeningGroupBg = (BandCategory)info.GetValue("_openingGroupBg", typeof(BandCategory))!;
        FavoriteMemberSettingCharacterIds = (uint[])info.GetValue("_favoriteMemberSettingCharacterIds", typeof(uint[]))!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_name", Name);
        info.AddValue("_type", Type);
        info.AddValue("_memberRankingType", MemberRankingType);
        info.AddValue("_resultClosedDate", ResultClosedDate);
        info.AddValue("_aggregationDate", AggregationDate);
        info.AddValue("_rewardMemberMasterCardIdList", RewardMemberMasterCardIdList);
        info.AddValue("_masterEventPointSettingsId", MasterEventPointSettingsId);
        info.AddValue("_openingObjName", OpeningObjName);
        info.AddValue("_openingGroupBg", OpeningGroupBg);
        info.AddValue("_favoriteMemberSettingCharacterIds", FavoriteMemberSettingCharacterIds);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
