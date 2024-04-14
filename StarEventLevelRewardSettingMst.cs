using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(Id), nameof(Level))]
public class StarEventLevelRewardSettingMst : ISerializable
{
    public uint Id { get; init; }
    public uint Level { get; init; }
    public uint IsLoop { get; init; }
    public uint StarId { get; init; }
    public uint MasterStarEventLevelRewardId { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public StarEventLevelRewardSettingMst() { }

    protected StarEventLevelRewardSettingMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Level = info.GetUInt32("_level");
        IsLoop = info.GetUInt32("_isLoop");
        StarId = info.GetUInt32("_starId");
        MasterStarEventLevelRewardId = info.GetUInt32("_masterStarEventLevelRewardId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_level", Level);
        info.AddValue("_isLoop", IsLoop);
        info.AddValue("_starId", StarId);
        info.AddValue("_masterStarEventLevelRewardId", MasterStarEventLevelRewardId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
