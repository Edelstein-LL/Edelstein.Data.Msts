using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class NoticeCardMst : IGameMst, ISerializable
{
    public uint Id { get; set; }

    public int Number { get; set; }
    public uint CardId { get; set; }
    public required string IntroductionText { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public NoticeCardMst() { }

    protected NoticeCardMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Number = info.GetInt32("_number");
        CardId = info.GetUInt32("_cardId");
        IntroductionText = info.GetString("_introductionText")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_number", Number);
        info.AddValue("_cardId", CardId);
        info.AddValue("_introductionText", IntroductionText);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
