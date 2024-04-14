using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(UnitTypeId), nameof(MemberTagId))]
public class AlbumUnitTypeMemberTagMMst : ISerializable
{
    public uint UnitTypeId { get; init; }
    public uint MemberTagId { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public AlbumUnitTypeMemberTagMMst() { }

    protected AlbumUnitTypeMemberTagMMst(SerializationInfo info, StreamingContext context)
    {
        UnitTypeId = info.GetUInt32("_unitTypeId");
        MemberTagId = info.GetUInt32("_memberTagId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_unitTypeId", UnitTypeId);
        info.AddValue("_memberTagId", MemberTagId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
