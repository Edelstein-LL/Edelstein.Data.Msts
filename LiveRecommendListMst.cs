using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LiveRecommendListMst : IGameMst, ISerializable
{
    public uint MasterLiveRecommendId { get; set; }
    public uint Number { get; set; }
    public uint MasterLiveId { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public LiveRecommendListMst() { }

    protected LiveRecommendListMst(SerializationInfo info, StreamingContext context)
    {
        MasterLiveRecommendId = info.GetUInt32("_masterLiveRecommendId");
        Number = info.GetUInt32("_number");
        MasterLiveId = info.GetUInt32("_masterLiveId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterLiveRecommendId", MasterLiveRecommendId);
        info.AddValue("_number", Number);
        info.AddValue("_masterLiveId", MasterLiveId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
