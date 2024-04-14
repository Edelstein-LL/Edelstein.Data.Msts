using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class DialogButtonMst : ISerializable
{
    [Key]
    public required string Id { get; init; }

    public required string SpriteName { get; init; }
    public required string MasterTextId { get; init; }
    public required string MasterTextIdColor { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public DialogButtonMst() { }

    protected DialogButtonMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetString("_id")!;
        SpriteName = info.GetString("_spriteName")!;
        MasterTextId = info.GetString("_masterTextId")!;
        MasterTextIdColor = info.GetString("_masterTextIdColor")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_spriteName", SpriteName);
        info.AddValue("_masterTextId", MasterTextId);
        info.AddValue("_masterTextIdColor", MasterTextIdColor);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
