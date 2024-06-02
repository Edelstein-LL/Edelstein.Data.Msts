using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class CommonBgMovieMst : IGameMst, ISerializable
{
    public uint Id { get; set; }

    public uint MasterMovieId { get; set; }
    public BandCategory BandCategory { get; set; }
    public required string SceneType { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
