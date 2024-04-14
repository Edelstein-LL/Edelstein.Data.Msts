using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class MissionBannerMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public MissionType Type { get; init; }
    public required string BannerFileName { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public MissionBannerMst() { }

    protected MissionBannerMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Type = (MissionType)info.GetValue("_type", typeof(MissionType))!;
        BannerFileName = info.GetString("_bannerFileName")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_type", Type);
        info.AddValue("_bannerFileName", BannerFileName);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
