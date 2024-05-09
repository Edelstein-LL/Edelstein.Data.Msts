using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class LotteryEffMovieRatioMst : IGameMst, ISerializable
{
    [Key]
    public uint Id { get; set; }

    public Rarity MinRarity { get; set; }
    public uint NormalMovieRatio { get; set; }
    public uint ExpectedMoveRatio { get; set; }
    public uint MasterReleaseLabelId { get; set; }

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
