using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card Data", menuName = "Cards/Card Data", order = 0)]
public class CardData : ScriptableObject
{
    public string displayName = "New Card";
    public string description = "A basic card with no effect.";
    public Texture2D frontSprite, backSprite;
    public MonoScript cardBehavior;
}
