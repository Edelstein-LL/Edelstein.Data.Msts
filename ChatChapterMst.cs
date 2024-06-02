using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ChatChapterMst : IGameMst, ISerializable
{
    public uint Id { get; set; }

    public uint MasterChatId { get; set; }
    public uint RoomId { get; set; }
    public uint ChapterId { get; set; }
    public required string ScriptKey { get; set; }
    public required string Title { get; set; }
    public required string FirstLineValue { get; set; }
    public required string NoticeValue { get; set; }
    public required string AppearStampIdList { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
