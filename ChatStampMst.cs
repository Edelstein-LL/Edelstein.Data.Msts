using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ChatStampMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string Name { get; init; }
    public BandCategory Group { get; init; }
    public uint IsUsableChat { get; init; }
    public uint IsUsableMulti { get; init; }
    public required string Filename { get; init; }
    public uint Order { get; init; }
    public uint InitialStamp { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public ChatStampMst() { }

    protected ChatStampMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Name = info.GetString("_name")!;
        Group = (BandCategory)info.GetValue("_group", typeof(BandCategory))!;
        IsUsableChat = info.GetUInt32("_isUsableChat");
        IsUsableMulti = info.GetUInt32("_isUsableMulti");
        Filename = info.GetString("_filename")!;
        Order = info.GetUInt32("_order");
        InitialStamp = info.GetUInt32("_initialStamp");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_name", Name);
        info.AddValue("_group", Group);
        info.AddValue("_isUsableChat", IsUsableChat);
        info.AddValue("_isUsableMulti", IsUsableMulti);
        info.AddValue("_filename", Filename);
        info.AddValue("_order", Order);
        info.AddValue("_initialStamp", InitialStamp);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
