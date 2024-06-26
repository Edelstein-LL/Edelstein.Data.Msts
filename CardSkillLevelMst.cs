using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class CardSkillLevelMst : IGameMst, ISerializable
{
    public uint Id { get; set; }
    public int Level { get; set; }
    public int Exp { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
