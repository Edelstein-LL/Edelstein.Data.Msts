using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(MasterLiveRecommendId), nameof(Number))]
public class LiveRecommendListMst : ISerializable
{
    public uint MasterLiveRecommendId { get; init; }
    public uint Number { get; init; }
    public uint MasterLiveId { get; init; }
    public uint MasterReleaseLabelId { get; init; }

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
