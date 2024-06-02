using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class NoticeGachaMst : IGameMst, ISerializable
{
    public uint Id { get; set; }

    public required string SpriteName { get; set; }
    public required string TextSpriteName { get; set; }
    public required string EfTextSpriteName { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public NoticeGachaMst() { }

    protected NoticeGachaMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        SpriteName = info.GetString("_spriteName")!;
        TextSpriteName = info.GetString("_textSpriteName")!;
        EfTextSpriteName = info.GetString("_efTextSpriteName")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_spriteName", SpriteName);
        info.AddValue("_textSpriteName", TextSpriteName);
        info.AddValue("_efTextSpriteName", EfTextSpriteName);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
