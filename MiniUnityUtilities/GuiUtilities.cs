/**
 * MiniUnityUtilities
 * Copyright (c) Simon Raichl 2019 - 2020
 * MIT License
 */

using UnityEngine;

public static class GuiUtilities
{
    public static void ShowGuiElement(GameObject guiElement)
    {
        guiElement.GetComponent<RectTransform>().localScale = Vector3.one;
    }

    public static void HideGuiElement(GameObject guiElement)
    {
        guiElement.GetComponent<RectTransform>().localScale = Vector3.zero;
    }
}
