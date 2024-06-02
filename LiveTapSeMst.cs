using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LiveTapSeMst : IGameMst, ISerializable
{
    public uint Id { get; set; }

    public uint TapPerfectSoundId { get; set; }
    public uint TapGrateSoundId { get; set; }
    public uint TapGoodSoundId { get; set; }
    public uint TapBadSoundId { get; set; }
    public uint TapMissSoundId { get; set; }
    public uint FlickSoundId { get; set; }
    public uint TapLongSoundId { get; set; }
    public uint TapEmptySoundId { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
