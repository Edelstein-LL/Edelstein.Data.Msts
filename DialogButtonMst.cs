using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class DialogButtonMst : IGameMst, ISerializable
{
    public required string Id { get; set; }

    public required string SpriteName { get; set; }
    public required string MasterTextId { get; set; }
    public required string MasterTextIdColor { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
