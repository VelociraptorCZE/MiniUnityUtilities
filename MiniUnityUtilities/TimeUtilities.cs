/**
 * MiniUnityUtilities
 * Copyright (c) Simon Raichl 2019 - 2020
 * MIT License
 */

using UnityEngine;

public static class TimeUtilities
{
    public static void FreezeTime()
    {
        Time.timeScale = 0;
    }

    public static void UnfreezeTime()
    {
        Time.timeScale = 1;
    }

    public static bool IsTimeFrozen()
    {
        return Time.timeScale == 0;
    }
}
