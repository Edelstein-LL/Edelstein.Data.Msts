using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ChatCharacterMst : IGameMst, ISerializable
{
    [Key]
    public uint Id { get; set; }

    public uint CharacterId { get; set; }
    public uint Group { get; set; }
    public required string Name { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public ChatCharacterMst() { }

    protected ChatCharacterMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        CharacterId = info.GetUInt32("_characterId");
        Group = info.GetUInt32("_group");
        Name = info.GetString("_name")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_characterId", CharacterId);
        info.AddValue("_group", Group);
        info.AddValue("_name", Name);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
