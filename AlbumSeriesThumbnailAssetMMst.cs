using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class AlbumSeriesThumbnailAssetMMst : ISerializable
{
    [Key]
    public uint AlbumSeriesId { get; init; }

    public required string ThumbnailAsset { get; init; }
    public uint ThumbnailAssetEn { get; init; }
    public uint MasterReleaseLabelId { get; init; }

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
