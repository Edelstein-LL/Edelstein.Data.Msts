using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class NoticeMusicImageMst : IGameMst, ISerializable
{
    public uint Id { get; set; }

    public required string StartLoadingImageName1 { get; set; }
    public required string StartLoadingImageName2 { get; set; }
    public required string StartLoadingImageName3 { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public NoticeMusicImageMst() { }

    protected NoticeMusicImageMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        StartLoadingImageName1 = info.GetString("_startLoadingImageName1")!;
        StartLoadingImageName2 = info.GetString("_startLoadingImageName2")!;
        StartLoadingImageName3 = info.GetString("_startLoadingImageName3")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_startLoadingImageName1", StartLoadingImageName1);
        info.AddValue("_startLoadingImageName2", StartLoadingImageName2);
        info.AddValue("_startLoadingImageName3", StartLoadingImageName3);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
