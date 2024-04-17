using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LiveMissionComboMst : ISerializable
{
    [Key]
    public uint MasterMusicId { get; init; }

    public uint[] ValueList { get; init; } = [];
    public uint MasterReleaseLabelId { get; init; }

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
