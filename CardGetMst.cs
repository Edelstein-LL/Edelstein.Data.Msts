using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class CardGetMst : ISerializable
{
    [Key]
    public uint MasterCardId { get; init; }

    public int Index { get; init; }
    public GetCategory GetCategory { get; init; }
    public uint Value { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public CardGetMst() { }

    protected CardGetMst(SerializationInfo info, StreamingContext context)
    {
        MasterCardId = info.GetUInt32("_masterCardId");
        Index = info.GetInt32("_index");
        GetCategory = (GetCategory)info.GetValue("_getCategory", typeof(GetCategory))!;
        Value = info.GetUInt32("_value");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterCardId", MasterCardId);
        info.AddValue("_index", Index);
        info.AddValue("_getCategory", GetCategory);
        info.AddValue("_value", Value);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
