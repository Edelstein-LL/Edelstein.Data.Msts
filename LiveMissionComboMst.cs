using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LiveMissionComboMst : IGameMst, ISerializable
{
    [Key]
    public uint MasterMusicId { get; set; }

    public uint[] ValueList { get; set; } = [];
    public uint MasterReleaseLabelId { get; set; }

    public LiveMissionComboMst() { }

    protected LiveMissionComboMst(SerializationInfo info, StreamingContext context)
    {
        MasterMusicId = info.GetUInt32("_masterMusicId");
        ValueList = (uint[])info.GetValue("_valueList", typeof(uint[]))!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterMusicId", MasterMusicId);
        info.AddValue("_valueList", ValueList);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
