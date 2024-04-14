using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ChatChapterMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public uint MasterChatId { get; init; }
    public uint RoomId { get; init; }
    public uint ChapterId { get; init; }
    public required string ScriptKey { get; init; }
    public required string Title { get; init; }
    public required string FirstLineValue { get; init; }
    public required string NoticeValue { get; init; }
    public required string AppearStampIdList { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public ChatChapterMst() { }

    protected ChatChapterMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        MasterChatId = info.GetUInt32("_masterChatId");
        RoomId = info.GetUInt32("_roomId");
        ChapterId = info.GetUInt32("_chapterId");
        ScriptKey = info.GetString("_scriptKey")!;
        Title = info.GetString("_title")!;
        FirstLineValue = info.GetString("_firstLineValue")!;
        NoticeValue = info.GetString("_noticeValue")!;
        AppearStampIdList = info.GetString("_appearStampIdList")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_masterChatId", MasterChatId);
        info.AddValue("_roomId", RoomId);
        info.AddValue("_chapterId", ChapterId);
        info.AddValue("_scriptKey", ScriptKey);
        info.AddValue("_title", Title);
        info.AddValue("_firstLineValue", FirstLineValue);
        info.AddValue("_noticeValue", NoticeValue);
        info.AddValue("_appearStampIdList", AppearStampIdList);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
