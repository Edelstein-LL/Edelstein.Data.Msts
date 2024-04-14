using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class NavigationConditionMst : ISerializable
{
    [Key]
    public required string MasterNavigationId { get; init; }

    public NavigationConditionType ConditionType { get; init; }
    public uint ConditionValue { get; init; }
    public int ConditionNumber { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public NavigationConditionMst() { }

    protected NavigationConditionMst(SerializationInfo info, StreamingContext context)
    {
        MasterNavigationId = info.GetString("_masterNavigationId")!;
        ConditionType = (NavigationConditionType)info.GetValue("_conditionType", typeof(NavigationConditionType))!;
        ConditionValue = info.GetUInt32("_conditionValue");
        ConditionNumber = info.GetInt32("_conditionNumber");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterNavigationId", MasterNavigationId);
        info.AddValue("_conditionType", ConditionType);
        info.AddValue("_conditionValue", ConditionValue);
        info.AddValue("_conditionNumber", ConditionNumber);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
