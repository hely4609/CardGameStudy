using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CurrentSelected : MonoBehaviour
{
    public CardVariable currentCard;
    public CardVisual cardVisual;

    Transform mTransform;
    public void LoadCard()
    {
        //Debug.Log("dd");
        if (currentCard.value == null)
            return;

        currentCard.value.gameObject.SetActive(false);
        cardVisual.LoadCard(currentCard.value.cardVisual.cardData);
        cardVisual.gameObject.SetActive(true);
    }
    public void CloseCard()
    {
        cardVisual.gameObject.SetActive(false);
    }
    private void Start()
    {
        mTransform = transform;
        CloseCard();
    }
    private void Update()
    {
        mTransform.position = Input.mousePosition;
    }
}
