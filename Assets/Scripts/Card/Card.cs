using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName ="Card")]
public class Card : ScriptableObject
{
    public CardType cardType;
    public CardProperties[] properties;

}
