using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(MasterBillingSubscriptionLabel), nameof(Number))]
public class BillingSubscriptionRewardMst : ISerializable
{
    public required string MasterBillingSubscriptionLabel { get; set; }
    public uint Number { get; set; }
    public SubscriptionRewardType SubscriptionRewardType { get; set; }
    public uint Value { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public BillingSubscriptionRewardMst() { }

    protected BillingSubscriptionRewardMst(SerializationInfo info, StreamingContext context)
    {
        MasterBillingSubscriptionLabel = info.GetString("_masterBillingSubscriptionLabel")!;
        Number = info.GetUInt32("_number");
        SubscriptionRewardType = (SubscriptionRewardType)info.GetValue("_subscriptionRewardType", typeof(SubscriptionRewardType))!;
        Value = info.GetUInt32("_value");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterBillingSubscriptionLabel", MasterBillingSubscriptionLabel);
        info.AddValue("_number", Number);
        info.AddValue("_subscriptionRewardType", SubscriptionRewardType);
        info.AddValue("_value", Value);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
