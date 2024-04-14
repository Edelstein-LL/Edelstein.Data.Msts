using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(Id), nameof(BandCategory))]
public class LotteryEffMovieMst : ISerializable
{
    public uint Id { get; init; }
    public BandCategory BandCategory { get; init; }
    public uint NormalMovieId { get; init; }
    public uint ExpectedMoveId { get; init; }
    public uint MasterReleaseLabelId { get; init; }

    public LotteryEffMovieMst() { }

    protected LotteryEffMovieMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetUInt32("_id");
        BandCategory = (BandCategory)info.GetValue("_bandCategory", typeof(BandCategory))!;
        NormalMovieId = info.GetUInt32("_normalMovieId");
        ExpectedMoveId = info.GetUInt32("_expectedMoveId");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_bandCategory", BandCategory);
        info.AddValue("_normalMovieId", NormalMovieId);
        info.AddValue("_expectedMoveId", ExpectedMoveId);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
