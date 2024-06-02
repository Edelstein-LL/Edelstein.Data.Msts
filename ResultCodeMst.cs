using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ResultCodeMst : IGameMst, ISerializable
{
    public ResultCode ResultCode { get; set; }

    public required string MasterDialogId { get; set; }
    public uint ResetFlag { get; set; }
    public uint SilentFlag { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public ResultCodeMst() { }

    protected ResultCodeMst(SerializationInfo info, StreamingContext context)
    {
        ResultCode = (ResultCode)info.GetValue("_resultCode", typeof(ResultCode))!;
        MasterDialogId = info.GetString("_masterDialogId")!;
        ResetFlag = info.GetUInt32("_resetFlag");
        SilentFlag = info.GetUInt32("_silentFlag");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_resultCode", ResultCode);
        info.AddValue("_masterDialogId", MasterDialogId);
        info.AddValue("_resetFlag", ResetFlag);
        info.AddValue("_silentFlag", SilentFlag);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
