using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LiveTapEffectMst : ISerializable
{
    [Key]
    public uint Id { get; set; }

    public required string TapPath { get; set; }
    public required string FlickPath { get; set; }
    public required string LongPath { get; set; }
    public required string LongLoopPath { get; set; }
    public required string SkillPath { get; set; }
    public required string EmptyPath { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public LiveTapEffectMst() { }

    protected LiveTapEffectMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        TapPath = info.GetString("_tapPath")!;
        FlickPath = info.GetString("_flickPath")!;
        LongPath = info.GetString("_longPath")!;
        LongLoopPath = info.GetString("_longLoopPath")!;
        SkillPath = info.GetString("_skillPath")!;
        EmptyPath = info.GetString("_emptyPath")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_tapPath", TapPath);
        info.AddValue("_flickPath", FlickPath);
        info.AddValue("_longPath", LongPath);
        info.AddValue("_longLoopPath", LongLoopPath);
        info.AddValue("_skillPath", SkillPath);
        info.AddValue("_emptyPath", EmptyPath);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
