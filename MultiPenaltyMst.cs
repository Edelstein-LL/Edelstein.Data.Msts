using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class MultiPenaltyMst : IGameMst, ISerializable
{
    public byte Id { get; set; } // TODO: Dummy

    public uint MasterReleaseLabelId { get; set; }

    public MultiPenaltyMst() { }

    protected MultiPenaltyMst(SerializationInfo info, StreamingContext context)
    {
        // TODO: Schema unknown, isn't used
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context) { }
}
