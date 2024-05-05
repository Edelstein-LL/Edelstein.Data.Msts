using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class MultieventMatchingrangeMst : ISerializable
{
    [Key]
    public uint Id { get; set; }

    public uint MatchingDiffPer { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public MultieventMatchingrangeMst() { }

    protected MultieventMatchingrangeMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        MatchingDiffPer = info.GetUInt32("_matchingDiffPer");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_matchingDiffPer", MatchingDiffPer);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
