using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(Id), nameof(Level))]
public class StarEventLevelRewardSettingMst : IGameMst, ISerializable
{
    public uint Id { get; set; }
    public uint Level { get; set; }
    public uint IsLoop { get; set; }
    public uint StarId { get; set; }
    public uint MasterStarEventLevelRewardId { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
