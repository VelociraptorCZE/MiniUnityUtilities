/**
 * MiniUnityUtilities
 * Copyright (c) Simon Raichl 2019
 * MIT License
 */

using UnityEngine;

public static class PlayerPrefsUtilities
{
    public static void AddUpInt(string key, int deltaValue)
    {
        PlayerPrefs.SetInt(key, PlayerPrefs.GetInt(key) + deltaValue);
    }

    public static void AddUpFloat(string key, float deltaValue)
    {
        PlayerPrefs.SetFloat(key, PlayerPrefs.GetFloat(key) + deltaValue);
    }
}
