using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(MultiUnitId), nameof(UnitId))]
public class AlbumMultiUnitMMst : ISerializable
{
    public uint MultiUnitId { get; init; }
    public uint UnitId { get; init; }
    public uint UnitNumber { get; init; }
    public required string Eponym { get; init; }
    public required string Name { get; init; }
    public required string MultiCardName { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public AlbumMultiUnitMMst() { }

    protected AlbumMultiUnitMMst(SerializationInfo info, StreamingContext context)
    {
        MultiUnitId = info.GetUInt32("_multiUnitId");
        UnitId = info.GetUInt32("_unitId");
        UnitNumber = info.GetUInt32("_unitNumber");
        Eponym = info.GetString("_eponym")!;
        Name = info.GetString("_name")!;
        MultiCardName = info.GetString("_multiCardName")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_multiUnitId", MultiUnitId);
        info.AddValue("_unitId", UnitId);
        info.AddValue("_unitNumber", UnitNumber);
        info.AddValue("_eponym", Eponym);
        info.AddValue("_name", Name);
        info.AddValue("_multiCardName", MultiCardName);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
