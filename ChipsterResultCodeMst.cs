using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ChipsterResultCodeMst : IGameMst, ISerializable
{
    public int ResultCode { get; set; }

    public required string MasterDialogId { get; set; }
    public uint StayFlag { get; set; }
    public uint SilentFlag { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public ChipsterResultCodeMst() { }

    protected ChipsterResultCodeMst(SerializationInfo info, StreamingContext context)
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
