using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class SubscriptionImageMst : IGameMst, ISerializable
{
    public uint Id { get; set; }

    public required string MasterBillingProductId { get; set; }
    public required string SubscriptionImageName { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public SubscriptionImageMst() { }

    protected SubscriptionImageMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        MasterBillingProductId = info.GetString("_masterBillingProductId")!;
        SubscriptionImageName = info.GetString("_subscriptionImageName")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_masterBillingProductId", MasterBillingProductId);
        info.AddValue("_subscriptionImageName", SubscriptionImageName);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
