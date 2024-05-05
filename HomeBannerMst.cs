using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class HomeBannerMst : ISerializable
{
    [Key]
    public uint Id { get; set; }

    public HomeBannerType Type { get; set; }
    public required string Value { get; set; }
    public int DeviceType { get; set; }
    public required string SpriteName { get; set; }
    public int Position { get; set; }
    public int Priority { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public HomeBannerMst() { }

    protected HomeBannerMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Type = (HomeBannerType)info.GetValue("_type", typeof(HomeBannerType))!;
        Value = info.GetString("_value")!;
        DeviceType = info.GetInt32("_deviceType");
        SpriteName = info.GetString("_spriteName")!;
        Position = info.GetInt32("_position");
        Priority = info.GetInt32("_priority");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_type", Type);
        info.AddValue("_value", Value);
        info.AddValue("_deviceType", DeviceType);
        info.AddValue("_spriteName", SpriteName);
        info.AddValue("_position", Position);
        info.AddValue("_priority", Priority);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
