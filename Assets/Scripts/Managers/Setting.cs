using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public static class Setting
{
    public static GameManager gameManager;
    public static ResourceManager resourceManager;
    public static ResourceManager GetResourceManager()
    {
        if(resourceManager == null)
        {
            resourceManager = Resources.Load("ResourceManager") as ResourceManager;
        }
        return resourceManager;
    }

    public static List<RaycastResult> GetUIObjects()
    {
        PointerEventData pointerData = new PointerEventData(EventSystem.current)
        {
            position = Input.mousePosition
        };
        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerData, results);
        return results;
    }
}
