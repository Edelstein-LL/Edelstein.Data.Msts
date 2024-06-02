using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class CardLevelMst : IGameMst, ISerializable
{
    public uint Id { get; set; }
    public int Level { get; set; }
    public int Exp { get; set; }
    public int HpRatio { get; set; }
    public int SmileRatio { get; set; }
    public int PureRatio { get; set; }
    public int CoolRatio { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public CardLevelMst() { }

    protected CardLevelMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Level = info.GetInt32("_level");
        Exp = info.GetInt32("_exp");
        HpRatio = info.GetInt32("_hpRatio");
        SmileRatio = info.GetInt32("_smileRatio");
        PureRatio = info.GetInt32("_pureRatio");
        CoolRatio = info.GetInt32("_coolRatio");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_level", Level);
        info.AddValue("_exp", Exp);
        info.AddValue("_hpRatio", HpRatio);
        info.AddValue("_smileRatio", SmileRatio);
        info.AddValue("_pureRatio", PureRatio);
        info.AddValue("_coolRatio", CoolRatio);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
