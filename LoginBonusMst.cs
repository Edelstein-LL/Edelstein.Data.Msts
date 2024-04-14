using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LoginBonusMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string Name { get; init; }
    public LoginBonusType Type { get; init; }
    public uint MasterEventId { get; init; }
    public uint Loop { get; init; }
    public int Priority { get; init; }
    public required string PrefabName { get; init; }
    public required string BoardSpriteName { get; init; }
    public uint MasterVoiceId { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public LoginBonusMst() { }

    protected LoginBonusMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Name = info.GetString("_name")!;
        Type = (LoginBonusType)info.GetValue("_type", typeof(LoginBonusType))!;
        MasterEventId = info.GetUInt32("_masterEventId");
        Loop = info.GetUInt32("_loop");
        Priority = info.GetInt32("_priority");
        PrefabName = info.GetString("_prefabName")!;
        BoardSpriteName = info.GetString("_boardSpriteName")!;
        MasterVoiceId = info.GetUInt32("_masterVoiceId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_name", Name);
        info.AddValue("_type", Type);
        info.AddValue("_masterEventId", MasterEventId);
        info.AddValue("_loop", Loop);
        info.AddValue("_priority", Priority);
        info.AddValue("_prefabName", PrefabName);
        info.AddValue("_boardSpriteName", BoardSpriteName);
        info.AddValue("_masterVoiceId", MasterVoiceId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
