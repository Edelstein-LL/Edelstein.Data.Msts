using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LiveBoostMst : ISerializable
{
    [Key]
    public int Value { get; set; }

    public int Lp { get; set; }
    public int Icon { get; set; }
    public int EventPointRatio { get; set; }
    public int RewardRatio { get; set; }
    public int ExpRatio { get; set; }
    public int EventPointRatioAuto { get; set; }
    public int RewardRatioAuto { get; set; }
    public int ExpRatioAuto { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public LiveBoostMst() { }

    protected LiveBoostMst(SerializationInfo info, StreamingContext context)
    {
        Value = info.GetInt32("_value");
        Lp = info.GetInt32("_lp");
        Icon = info.GetInt32("_icon");
        EventPointRatio = info.GetInt32("_eventPointRatio");
        RewardRatio = info.GetInt32("_rewardRatio");
        ExpRatio = info.GetInt32("_expRatio");
        EventPointRatioAuto = info.GetInt32("_eventPointRatioAuto");
        RewardRatioAuto = info.GetInt32("_rewardRatioAuto");
        ExpRatioAuto = info.GetInt32("_expRatioAuto");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_value", Value);
        info.AddValue("_lp", Lp);
        info.AddValue("_icon", Icon);
        info.AddValue("_eventPointRatio", EventPointRatio);
        info.AddValue("_rewardRatio", RewardRatio);
        info.AddValue("_expRatio", ExpRatio);
        info.AddValue("_eventPointRatioAuto", EventPointRatioAuto);
        info.AddValue("_rewardRatioAuto", RewardRatioAuto);
        info.AddValue("_expRatioAuto", ExpRatioAuto);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
