using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class DialogMst : ISerializable
{
    [Key]
    public required string Id { get; set; }

    public required string Title { get; set; }
    public required string Message { get; set; }
    public string[] ButtonId { get; set; } = [];
    public uint MasterReleaseLabelId { get; set; }

    public DialogMst() { }

    protected DialogMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetString("_id")!;
        Title = info.GetString("_title")!;
        Message = info.GetString("_message")!;
        ButtonId = (string[])info.GetValue("_buttonId", typeof(string[]))!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_title", Title);
        info.AddValue("_message", Message);
        info.AddValue("_buttonId", ButtonId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
