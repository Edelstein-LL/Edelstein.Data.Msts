using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class ExchangeMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public ExchangeType ExchangeType { get; init; }
    public ConsumeType ConsumeType { get; init; }
    public uint Value { get; init; }
    public required string BannerSpriteName { get; init; }
    public required string Name { get; init; }
    public ExchangeTab ExchangeTab { get; init; }
    public int Priority { get; init; }
    public uint DisplayControlFlag { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public ExchangeMst() { }

    protected ExchangeMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        ExchangeType = (ExchangeType)info.GetValue("_exchangeType", typeof(ExchangeType))!;
        ConsumeType = (ConsumeType)info.GetValue("_consumeType", typeof(ConsumeType))!;
        Value = info.GetUInt32("_value");
        BannerSpriteName = info.GetString("_bannerSpriteName")!;
        Name = info.GetString("_name")!;
        ExchangeTab = (ExchangeTab)info.GetValue("_exchangeTab", typeof(ExchangeTab))!;
        Priority = info.GetInt32("_priority");
        DisplayControlFlag = info.GetUInt32("_displayControlFlag");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_exchangeType", ExchangeType);
        info.AddValue("_consumeType", ConsumeType);
        info.AddValue("_value", Value);
        info.AddValue("_bannerSpriteName", BannerSpriteName);
        info.AddValue("_name", Name);
        info.AddValue("_exchangeTab", ExchangeTab);
        info.AddValue("_priority", Priority);
        info.AddValue("_displayControlFlag", DisplayControlFlag);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
