using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInstance : MonoBehaviour, IClickable
{
    public CardVisual cardVisual;
    public GameElementLogic currentLogic;

    private void Start()
    {
        cardVisual = GetComponent<CardVisual>();
    }

    public void OnClick()
    {
        if (currentLogic == null)
            return;
        currentLogic.OnClick(this);
    }

    public void OnHighlight()
    {
        if(currentLogic == null)
            return;
        currentLogic.OnHighlight(this);
    }
}
