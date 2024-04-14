using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(Id), nameof(MasterVoiceId))]
public class CardSysVoiceMst : ISerializable
{
    public uint Id { get; init; }
    public uint Num { get; init; }
    public uint MasterVoiceId { get; init; }
    public SystemVoiceType SystemVoiceType { get; init; }
    public uint Value { get; init; }
    public required string TextJa { get; init; }
    public required string TextEn { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public CardSysVoiceMst() { }

    protected CardSysVoiceMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Num = info.GetUInt32("_num");
        MasterVoiceId = info.GetUInt32("_masterVoiceId");
        SystemVoiceType = (SystemVoiceType)info.GetValue("_systemVoiceType", typeof(SystemVoiceType))!;
        Value = info.GetUInt32("_value");
        TextJa = info.GetString("_textJa")!;
        TextEn = info.GetString("_textEn")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_num", Num);
        info.AddValue("_masterVoiceId", MasterVoiceId);
        info.AddValue("_systemVoiceType", SystemVoiceType);
        info.AddValue("_value", Value);
        info.AddValue("_textJa", TextJa);
        info.AddValue("_textEn", TextEn);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
