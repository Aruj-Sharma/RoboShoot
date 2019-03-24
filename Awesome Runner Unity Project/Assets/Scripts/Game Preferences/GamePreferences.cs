using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GamePreferences
{
    public static string Highscore = "Highscore";

    public static void SetHighscore(int score)
    {
        PlayerPrefs.SetInt(GamePreferences.Highscore, score);
    }

    public static int GetHighscore()
    {
        return PlayerPrefs.GetInt(GamePreferences.Highscore);
    }

    public static string IsMusicOn = "IsMusicOn";

    public static void SetIsMusicOn(int state)
    {
        PlayerPrefs.SetInt(GamePreferences.IsMusicOn, state);
    }

    public static int GetIsMusicOn()
    {
        return PlayerPrefs.GetInt(GamePreferences.IsMusicOn);
    }
}
