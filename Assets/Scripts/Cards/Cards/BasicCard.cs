using UnityEngine;

[CreateAssetMenu(fileName = "Basic Card", menuName = "Cards/Basic Card")]
public class BasicCard : CardData
{
    public override void OnDraw() 
    {
        Debug.Log("Drew " + GetType());
    }

    public override void OnPlay()
    {
        Debug.Log("Played " + GetType());
    }

    public override void OnDiscard()
    {
        Debug.Log("Discarded " + GetType());
    }
}
