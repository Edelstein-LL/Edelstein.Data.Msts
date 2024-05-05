using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(Id), nameof(Number))]
[Index(nameof(Id))]
[Index(nameof(MasterLotteryItemId))]
public class LotteryRarityMst : ISerializable
{
    public uint Id { get; set; }
    public uint Number { get; set; }
    public uint MasterLotteryItemId { get; set; }
    public Rarity Rarity { get; set; }
    public int Ratio { get; set; }
    public int PickupRatio { get; set; }
    public uint Ensured { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
