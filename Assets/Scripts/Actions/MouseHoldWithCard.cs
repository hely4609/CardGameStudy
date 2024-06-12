
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

[CreateAssetMenu(menuName = "Actions/MouseHoldWithCard")]
public class MouseHoldWithCard : Action
{
    public CardVariable currentCard;
    public State playerControlState;
    public GameEvent onPlayerControlState;
    public override void Excute(float deltaTime)
    {
        bool mouseIsDown = Input.GetMouseButton(0);
        if (!mouseIsDown)
        {
            List<RaycastResult> results = Setting.GetUIObjects();
           

            foreach (RaycastResult result in results)
            {
                // 놓을 수 있는 영역을 체크.
                Area area = result.gameObject.GetComponentInParent<Area>();
                if (area != null)
                {
                    area.OnDrop();
                    break;
                }

            }
                currentCard.value.gameObject.SetActive(true);
            currentCard.value = null;

            Setting.gameManager.SetState(playerControlState);
            onPlayerControlState.Raise();
            return;
        }
    }
}
