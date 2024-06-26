using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class CardMst : IGameMst, ISerializable
{
    public uint Id { get; set; }

    public uint MasterCharacterId { get; set; }
    public required string Name { get; set; }
    public required CardType Type { get; set; }
    public uint MasterSkillCenterId { get; set; }
    public uint MasterSkillId { get; set; }
    public Rarity Rarity { get; set; }
    public int Hp { get; set; }
    public int Smile { get; set; }
    public int Cool { get; set; }
    public int Pure { get; set; }
    public required string IllustId { get; set; }
    public required string EvolveIllustId { get; set; }
    public uint MasterCardLevelId { get; set; }
    public required string UniqueBackgroundFileName { get; set; }
    public required string EvolveUniqueBackgroundFileName { get; set; }
    public GetCategory GetCategory { get; set; }
    public uint MasterCardSysVoiceId { get; set; }
    public uint AlbumUnitMId { get; set; }
    public int Priority { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public CardMst() { }

    protected CardMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        MasterCharacterId = info.GetUInt32("_masterCharacterId");
        Name = info.GetString("_name")!;
        Type = (CardType)info.GetValue("_type", typeof(CardType))!;
        MasterSkillCenterId = info.GetUInt32("_masterSkillCenterId");
        MasterSkillId = info.GetUInt32("_masterSkillId");
        Rarity = (Rarity)info.GetValue("_rarity", typeof(Rarity))!;
        Hp = info.GetInt32("_hp");
        Smile = info.GetInt32("_smile");
        Cool = info.GetInt32("_cool");
        Pure = info.GetInt32("_pure");
        IllustId = info.GetString("_illustId")!;
        EvolveIllustId = info.GetString("_evolveIllustId")!;
        MasterCardLevelId = info.GetUInt32("_masterCardLevelId");
        UniqueBackgroundFileName = info.GetString("_uniqueBackgroundFileName")!;
        EvolveUniqueBackgroundFileName = info.GetString("_evolveUniqueBackgroundFileName")!;
        GetCategory = (GetCategory)info.GetValue("_getCategory", typeof(GetCategory))!;
        MasterCardSysVoiceId = info.GetUInt32("_masterCardSysVoiceId");
        AlbumUnitMId = info.GetUInt32("_albumUnitMId");
        Priority = info.GetInt32("_priority");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_masterCharacterId", MasterCharacterId);
        info.AddValue("_name", Name);
        info.AddValue("_type", Type);
        info.AddValue("_masterSkillCenterId", MasterSkillCenterId);
        info.AddValue("_masterSkillId", MasterSkillId);
        info.AddValue("_rarity", Rarity);
        info.AddValue("_hp", Hp);
        info.AddValue("_smile", Smile);
        info.AddValue("_cool", Cool);
        info.AddValue("_pure", Pure);
        info.AddValue("_illustId", IllustId);
        info.AddValue("_evolveIllustId", EvolveIllustId);
        info.AddValue("_masterCardLevelId", MasterCardLevelId);
        info.AddValue("_uniqueBackgroundFileName", UniqueBackgroundFileName);
        info.AddValue("_evolveUniqueBackgroundFileName", EvolveUniqueBackgroundFileName);
        info.AddValue("_getCategory", GetCategory);
        info.AddValue("_masterCardSysVoiceId", MasterCardSysVoiceId);
        info.AddValue("_albumUnitMId", AlbumUnitMId);
        info.AddValue("_priority", Priority);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
