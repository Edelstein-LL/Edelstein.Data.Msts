using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class NavigationDialogPageMst : IGameMst, ISerializable
{
    public required string MasterNavigationId { get; set; }
    public required string SpriteName { get; set; }
    public required string Message { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
