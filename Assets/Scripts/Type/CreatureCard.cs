using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Cards/Creature")]
public class CreatureCard : CardType
{
    public override void OnSetType(CardVisual visual)
    {
        base.OnSetType(visual);
        visual.statsHolder.SetActive(true);

    }
}
