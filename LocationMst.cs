using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LocationMst : IGameMst, ISerializable
{
    [Key]
    public uint Id { get; set; }

    public required string Name { get; set; }
    public required string Description { get; set; }
    public uint MasterLocationRewardId { get; set; }
    public required string BannerName { get; set; }
    public int Priority { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
