using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Cards/Spell")]
public class SpellCard : CardType
{
    public override void OnSetType(CardVisual visual)
    {
        base.OnSetType(visual);
        visual.statsHolder.SetActive(false);

    }
}
