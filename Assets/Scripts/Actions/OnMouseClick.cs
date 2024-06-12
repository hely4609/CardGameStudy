using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[CreateAssetMenu(menuName = "Actions/MouseClick")]
public class OnMouseClick : Action
{
    public override void Excute(float deltaTime)
    {
        if (Input.GetMouseButtonDown(0))
        {
            List<RaycastResult> results = Setting.GetUIObjects();

            IClickable clickable = null;

            foreach (RaycastResult ray in results)
            {
                clickable = ray.gameObject.GetComponentInParent<IClickable>();

                if (clickable != null)
                {
                    clickable.OnClick();
                    break;
                }
                else //�ʴ� ������?
                {
                    Debug.Log($"{ray.gameObject.name}");
                }
            }
        }
    }
}
