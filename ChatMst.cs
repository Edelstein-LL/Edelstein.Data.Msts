using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ChatMst : IGameMst, ISerializable
{
    public uint Id { get; set; }

    public required string Title { get; set; }
    public uint Type { get; set; }
    public BandCategory Category { get; set; }
    public uint ChatCharaId { get; set; }
    public required string BgColorCode { get; set; }
    public required string HeaderColorCode { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
