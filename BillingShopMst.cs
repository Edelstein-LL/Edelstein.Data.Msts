using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class BillingShopMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public required string TabName { get; init; }
    public required string Name { get; init; }
    public int Priority { get; init; }
    public int ShopType { get; init; }
    public required string SpriteName { get; init; }
    public uint MasterShopRewardId { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public BillingShopMst() { }

    protected BillingShopMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        TabName = info.GetString("_tabName")!;
        Name = info.GetString("_name")!;
        Priority = info.GetInt32("_priority");
        ShopType = info.GetInt32("_shopType");
        SpriteName = info.GetString("_spriteName")!;
        MasterShopRewardId = info.GetUInt32("_masterShopRewardId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_tabName", TabName);
        info.AddValue("_name", Name);
        info.AddValue("_priority", Priority);
        info.AddValue("_shopType", ShopType);
        info.AddValue("_spriteName", SpriteName);
        info.AddValue("_masterShopRewardId", MasterShopRewardId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
