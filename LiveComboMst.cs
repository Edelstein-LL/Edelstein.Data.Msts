using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LiveComboMst : ISerializable
{
    [Key]
    public int ComboNum { get; init; }

    public float ScoreUpRate { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public LiveComboMst() { }

    protected LiveComboMst(SerializationInfo info, StreamingContext context)
    {
        ComboNum = info.GetInt32("_comboNum");
        ScoreUpRate = (float)info.GetValue("_scoreUpRate", typeof(float))!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_comboNum", ComboNum);
        info.AddValue("_scoreUpRate", ScoreUpRate);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
