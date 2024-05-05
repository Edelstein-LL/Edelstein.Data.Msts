using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(MasterMusicId), nameof(Level))]
[Index(nameof(MasterMusicId))]
public class MusicLevelMst : ISerializable
{
    public uint MasterMusicId { get; set; }
    public LiveLevel Level { get; set; }
    public int LevelNumber { get; set; }
    public required string NoteDataFileName { get; set; }
    public int FullCombo { get; set; }
    public int BeforeClimaxNotesCount { get; set; }
    public float ScoreCoeff { get; set; }
    public float ClimaxScoreCoeff { get; set; }
    public float VoltageIncreaseCoeff { get; set; }
    public float VoltageDecreaseCoeff { get; set; }
    public uint MasterReleaseLabelId { get; set; }

    public MusicLevelMst() { }

    protected MusicLevelMst(SerializationInfo info, StreamingContext context)
    {
        MasterMusicId = info.GetUInt32("_masterMusicId");
        Level = (LiveLevel)info.GetValue("_level", typeof(LiveLevel))!;
        LevelNumber = info.GetInt32("_levelNumber");
        NoteDataFileName = info.GetString("_noteDataFileName")!;
        FullCombo = info.GetInt32("_fullCombo");
        BeforeClimaxNotesCount = info.GetInt32("_beforeClimaxNotesCount");
        ScoreCoeff = info.GetSingle("_scoreCoeff");
        ClimaxScoreCoeff = info.GetSingle("_climaxScoreCoeff");
        VoltageIncreaseCoeff = info.GetSingle("_voltageIncreaseCoeff");
        VoltageDecreaseCoeff = info.GetSingle("_voltageDecreaseCoeff");
        MasterReleaseLabelId = info.GetUInt32("_masterReleaseLabelId");
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue("_masterMusicId", MasterMusicId);
        info.AddValue("_level", Level);
        info.AddValue("_levelNumber", LevelNumber);
        info.AddValue("_noteDataFileName", NoteDataFileName);
        info.AddValue("_fullCombo", FullCombo);
        info.AddValue("_beforeClimaxNotesCount", BeforeClimaxNotesCount);
        info.AddValue("_scoreCoeff", ScoreCoeff);
        info.AddValue("_climaxScoreCoeff", ClimaxScoreCoeff);
        info.AddValue("_voltageIncreaseCoeff", VoltageIncreaseCoeff);
        info.AddValue("_voltageDecreaseCoeff", VoltageDecreaseCoeff);
        info.AddValue("_masterReleaseLabelId", MasterReleaseLabelId);
    }
}
