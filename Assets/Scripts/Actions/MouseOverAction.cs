using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

[CreateAssetMenu(menuName = "Actions/MouseOverAction")]
public class MouseOverAction : Action
{
    public override void Excute(float deltaTime)
    {
        List<RaycastResult> results = Setting.GetUIObjects();

        IClickable clickable = null;

        foreach (RaycastResult ray in results)
        {
            clickable = ray.gameObject.GetComponentInParent<IClickable>();

            if (clickable != null)
            {
                clickable.OnHighlight();
                break;
            }
            else
            {
                //Debug.Log($"{ray.gameObject.name}");
            }
        }
    }
}

