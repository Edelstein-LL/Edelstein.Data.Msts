using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class HomeBgMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string ImageName { get; init; }
    public uint MasterMovieId { get; init; }
    public HomeBgType HomeBgType { get; init; }
    public int Priority { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public HomeBgMst() { }

    protected HomeBgMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        ImageName = info.GetString("_imageName")!;
        MasterMovieId = info.GetUInt32("_masterMovieId");
        HomeBgType = (HomeBgType)info.GetValue("_homeBgType", typeof(HomeBgType))!;
        Priority = info.GetInt32("_priority");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_imageName", ImageName);
        info.AddValue("_masterMovieId", MasterMovieId);
        info.AddValue("_homeBgType", HomeBgType);
        info.AddValue("_priority", Priority);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
