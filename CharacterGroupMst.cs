using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(CharacterId), nameof(GroupId))]
public class CharacterGroupMst : ISerializable
{
    public uint CharacterId { get; init; }
    public uint GroupId { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public CharacterGroupMst() { }

    protected CharacterGroupMst(SerializationInfo info, StreamingContext context)
    {
        CharacterId = info.GetUInt32("_characterId");
        GroupId = info.GetUInt32("_groupId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_characterId", CharacterId);
        info.AddValue("_groupId", GroupId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
