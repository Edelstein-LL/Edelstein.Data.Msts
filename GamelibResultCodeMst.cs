using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class GamelibResultCodeMst : ISerializable
{
    [Key]
    public int ResultCode { get; init; }

    public required string MasterDialogId { get; init; }
    public uint StayFlag { get; init; }
    public uint SilentFlag { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public GamelibResultCodeMst() { }

    protected GamelibResultCodeMst(SerializationInfo info, StreamingContext context)
    {
        ResultCode = info.GetInt32("_resultCode");
        MasterDialogId = info.GetString("_masterDialogId")!;
        StayFlag = info.GetUInt32("_stayFlag");
        SilentFlag = info.GetUInt32("_silentFlag");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_resultCode", ResultCode);
        info.AddValue("_masterDialogId", MasterDialogId);
        info.AddValue("_stayFlag", StayFlag);
        info.AddValue("_silentFlag", SilentFlag);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
