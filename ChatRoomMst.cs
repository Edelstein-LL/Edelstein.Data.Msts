using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ChatRoomMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public uint MasterChatId { get; init; }
    public uint RoomId { get; init; }
    public required string HashTag { get; init; }
    public required string FirstLineValue { get; init; }
    public required string IconPath { get; init; }
    public required string AppearCharaIdList { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public ChatRoomMst() { }

    protected ChatRoomMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        MasterChatId = info.GetUInt32("_masterChatId");
        RoomId = info.GetUInt32("_roomId");
        HashTag = info.GetString("_hashTag")!;
        FirstLineValue = info.GetString("_firstLineValue")!;
        IconPath = info.GetString("_iconPath")!;
        AppearCharaIdList = info.GetString("_appearCharaIdList")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_masterChatId", MasterChatId);
        info.AddValue("_roomId", RoomId);
        info.AddValue("_hashTag", HashTag);
        info.AddValue("_firstLineValue", FirstLineValue);
        info.AddValue("_iconPath", IconPath);
        info.AddValue("_appearCharaIdList", AppearCharaIdList);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
