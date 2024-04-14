using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LiveTapSeMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public uint TapPerfectSoundId { get; init; }
    public uint TapGrateSoundId { get; init; }
    public uint TapGoodSoundId { get; init; }
    public uint TapBadSoundId { get; init; }
    public uint TapMissSoundId { get; init; }
    public uint FlickSoundId { get; init; }
    public uint TapLongSoundId { get; init; }
    public uint TapEmptySoundId { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public LiveTapSeMst() { }

    protected LiveTapSeMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        TapPerfectSoundId = info.GetUInt32("_tapPerfectSoundId");
        TapGrateSoundId = info.GetUInt32("_tapGrateSoundId");
        TapGoodSoundId = info.GetUInt32("_tapGoodSoundId");
        TapBadSoundId = info.GetUInt32("_tapBadSoundId");
        TapMissSoundId = info.GetUInt32("_tapMissSoundId");
        FlickSoundId = info.GetUInt32("_flickSoundId");
        TapLongSoundId = info.GetUInt32("_tapLongSoundId");
        TapEmptySoundId = info.GetUInt32("_tapEmptySoundId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_tapPerfectSoundId", TapPerfectSoundId);
        info.AddValue("_tapGrateSoundId", TapGrateSoundId);
        info.AddValue("_tapGoodSoundId", TapGoodSoundId);
        info.AddValue("_tapBadSoundId", TapBadSoundId);
        info.AddValue("_tapMissSoundId", TapMissSoundId);
        info.AddValue("_flickSoundId", FlickSoundId);
        info.AddValue("_tapLongSoundId", TapLongSoundId);
        info.AddValue("_tapEmptySoundId", TapEmptySoundId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
