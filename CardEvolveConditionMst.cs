using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class CardEvolveConditionMst : IGameMst, ISerializable
{
    public uint MasterCardId { get; set; }

    public uint EvolveCount { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public CardEvolveConditionMst() { }

    protected CardEvolveConditionMst(SerializationInfo info, StreamingContext context)
    {
        MasterCardId = info.GetUInt32("_masterCardId");
        EvolveCount = info.GetUInt32("_evolveCount");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterCardId", MasterCardId);
        info.AddValue("_evolveCount", EvolveCount);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
