using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class FunctionLockMst : ISerializable
{
    [Key]
    public required string Id { get; init; }

    public int Locked { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public FunctionLockMst() { }

    protected FunctionLockMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetString("_id")!;
        Locked = info.GetInt32("_locked");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_locked", Locked);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
