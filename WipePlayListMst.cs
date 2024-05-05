using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class WipePlayListMst : ISerializable
{
    [Key]
    public uint Id { get; set; }

    public uint[] WipeIdList { get; set; } = [];
    public uint MasterReleaseLabelId { get; set; }

    public WipePlayListMst() { }

    protected WipePlayListMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        WipeIdList = (uint[])info.GetValue("_wipeIdList", typeof(uint[]))!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_wipeIdList", WipeIdList);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
