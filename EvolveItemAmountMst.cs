using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class EvolveItemAmountMst : ISerializable
{
    [Key]
    public Rarity Rarity { get; init; }

    public int EvolveCount { get; init; }
    public ItemEffectType EffectType { get; init; }
    public int Amount { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public EvolveItemAmountMst() { }

    protected EvolveItemAmountMst(SerializationInfo info, StreamingContext context)
    {
        Rarity = (Rarity)info.GetValue("_rarity", typeof(Rarity))!;
        EvolveCount = info.GetInt32("_evolveCount");
        EffectType = (ItemEffectType)info.GetValue("_effectType", typeof(ItemEffectType))!;
        Amount = info.GetInt32("_amount");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_rarity", Rarity);
        info.AddValue("_evolveCount", EvolveCount);
        info.AddValue("_effectType", EffectType);
        info.AddValue("_amount", Amount);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
