using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LiveComboMst : ISerializable
{
    [Key]
    public int ComboNum { get; set; }

    public float ScoreUpRate { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public LiveComboMst() { }

    protected LiveComboMst(SerializationInfo info, StreamingContext context)
    {
        ComboNum = info.GetInt32("_comboNum");
        ScoreUpRate = info.GetSingle("_scoreUpRate");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_comboNum", ComboNum);
        info.AddValue("_scoreUpRate", ScoreUpRate);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
