using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class EvolveItemConditionMst : IGameMst, ISerializable
{
    public uint MasterItemId { get; set; }

    public uint Number { get; set; }
    public EvolveItemConditionType Type { get; set; }
    public uint[] ValueList { get; set; } = [];
    public uint MasterReleaseLabelId { get; set; }

    public EvolveItemConditionMst() { }

    protected EvolveItemConditionMst(SerializationInfo info, StreamingContext context)
    {
        MasterItemId = info.GetUInt32("_masterItemId");
        Number = info.GetUInt32("_number");
        Type = (EvolveItemConditionType)info.GetValue("_type", typeof(EvolveItemConditionType))!;
        ValueList = (uint[])info.GetValue("_valueList", typeof(uint[]))!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterItemId", MasterItemId);
        info.AddValue("_number", Number);
        info.AddValue("_type", Type);
        info.AddValue("_valueList", ValueList);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
