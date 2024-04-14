using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ChatVoiceKeyMst : ISerializable
{
    [Key]
    public required string Key { get; init; }

    public uint Num { get; init; }
    public uint Group { get; init; }
    public required string Comment { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public ChatVoiceKeyMst() { }

    protected ChatVoiceKeyMst(SerializationInfo info, StreamingContext context)
    {
        Key = info.GetString("_key")!;
        Num = info.GetUInt32("_num");
        Group = info.GetUInt32("_group");
        Comment = info.GetString("_comment")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_key", Key);
        info.AddValue("_num", Num);
        info.AddValue("_group", Group);
        info.AddValue("_comment", Comment);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
