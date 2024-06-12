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

    // �� ������Ƽ�� ������ Elemet���� ī��.������Ƽ �迭�� �Ѱ��� �������.
    // �ش� �����Ͱ� ������ �� �����Ͷ� ó�� ������ ���� ������Ʈ�� ������.
    // ���� �����Ͱ� �����Ѵٸ� ����� �ι� �Է��ؾ���.
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
