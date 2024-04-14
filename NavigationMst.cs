using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class NavigationMst : ISerializable
{
    [Key]
    public required string Id { get; init; }

    public uint MasterScenarioId { get; init; }
    public required string DialogTitle { get; init; }
    public uint MasterReleaseLabelId { get; init; }

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
