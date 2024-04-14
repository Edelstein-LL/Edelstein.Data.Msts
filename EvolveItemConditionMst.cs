using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class EvolveItemConditionMst : ISerializable
{
    [Key]
    public uint MasterItemId { get; init; }

    public uint Number { get; init; }
    public EvolveItemConditionType Type { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public EvolveItemConditionMst() { }

    protected EvolveItemConditionMst(SerializationInfo info, StreamingContext context)
    {
        MasterItemId = info.GetUInt32("_masterItemId");
        Number = info.GetUInt32("_number");
        Type = (EvolveItemConditionType)info.GetValue("_type", typeof(EvolveItemConditionType))!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterItemId", MasterItemId);
        info.AddValue("_number", Number);
        info.AddValue("_type", Type);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
