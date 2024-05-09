using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class UrlMst : IGameMst, ISerializable
{
    [Key]
    public required string Id { get; set; }

    public required string Url { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public UrlMst() { }

    protected UrlMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetString("_id")!;
        Url = info.GetString("_url")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_url", Url);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
