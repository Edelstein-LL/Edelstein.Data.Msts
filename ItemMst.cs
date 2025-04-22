using System.Globalization;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ItemMst : IGameMst, ISerializable
{
    private const string DateTimeFormat = "yyyy/MM/dd H:mm:ss";

    public uint Id { get; set; }

    public required string Name { get; set; }
    public ItemCategory Category { get; set; }
    public ItemEffectType EffectType { get; set; }
    public uint EffectConditionValue { get; set; }
    public int EffectValue { get; set; }
    public int ExtraEffectValue { get; set; }
    public required string EffectDetail { get; set; }
    public required string WayToUse { get; set; }
    public required string WayToGet { get; set; }
    public int Price { get; set; }
    public required string SpriteName { get; set; }
    public ItemTab ItemTab { get; set; }
    public int Priority { get; set; }
    public DateTimeOffset? ExpiryDate { get; set; }
    public ItemExpireType ItemExpireType { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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

        string? expiryDate = info.GetString("_expireDate");
        ExpiryDate = !String.IsNullOrEmpty(expiryDate)
            ? DateTimeOffset.ParseExact(expiryDate, DateTimeFormat, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal)
            : null;

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

        info.AddValue("_expireDate", ExpiryDate?.ToString(DateTimeFormat));

        info.AddValue("_itemExpireType", ItemExpireType);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
