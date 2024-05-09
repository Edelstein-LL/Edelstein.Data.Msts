using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class BillingShopMst : IGameMst, ISerializable
{
    [Key]
    public uint Id { get; set; }

    public required string TabName { get; set; }
    public required string Name { get; set; }
    public int Priority { get; set; }
    public int ShopType { get; set; }
    public required string SpriteName { get; set; }
    public uint MasterShopRewardId { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
