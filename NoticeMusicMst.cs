using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class NoticeMusicMst : ISerializable
{
    [Key]
    public uint Id { get; set; }

    public int Number { get; set; }
    public uint MasterMusicId { get; set; }
    public required string StopLoadingImageName { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public NoticeMusicMst() { }

    protected NoticeMusicMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Number = info.GetInt32("_number");
        MasterMusicId = info.GetUInt32("_masterMusicId");
        StopLoadingImageName = info.GetString("_stopLoadingImageName")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_number", Number);
        info.AddValue("_masterMusicId", MasterMusicId);
        info.AddValue("_stopLoadingImageName", StopLoadingImageName);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
