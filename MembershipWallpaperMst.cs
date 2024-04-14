using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class MembershipWallpaperMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public uint Priorily { get; init; }
    public MembershipWallpaperConditionType MembershipWallpaperConditionType { get; init; }
    public uint Value { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public MembershipWallpaperMst() { }

    protected MembershipWallpaperMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Priorily = info.GetUInt32("_priorily");
        MembershipWallpaperConditionType =
            (MembershipWallpaperConditionType)info.GetValue("_membershipWallpaperConditionType",
                typeof(MembershipWallpaperConditionType))!;
        Value = info.GetUInt32("_value");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_priorily", Priorily);
        info.AddValue("_membershipWallpaperConditionType", MembershipWallpaperConditionType);
        info.AddValue("_value", Value);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
