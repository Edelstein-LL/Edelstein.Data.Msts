using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LoginBonusMst : IGameMst, ISerializable
{
    public uint Id { get; set; }

    public required string Name { get; set; }
    public LoginBonusType Type { get; set; }
    public uint MasterEventId { get; set; }
    public uint Loop { get; set; }
    public int Priority { get; set; }
    public required string PrefabName { get; set; }
    public required string BoardSpriteName { get; set; }
    public uint MasterVoiceId { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
