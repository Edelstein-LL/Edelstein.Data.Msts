using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LotteryEffMovieRatioMst : ISerializable
{
    [Key]
    public uint Id { get; init; }

    public Rarity MinRarity { get; init; }
    public uint NormalMovieRatio { get; init; }
    public uint ExpectedMoveRatio { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public LotteryEffMovieRatioMst() { }

    protected LotteryEffMovieRatioMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        MinRarity = (Rarity)info.GetValue("_minRarity", typeof(Rarity))!;
        NormalMovieRatio = info.GetUInt32("_normalMovieRatio");
        ExpectedMoveRatio = info.GetUInt32("_expectedMoveRatio");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_minRarity", MinRarity);
        info.AddValue("_normalMovieRatio", NormalMovieRatio);
        info.AddValue("_expectedMoveRatio", ExpectedMoveRatio);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
