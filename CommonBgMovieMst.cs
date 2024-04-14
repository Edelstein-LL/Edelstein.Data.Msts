using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class CommonBgMovieMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public uint MasterMovieId { get; init; }
    public BandCategory BandCategory { get; init; }
    public required string SceneType { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public CommonBgMovieMst() { }

    protected CommonBgMovieMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        MasterMovieId = info.GetUInt32("_masterMovieId");
        BandCategory = (BandCategory)info.GetValue("_bandCategory", typeof(BandCategory))!;
        SceneType = info.GetString("_sceneType")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_masterMovieId", MasterMovieId);
        info.AddValue("_bandCategory", BandCategory);
        info.AddValue("_sceneType", SceneType);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
