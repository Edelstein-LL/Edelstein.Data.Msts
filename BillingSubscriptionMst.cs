using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class BillingSubscriptionMst : ISerializable
{
    [Key]
    public required string MasterBillingProductId { get; init; }

    public required string Label { get; init; }
    public uint DeviceType { get; init; }
    public required string Name { get; init; }
    public required string Title { get; init; }
    public required string Summary { get; init; }
    public SubscriptionType SubscriptionType { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public BillingSubscriptionMst() { }

    protected BillingSubscriptionMst(SerializationInfo info, StreamingContext context)
    {
        MasterBillingProductId = info.GetString("_masterBillingProductId")!;
        Label = info.GetString("_label")!;
        DeviceType = info.GetUInt32("_deviceType");
        Name = info.GetString("_name")!;
        Title = info.GetString("_title")!;
        Summary = info.GetString("_summary")!;
        SubscriptionType = (SubscriptionType)info.GetValue("_subscriptionType", typeof(SubscriptionType))!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterBillingProductId", MasterBillingProductId);
        info.AddValue("_label", Label);
        info.AddValue("_deviceType", DeviceType);
        info.AddValue("_name", Name);
        info.AddValue("_title", Title);
        info.AddValue("_summary", Summary);
        info.AddValue("_subscriptionType", SubscriptionType);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
