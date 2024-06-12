using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeEnum
{
    Creature, Spell
}
public class CardType : ScriptableObject
{
    public TypeEnum typeName;

    public virtual void OnSetType(CardVisual visual)
    {
        Element element = Setting.GetResourceManager().typeElement;
        CardVisualProperties type = visual.GetProperty(element);
        type.text.text = typeName.ToString();
    }
}
