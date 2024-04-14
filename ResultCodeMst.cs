using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ResultCodeMst : ISerializable
{
    [Key]
    public ResultCode ResultCode { get; init; }

    public required string MasterDialogId { get; init; }
    public uint ResetFlag { get; init; }
    public uint SilentFlag { get; init; }
    public uint MasterReleaseLabelId { get; init; }

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