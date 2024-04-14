using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class SceneTitleMst : ISerializable
{
    [Key]
    public required string Id { get; init; }

    public required string MainTitle { get; init; }
    public required string MainMasterNavigationId { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public SceneTitleMst() { }

    protected SceneTitleMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetString("_id")!;
        MainTitle = info.GetString("_mainTitle")!;
        MainMasterNavigationId = info.GetString("_mainMasterNavigationId")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_mainTitle", MainTitle);
        info.AddValue("_mainMasterNavigationId", MainMasterNavigationId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}