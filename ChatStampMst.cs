using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ChatStampMst : IGameMst, ISerializable
{
    [Key]
    public uint Id { get; set; }

    public required string Name { get; set; }
    public BandCategory Group { get; set; }
    public uint IsUsableChat { get; set; }
    public uint IsUsableMulti { get; set; }
    public required string Filename { get; set; }
    public uint Order { get; set; }
    public uint InitialStamp { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
