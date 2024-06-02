using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class AlbumSeriesThumbnailAssetMMst : IGameMst, ISerializable
{
    public uint AlbumSeriesId { get; set; }

    public required string ThumbnailAsset { get; set; }
    public uint ThumbnailAssetEn { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public AlbumSeriesThumbnailAssetMMst() { }

    protected AlbumSeriesThumbnailAssetMMst(SerializationInfo info, StreamingContext context)
    {
        AlbumSeriesId = info.GetUInt32("_albumSeriesId");
        ThumbnailAsset = info.GetString("_thumbnailAsset")!;
        ThumbnailAssetEn = info.GetUInt32("_thumbnailAssetEn");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_albumSeriesId", AlbumSeriesId);
        info.AddValue("_thumbnailAsset", ThumbnailAsset);
        info.AddValue("_thumbnailAssetEn", ThumbnailAssetEn);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
