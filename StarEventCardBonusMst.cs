using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(MasterEventId), nameof(TargetId))]
public class StarEventCardBonusMst : ISerializable
{
    public uint MasterEventId { get; set; }
    public uint TargetId { get; set; }
    public int[] PointBonusRatioList { get; set; } = [];
    public int[] EventBonusAmountList { get; set; } = [];
    public uint MasterReleaseLabelId { get; set; }

    public StarEventCardBonusMst() { }

    protected StarEventCardBonusMst(SerializationInfo info, StreamingContext context)
    {
        MasterEventId = info.GetUInt32("_masterEventId");
        TargetId = info.GetUInt32("_targetId");
        PointBonusRatioList = (int[])info.GetValue("_pointBonusRatioList", typeof(int[]))!;
        EventBonusAmountList = (int[])info.GetValue("_eventBonusAmountList", typeof(int[]))!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterEventId", MasterEventId);
        info.AddValue("_targetId", TargetId);
        info.AddValue("_pointBonusRatioList", PointBonusRatioList);
        info.AddValue("_eventBonusAmountList", EventBonusAmountList);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
