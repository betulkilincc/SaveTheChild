using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public GameSettingsSO gameSettings;

    public void SetEasyDifficulty()
    {
        gameSettings.difficulty = GameSettingsSO.Difficulty.Easy;
    }
    public void SetMediumDifficulty()
    {
        gameSettings.difficulty = GameSettingsSO.Difficulty.Medium;
    }
    public void SetHardDifficulty()
    {
        gameSettings.difficulty = GameSettingsSO.Difficulty.Hard;
    }
}
