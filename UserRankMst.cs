using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[Index(nameof(Exp))]
public class UserRankMst : IGameMst, ISerializable
{
    [Key]
    public int Rank { get; set; }

    public int Exp { get; set; }
    public uint MasterUserRankRewardId { get; set; }
    public uint MaxFriend { get; set; }
    public int MaxLp { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public UserRankMst() { }

    protected UserRankMst(SerializationInfo info, StreamingContext context)
    {
        Rank = info.GetInt32("_rank");
        Exp = info.GetInt32("_exp");
        MasterUserRankRewardId = info.GetUInt32("_masterUserRankRewardId");
        MaxFriend = info.GetUInt32("_maxFriend");
        MaxLp = info.GetInt32("_maxLp");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_rank", Rank);
        info.AddValue("_exp", Exp);
        info.AddValue("_masterUserRankRewardId", MasterUserRankRewardId);
        info.AddValue("_maxFriend", MaxFriend);
        info.AddValue("_maxLp", MaxLp);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
