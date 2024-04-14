using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(MasterNavigationId), nameof(SpriteName))]
public class NavigationDialogPageMst : ISerializable
{
    public required string MasterNavigationId { get; init; }
    public required string SpriteName { get; init; }
    public required string Message { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public NavigationDialogPageMst() { }

    protected NavigationDialogPageMst(SerializationInfo info, StreamingContext context)
    {
        MasterNavigationId = info.GetString("_masterNavigationId")!;
        SpriteName = info.GetString("_spriteName")!;
        Message = info.GetString("_message")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterNavigationId", MasterNavigationId);
        info.AddValue("_spriteName", SpriteName);
        info.AddValue("_message", Message);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
