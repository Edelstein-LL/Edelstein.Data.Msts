using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class AlbumUnitSeriesMMst : ISerializable
{
    [Key]
    public uint AlbumUnitSeriesId { get; init; }

    public uint AlbumSeriesId { get; init; }
    public uint UnitId { get; init; }
    public uint Position { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public AlbumUnitSeriesMMst() { }

    protected AlbumUnitSeriesMMst(SerializationInfo info, StreamingContext context)
    {
        AlbumUnitSeriesId = info.GetUInt32("_albumUnitSeriesId");
        AlbumSeriesId = info.GetUInt32("_albumSeriesId");
        UnitId = info.GetUInt32("_unitId");
        Position = info.GetUInt32("_position");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_albumUnitSeriesId", AlbumUnitSeriesId);
        info.AddValue("_albumSeriesId", AlbumSeriesId);
        info.AddValue("_unitId", UnitId);
        info.AddValue("_position", Position);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
