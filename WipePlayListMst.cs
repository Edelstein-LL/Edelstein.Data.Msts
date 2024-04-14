using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class WipePlayListMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public uint MasterReleaseLabelId { get; init; }

    public WipePlayListMst() { }

    protected WipePlayListMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
