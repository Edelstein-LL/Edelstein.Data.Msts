using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ChatAttachmentMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string Filename { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public ChatAttachmentMst() { }

    protected ChatAttachmentMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Filename = info.GetString("_filename")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_filename", Filename);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
