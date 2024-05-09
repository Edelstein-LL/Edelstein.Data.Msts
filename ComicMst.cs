using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ComicMst : IGameMst, ISerializable
{
    [Key]
    public uint Id { get; set; }

    public uint MasterGroupId { get; set; }
    public uint Number { get; set; }
    public required string Name { get; set; }
    public required string ImageName { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public ComicMst() { }

    protected ComicMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        MasterGroupId = info.GetUInt32("_masterGroupId");
        Number = info.GetUInt32("_number");
        Name = info.GetString("_name")!;
        ImageName = info.GetString("_imageName")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_masterGroupId", MasterGroupId);
        info.AddValue("_number", Number);
        info.AddValue("_name", Name);
        info.AddValue("_imageName", ImageName);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
