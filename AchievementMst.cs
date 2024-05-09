using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
public class AchievementMst : IGameMst, ISerializable
{
    [Key]
    public required string Id { get; set; }

    public required string AchievementIdAndroid { get; set; }
    public required string AchievementIdIos { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public AchievementMst() { }

    protected AchievementMst(SerializationInfo info, StreamingContext context)
    {
        Id = info.GetString("_id")!;
        AchievementIdAndroid = info.GetString("_achievementIdAndroid")!;
        AchievementIdIos = info.GetString("_achievementIdIos")!;
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_id", Id);
        info.AddValue("_achievementIdAndroid", AchievementIdAndroid);
        info.AddValue("_achievementIdIos", AchievementIdIos);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
