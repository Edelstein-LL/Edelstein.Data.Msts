using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class VoiceKeyMst : ISerializable
{
    [Key]
    public required string Key { get; init; }

    public uint MasterVoiceId { get; init; }
    public uint MasterVoiceNum { get; init; }
    public uint MasterReleaseLabelId { get; init; }

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
