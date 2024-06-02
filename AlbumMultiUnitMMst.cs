using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class AlbumMultiUnitMMst : IGameMst, ISerializable
{
    public uint MultiUnitId { get; set; }
    public uint UnitId { get; set; }
    public uint UnitNumber { get; set; }
    public required string Eponym { get; set; }
    public required string Name { get; set; }
    public required string MultiCardName { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
