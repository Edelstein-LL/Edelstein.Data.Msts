using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class CardEvolveMst : ISerializable
{
    [Key]
    public Rarity Rarity { get; init; }

    public int EvolveCount { get; init; }
    public int MaxLevel { get; init; }
    public int Price { get; init; }
    public int HpAddValue { get; init; }
    public uint MasterReleaseLabelId { get; init; }

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
