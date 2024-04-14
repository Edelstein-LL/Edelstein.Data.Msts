using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class AlbumUnitPairMMst : ISerializable
{
    [Key]
    public uint UnitPairId { get; init; }

    public uint Pair { get; init; }
    public uint UnitId { get; init; }
    public uint Position { get; init; }
    public uint Rank { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public AlbumUnitPairMMst() { }

    protected AlbumUnitPairMMst(SerializationInfo info, StreamingContext context)
    {
        UnitPairId = info.GetUInt32("_unitPairId");
        Pair = info.GetUInt32("_pair");
        UnitId = info.GetUInt32("_unitId");
        Position = info.GetUInt32("_position");
        Rank = info.GetUInt32("_rank");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_unitPairId", UnitPairId);
        info.AddValue("_pair", Pair);
        info.AddValue("_unitId", UnitId);
        info.AddValue("_position", Position);
        info.AddValue("_rank", Rank);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
