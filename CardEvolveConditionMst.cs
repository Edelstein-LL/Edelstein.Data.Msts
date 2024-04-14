using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class CardEvolveConditionMst : ISerializable
{
    [Key]
    public uint MasterCardId { get; init; }

    public uint EvolveCount { get; init; }
    public uint MasterReleaseLabelId { get; init; }

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
