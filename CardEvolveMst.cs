using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(Rarity), nameof(EvolveCount))]
public class CardEvolveMst : IGameMst, ISerializable
{
    public Rarity Rarity { get; set; }
    public int EvolveCount { get; set; }
    public int MaxLevel { get; set; }
    public int Price { get; set; }
    public int HpAddValue { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public CardEvolveMst() { }

    protected CardEvolveMst(SerializationInfo info, StreamingContext context)
    {
        Rarity = (Rarity)info.GetValue("_rarity", typeof(Rarity))!;
        EvolveCount = info.GetInt32("_evolveCount");
        MaxLevel = info.GetInt32("_maxLevel");
        Price = info.GetInt32("_price");
        HpAddValue = info.GetInt32("_hpAddValue");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_rarity", Rarity);
        info.AddValue("_evolveCount", EvolveCount);
        info.AddValue("_maxLevel", MaxLevel);
        info.AddValue("_price", Price);
        info.AddValue("_hpAddValue", HpAddValue);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
