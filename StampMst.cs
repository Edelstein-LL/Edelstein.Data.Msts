using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class StampMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string Name { get; init; }
    public BandCategory BandCategory { get; init; }
    public uint IsRare { get; init; }
    public required string SpriteName { get; init; }
    public int Priority { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public StampMst() { }

    protected StampMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Name = info.GetString("_name")!;
        BandCategory = (BandCategory)info.GetValue("_bandCategory", typeof(BandCategory))!;
        IsRare = info.GetUInt32("_isRare");
        SpriteName = info.GetString("_spriteName")!;
        Priority = info.GetInt32("_priority");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_name", Name);
        info.AddValue("_bandCategory", BandCategory);
        info.AddValue("_isRare", IsRare);
        info.AddValue("_spriteName", SpriteName);
        info.AddValue("_priority", Priority);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
