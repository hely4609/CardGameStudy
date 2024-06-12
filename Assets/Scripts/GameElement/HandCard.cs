using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Element/My Hand Card")]
public class HandCard : GameElementLogic
{
    public CardVariable currentCard;
    public GameEvent onCurrentCardSelected;
    public State holdingCard;
    public override void OnClick(CardInstance inst)
    {
        currentCard.Set(inst);
        Setting.gameManager.SetState(holdingCard);
        onCurrentCardSelected.Raise();
    }

    public override void OnHighlight(CardInstance inst)
    {
        
    }
}
