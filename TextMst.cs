using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class TextMst : IGameMst, ISerializable
{
    public required string Id { get; set; }

    public required string TextJa { get; set; }
    public required string TextEn { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public TextMst() { }

    protected TextMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetString("_id")!;
        TextJa = info.GetString("_textJa")!;
        TextEn = info.GetString("_textEn")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_textJa", TextJa);
        info.AddValue("_textEn", TextEn);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
