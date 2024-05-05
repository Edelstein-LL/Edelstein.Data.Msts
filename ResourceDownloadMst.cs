using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ResourceDownloadMst : ISerializable
{
    [Key]
    public uint Id { get; set; }

    public required string ImageName { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public ResourceDownloadMst() { }

    protected ResourceDownloadMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        ImageName = info.GetString("_imageName")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_imageName", ImageName);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
