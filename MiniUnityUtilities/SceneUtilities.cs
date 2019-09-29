/**
 * MiniUnityUtilities
 * Copyright (c) Simon Raichl 2019
 * MIT License
 */

using UnityEngine.SceneManagement;

public static class SceneUtilities
{
    public static string GetCurrentSceneName()
    {
        return SceneManager.GetActiveScene().name;
    }

    public static void RestartCurrentScene()
    {
        SceneManager.LoadScene(GetCurrentSceneName());
    }
}
