using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class AlbumUnitTypeMemberTagMMst : IGameMst, ISerializable
{
    public uint UnitTypeId { get; set; }
    public uint MemberTagId { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
