/**
 * MiniUnityUtilities
 * Copyright (c) Simon Raichl 2019
 * MIT License
 */

using UnityEngine;

public static class UIUtilities
{
    public static void ShowUIElement(GameObject uiElement)
    {
        uiElement.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
    }

    public static void HideUIElement(GameObject uiElement)
    {
        uiElement.GetComponent<RectTransform>().localScale = Vector3.zero;
    }
}
