using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class BillingSubscriptionMst : IGameMst, ISerializable
{
    public required string MasterBillingProductId { get; set; }

    public required string Label { get; set; }
    public uint DeviceType { get; set; }
    public required string Name { get; set; }
    public required string Title { get; set; }
    public required string Summary { get; set; }
    public SubscriptionType SubscriptionType { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
