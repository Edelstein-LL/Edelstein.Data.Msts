using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(Id), nameof(Level))]
public class CardSkillLevelMst : ISerializable
{
    public uint Id { get; init; }
    public int Level { get; init; }
    public int Exp { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public CardSkillLevelMst() { }

    protected CardSkillLevelMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Level = info.GetInt32("_level");
        Exp = info.GetInt32("_exp");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_level", Level);
        info.AddValue("_exp", Exp);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
