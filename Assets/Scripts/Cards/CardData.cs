using UnityEngine;

public abstract class CardData : ScriptableObject
{
    public string displayName = "New Card";
    public string description = "A basic card with no effect.";
    public Texture2D frontSprite, backSprite;
    
    public abstract void OnDraw();
    public abstract void OnPlay();
    public abstract void OnDiscard();
}
