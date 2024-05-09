using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class TitleMst : IGameMst, ISerializable
{
    [Key]
    public uint Id { get; set; }

    public required string Name { get; set; }
    public TitleCategory Category { get; set; }
    public required string DetailText { get; set; }
    public int Priority { get; set; }
    public required string SpriteName { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public TitleMst() { }

    protected TitleMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Name = info.GetString("_name")!;
        Category = (TitleCategory)info.GetValue("_category", typeof(TitleCategory))!;
        DetailText = info.GetString("_detailText")!;
        Priority = info.GetInt32("_priority");
        SpriteName = info.GetString("_spriteName")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_name", Name);
        info.AddValue("_category", Category);
        info.AddValue("_detailText", DetailText);
        info.AddValue("_priority", Priority);
        info.AddValue("_spriteName", SpriteName);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
