using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class MultiPenaltyMst : ISerializable
{
    [Key]
    public byte Id { get; set; } // TODO: Dummy

    public MultiPenaltyMst() { }

    protected MultiPenaltyMst(SerializationInfo info, StreamingContext context)
    {
        // TODO: Schema unknown, isn't used
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context) { }
}
