using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class AlbumMemberTagMMst : ISerializable
{
    [Key]
    public uint MemberTagId { get; init; }

    public required string Name { get; init; }
    public required string ImgAsset { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public AlbumMemberTagMMst() { }

    protected AlbumMemberTagMMst(SerializationInfo info, StreamingContext context)
    {
        MemberTagId = info.GetUInt32("_memberTagId");
        Name = info.GetString("_name")!;
        ImgAsset = info.GetString("_imgAsset")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_memberTagId", MemberTagId);
        info.AddValue("_name", Name);
        info.AddValue("_imgAsset", ImgAsset);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}