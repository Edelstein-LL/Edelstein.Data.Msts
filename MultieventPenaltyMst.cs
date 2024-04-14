using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class MultieventPenaltyMst : ISerializable
{
    [Key]
    public uint PenaltyCount { get; init; }

    public int PenaltySec { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public MultieventPenaltyMst() { }

    protected MultieventPenaltyMst(SerializationInfo info, StreamingContext context)
    {
        PenaltyCount = info.GetUInt32("_penaltyCount");
        PenaltySec = info.GetInt32("_penaltySec");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_penaltyCount", PenaltyCount);
        info.AddValue("_penaltySec", PenaltySec);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
