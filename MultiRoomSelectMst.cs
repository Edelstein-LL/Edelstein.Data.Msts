using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class MultiRoomSelectMst : IGameMst, ISerializable
{
    public uint Id { get; set; }

    public required string Name { get; set; }
    public required string Detail { get; set; }
    public uint Opened { get; set; }
    public uint Status { get; set; }
    public uint MasterMultiRoomConditionId { get; set; }
    public int MinRoomId { get; set; }
    public int MaxRoomId { get; set; }
    public uint MasterReleaseLabelId { get; set; }
    public LiveMode LiveMode { get; set; }

    public MultiRoomSelectMst() { }

    protected MultiRoomSelectMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Name = info.GetString("_name")!;
        Detail = info.GetString("_detail")!;
        Opened = info.GetUInt32("_opened");
        Status = info.GetUInt32("_status");
        MasterMultiRoomConditionId = info.GetUInt32("_masterMultiRoomConditionId");
        MinRoomId = info.GetInt32("_minRoomId");
        MaxRoomId = info.GetInt32("_maxRoomId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
        LiveMode = (LiveMode)info.GetValue("_liveMode", typeof(LiveMode))!;
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_name", Name);
        info.AddValue("_detail", Detail);
        info.AddValue("_opened", Opened);
        info.AddValue("_status", Status);
        info.AddValue("_masterMultiRoomConditionId", MasterMultiRoomConditionId);
        info.AddValue("_minRoomId", MinRoomId);
        info.AddValue("_maxRoomId", MaxRoomId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
        info.AddValue("_liveMode", LiveMode);
    }
}
