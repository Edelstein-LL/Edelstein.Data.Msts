using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LocationMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string Name { get; init; }
    public required string Description { get; init; }
    public uint MasterLocationRewardId { get; init; }
    public required string BannerName { get; init; }
    public int Priority { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public LocationMst() { }

    protected LocationMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Name = info.GetString("_name")!;
        Description = info.GetString("_description")!;
        MasterLocationRewardId = info.GetUInt32("_masterLocationRewardId");
        BannerName = info.GetString("_bannerName")!;
        Priority = info.GetInt32("_priority");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_name", Name);
        info.AddValue("_description", Description);
        info.AddValue("_masterLocationRewardId", MasterLocationRewardId);
        info.AddValue("_bannerName", BannerName);
        info.AddValue("_priority", Priority);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
