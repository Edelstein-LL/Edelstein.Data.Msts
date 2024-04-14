using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class SoundKeyMst : ISerializable
{
    [Key]
    public required string Key { get; init; }

    public SoundType SoundType { get; init; }
    public uint MasterSoundId { get; init; }
    public uint MasterSoundNum { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public SoundKeyMst() { }

    protected SoundKeyMst(SerializationInfo info, StreamingContext context)
    {
        Key = info.GetString("_key")!;
        SoundType = (SoundType)info.GetValue("_soundType", typeof(SoundType))!;
        MasterSoundId = info.GetUInt32("_masterSoundId");
        MasterSoundNum = info.GetUInt32("_masterSoundNum");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_key", Key);
        info.AddValue("_soundType", SoundType);
        info.AddValue("_masterSoundId", MasterSoundId);
        info.AddValue("_masterSoundNum", MasterSoundNum);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
