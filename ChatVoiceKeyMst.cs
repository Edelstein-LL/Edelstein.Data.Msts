using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ChatVoiceKeyMst : IGameMst, ISerializable
{
    public required string Key { get; set; }

    public uint Num { get; set; }
    public uint Group { get; set; }
    public required string Comment { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
