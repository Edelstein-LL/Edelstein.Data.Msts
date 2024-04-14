using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ChatMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string Title { get; init; }
    public uint Type { get; init; }
    public BandCategory Category { get; init; }
    public uint ChatCharaId { get; init; }
    public required string BgColorCode { get; init; }
    public required string HeaderColorCode { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public ChatMst() { }

    protected ChatMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Title = info.GetString("_title")!;
        Type = info.GetUInt32("_type");
        Category = (BandCategory)info.GetValue("_category", typeof(BandCategory))!;
        ChatCharaId = info.GetUInt32("_chatCharaId");
        BgColorCode = info.GetString("_bgColorCode")!;
        HeaderColorCode = info.GetString("_headerColorCode")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_title", Title);
        info.AddValue("_type", Type);
        info.AddValue("_category", Category);
        info.AddValue("_chatCharaId", ChatCharaId);
        info.AddValue("_bgColorCode", BgColorCode);
        info.AddValue("_headerColorCode", HeaderColorCode);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
