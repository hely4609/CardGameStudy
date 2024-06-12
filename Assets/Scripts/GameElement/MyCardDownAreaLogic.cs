using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Areas/MyCardsDownWhenHoldingCard")]
public class MyCardDownAreaLogic : AreaLogic
{
    public CardVariable card;
    public CardType creatureType;
    public TransformVariable areaGrid;
    public GameElementLogic cardDownLogic;

    public override void Execute()
    {
        if(card.value == null)
        {
            return;
        }
        if(card.value.cardVisual.cardData.cardType == creatureType)
        {
            card.value.transform.transform.SetParent(areaGrid.value.transform);
            card.value.transform.localPosition = Vector3.zero;
            card.value.transform.localScale = Vector3.one;
            card.value.transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
            card.value.gameObject.SetActive(true);
            card.value.currentLogic = cardDownLogic;
            // place card down 카드를 내려놓는다.
        }
    }
}
