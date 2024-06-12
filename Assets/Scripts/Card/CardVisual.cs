using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardVisual : MonoBehaviour
{
    public Card cardData;
    public CardVisualProperties[] properties;
    public GameObject statsHolder;
    

    public void OnEnable()
    {
        LoadCard(cardData);
    }

    public void LoadCard(Card card)
    {
        if (card == null)
        {
            return;
        }
        cardData = card;
        card.cardType.OnSetType(this);

        for (int i = 0; i < card.properties.Length; i++)
        {
            //Debug.Log($"{card.properties.Length}");
            CardProperties cardProp = card.properties[i];
            CardVisualProperties properties = GetProperty(cardProp.element);
            if(properties == null)
            {
                return;
            }
            if (cardProp.element is ElementText)
            {
                properties.text.text = cardProp.stringValue;
            }
            else if (cardProp.element is ElementInt)
            {
                properties.text.text = cardProp.intValue.ToString();
            }
            else if (cardProp.element is ElementImage)
            {
                properties.image.sprite = cardProp.sprite;
            }
        }
    }

    // 겟 프로퍼티로 가져온 Elemet에는 카드.프로퍼티 배열의 한개가 들어있음.
    // 해당 데이터가 들어오면 그 데이터랑 처음 만나는 동일 엘레멘트랑 반응함.
    // 같은 데이터가 들어가야한다면 나누어서 두번 입력해야함.
    public CardVisualProperties GetProperty(Element element)
    {
        CardVisualProperties result = null;
        for(int i = 0; i< properties.Length; i++)
        {
            //Debug.Log($"{properties.Length}");
            if (properties[i].element == element)
            {
                result = properties[i];
                break;
            }
        }

        return result;
    }
}
