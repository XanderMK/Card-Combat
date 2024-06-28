using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BasicCardBehavior : ICardBehavior
{
    public static void OnDraw() {
        Debug.Log("Drew " + nameof(BasicCardBehavior));
    }

    public static void OnPlay() {
        Debug.Log("Played " + nameof(BasicCardBehavior));
    }

    public static void OnDiscard() {
        Debug.Log("Discarded " + nameof(BasicCardBehavior));
    }
}
