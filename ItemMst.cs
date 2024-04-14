using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ItemMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string Name { get; init; }
    public ItemCategory Category { get; init; }
    public ItemEffectType EffectType { get; init; }
    public uint EffectConditionValue { get; init; }
    public int EffectValue { get; init; }
    public int ExtraEffectValue { get; init; }
    public required string EffectDetail { get; init; }
    public required string WayToUse { get; init; }
    public required string WayToGet { get; init; }
    public int Price { get; init; }
    public required string SpriteName { get; init; }
    public ItemTab ItemTab { get; init; }
    public int Priority { get; init; }
    public required string ExpireDate { get; init; }
    public ItemExpireType ItemExpireType { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public ItemMst() { }

    protected ItemMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Name = info.GetString("_name")!;
        Category = (ItemCategory)info.GetValue("_category", typeof(ItemCategory))!;
        EffectType = (ItemEffectType)info.GetValue("_effectType", typeof(ItemEffectType))!;
        EffectConditionValue = info.GetUInt32("_effectConditionValue");
        EffectValue = info.GetInt32("_effectValue");
        ExtraEffectValue = info.GetInt32("_extraEffectValue");
        EffectDetail = info.GetString("_effectDetail")!;
        WayToUse = info.GetString("_wayToUse")!;
        WayToGet = info.GetString("_wayToGet")!;
        Price = info.GetInt32("_price");
        SpriteName = info.GetString("_spriteName")!;
        ItemTab = (ItemTab)info.GetValue("_itemTab", typeof(ItemTab))!;
        Priority = info.GetInt32("_priority");
        ExpireDate = info.GetString("_expireDate")!;
        ItemExpireType = (ItemExpireType)info.GetValue("_itemExpireType", typeof(ItemExpireType))!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_name", Name);
        info.AddValue("_category", Category);
        info.AddValue("_effectType", EffectType);
        info.AddValue("_effectConditionValue", EffectConditionValue);
        info.AddValue("_effectValue", EffectValue);
        info.AddValue("_extraEffectValue", ExtraEffectValue);
        info.AddValue("_effectDetail", EffectDetail);
        info.AddValue("_wayToUse", WayToUse);
        info.AddValue("_wayToGet", WayToGet);
        info.AddValue("_price", Price);
        info.AddValue("_spriteName", SpriteName);
        info.AddValue("_itemTab", ItemTab);
        info.AddValue("_priority", Priority);
        info.AddValue("_expireDate", ExpireDate);
        info.AddValue("_itemExpireType", ItemExpireType);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
