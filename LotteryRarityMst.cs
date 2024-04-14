using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(Id), nameof(Number))]
[Index(nameof(Id))]
public class LotteryRarityMst : ISerializable
{
    public uint Id { get; init; }
    public uint Number { get; init; }
    public uint MasterLotteryItemId { get; init; }
    public Rarity Rarity { get; init; }
    public int Ratio { get; init; }
    public int PickupRatio { get; init; }
    public uint Ensured { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public LotteryRarityMst() { }

    protected LotteryRarityMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Number = info.GetUInt32("_number");
        MasterLotteryItemId = info.GetUInt32("_masterLotteryItemId");
        Rarity = (Rarity)info.GetValue("_rarity", typeof(Rarity))!;
        Ratio = info.GetInt32("_ratio");
        PickupRatio = info.GetInt32("_pickupRatio");
        Ensured = info.GetUInt32("_ensured");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_number", Number);
        info.AddValue("_masterLotteryItemId", MasterLotteryItemId);
        info.AddValue("_rarity", Rarity);
        info.AddValue("_ratio", Ratio);
        info.AddValue("_pickupRatio", PickupRatio);
        info.AddValue("_ensured", Ensured);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
