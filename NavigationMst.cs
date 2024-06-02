using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class NavigationMst : IGameMst, ISerializable
{
    public required string Id { get; set; }

    public uint MasterScenarioId { get; set; }
    public required string DialogTitle { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public NavigationMst() { }

    protected NavigationMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetString("_id")!;
        MasterScenarioId = info.GetUInt32("_masterScenarioId");
        DialogTitle = info.GetString("_dialogTitle")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_masterScenarioId", MasterScenarioId);
        info.AddValue("_dialogTitle", DialogTitle);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
