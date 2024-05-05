using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class AlbumUnitTypeMst : ISerializable
{
    [Key]
    public uint UnitTypeId { get; set; }

    public required string Name { get; set; }
    public required string NameAlpha { get; set; }
    public required string Age { get; set; }
    public required string Birthday { get; set; }
    public required string BloodType { get; set; }
    public required string Height { get; set; }
    public required string Cv { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public AlbumUnitTypeMst() { }

    protected AlbumUnitTypeMst(SerializationInfo info, StreamingContext context)
    {
        UnitTypeId = info.GetUInt32("_unitTypeId");
        Name = info.GetString("_name")!;
        NameAlpha = info.GetString("_nameAlpha")!;
        Age = info.GetString("_age")!;
        Birthday = info.GetString("_birthday")!;
        BloodType = info.GetString("_bloodType")!;
        Height = info.GetString("_height")!;
        Cv = info.GetString("_cv")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_unitTypeId", UnitTypeId);
        info.AddValue("_name", Name);
        info.AddValue("_nameAlpha", NameAlpha);
        info.AddValue("_age", Age);
        info.AddValue("_birthday", Birthday);
        info.AddValue("_bloodType", BloodType);
        info.AddValue("_height", Height);
        info.AddValue("_cv", Cv);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
