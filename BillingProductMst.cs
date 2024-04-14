using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class BillingProductMst : ISerializable
{
    [Key]
    public required string Id { get; init; }

    public uint MasterBillingShopId { get; init; }
    public required string ItemName { get; init; }
    public required string ItemDetail { get; init; }
    public BillingProductType Type { get; init; }
    public required string Detail { get; init; }
    public uint MasterBillingProductRewardId { get; init; }
    public uint StartdashTime { get; init; }
    public uint StartdashExpireTime { get; init; }
    public int Priority { get; init; }
    public required string SpriteName { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public BillingProductMst() { }

    protected BillingProductMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetString("_id")!;
        MasterBillingShopId = info.GetUInt32("_masterBillingShopId");
        ItemName = info.GetString("_itemName")!;
        ItemDetail = info.GetString("_itemDetail")!;
        Type = (BillingProductType)info.GetValue("_type", typeof(BillingProductType))!;
        Detail = info.GetString("_detail")!;
        MasterBillingProductRewardId = info.GetUInt32("_masterBillingProductRewardId");
        StartdashTime = info.GetUInt32("_startdashTime");
        StartdashExpireTime = info.GetUInt32("_startdashExpireTime");
        Priority = info.GetInt32("_priority");
        SpriteName = info.GetString("_spriteName")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_masterBillingShopId", MasterBillingShopId);
        info.AddValue("_itemName", ItemName);
        info.AddValue("_itemDetail", ItemDetail);
        info.AddValue("_type", Type);
        info.AddValue("_detail", Detail);
        info.AddValue("_masterBillingProductRewardId", MasterBillingProductRewardId);
        info.AddValue("_startdashTime", StartdashTime);
        info.AddValue("_startdashExpireTime", StartdashExpireTime);
        info.AddValue("_priority", Priority);
        info.AddValue("_spriteName", SpriteName);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
