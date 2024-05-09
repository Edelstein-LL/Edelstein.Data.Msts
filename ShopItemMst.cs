using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ShopItemMst : IGameMst, ISerializable
{
    [Key]
    public uint Id { get; set; }

    public required string Name { get; set; }
    public uint MasterBillingShopId { get; set; }
    public ConsumeType ConsumeType { get; set; }
    public uint Price { get; set; }
    public uint MasterShopRewardId { get; set; }
    public uint BuyLimit { get; set; }
    public uint StartdashTime { get; set; }
    public uint StartdashExpireTime { get; set; }
    public int Priority { get; set; }
    public required string SpriteName { get; set; }
    public TimeResetType TimeResetType { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
