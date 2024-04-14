using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(Id), nameof(Level))]
public class CardLevelMst : ISerializable
{
    public uint Id { get; init; }
    public int Level { get; init; }
    public int Exp { get; init; }
    public int HpRatio { get; init; }
    public int SmileRatio { get; init; }
    public int PureRatio { get; init; }
    public int CoolRatio { get; init; }
    public uint MasterReleaseLabelId { get; init; }

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
