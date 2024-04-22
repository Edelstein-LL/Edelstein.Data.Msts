using Microsoft.EntityFrameworkCore;

using System.Runtime.Serialization;

namespace Edelstein.Data.Msts;

[Serializable]
[PrimaryKey(nameof(MasterMusicId), nameof(Level))]
[Index(nameof(MasterMusicId))]
public class MusicLevelMst : ISerializable
{
    public uint MasterMusicId { get; init; }
    public LiveLevel Level { get; init; }
    public int LevelNumber { get; init; }
    public required string NoteDataFileName { get; init; }
    public int FullCombo { get; init; }
    public int BeforeClimaxNotesCount { get; init; }
    public float ScoreCoeff { get; init; }
    public float ClimaxScoreCoeff { get; init; }
    public float VoltageIncreaseCoeff { get; init; }
    public float VoltageDecreaseCoeff { get; init; }
    public uint MasterReleaseLabelId { get; init; }

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
