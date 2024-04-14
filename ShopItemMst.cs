using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ShopItemMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string Name { get; init; }
    public uint MasterBillingShopId { get; init; }
    public ConsumeType ConsumeType { get; init; }
    public uint Price { get; init; }
    public uint MasterShopRewardId { get; init; }
    public uint BuyLimit { get; init; }
    public uint StartdashTime { get; init; }
    public uint StartdashExpireTime { get; init; }
    public int Priority { get; init; }
    public required string SpriteName { get; init; }
    public TimeResetType TimeResetType { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public ShopItemMst() { }

    protected ShopItemMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        Name = info.GetString("_name")!;
        MasterBillingShopId = info.GetUInt32("_masterBillingShopId");
        ConsumeType = (ConsumeType)info.GetValue("_consumeType", typeof(ConsumeType))!;
        Price = info.GetUInt32("_price");
        MasterShopRewardId = info.GetUInt32("_masterShopRewardId");
        BuyLimit = info.GetUInt32("_buyLimit");
        StartdashTime = info.GetUInt32("_startdashTime");
        StartdashExpireTime = info.GetUInt32("_startdashExpireTime");
        Priority = info.GetInt32("_priority");
        SpriteName = info.GetString("_spriteName")!;
        TimeResetType = (TimeResetType)info.GetValue("_timeResetType", typeof(TimeResetType))!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_name", Name);
        info.AddValue("_masterBillingShopId", MasterBillingShopId);
        info.AddValue("_consumeType", ConsumeType);
        info.AddValue("_price", Price);
        info.AddValue("_masterShopRewardId", MasterShopRewardId);
        info.AddValue("_buyLimit", BuyLimit);
        info.AddValue("_startdashTime", StartdashTime);
        info.AddValue("_startdashExpireTime", StartdashExpireTime);
        info.AddValue("_priority", Priority);
        info.AddValue("_spriteName", SpriteName);
        info.AddValue("_timeResetType", TimeResetType);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
