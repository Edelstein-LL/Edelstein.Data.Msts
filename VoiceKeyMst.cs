using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class VoiceKeyMst : IGameMst, ISerializable
{
    public required string Key { get; set; }

    public uint MasterVoiceId { get; set; }
    public uint MasterVoiceNum { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public VoiceKeyMst() { }

    protected VoiceKeyMst(SerializationInfo info, StreamingContext context)
    {
        Key = info.GetString("_key")!;
        MasterVoiceId = info.GetUInt32("_masterVoiceId");
        MasterVoiceNum = info.GetUInt32("_masterVoiceNum");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_key", Key);
        info.AddValue("_masterVoiceId", MasterVoiceId);
        info.AddValue("_masterVoiceNum", MasterVoiceNum);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
