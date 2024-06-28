using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private CardData cardToTest;
    [Space(10f)]
    [SerializeField] private MeshRenderer meshRenderer;

    void Start() {
        cardToTest.cardBehavior.GetClass().GetMethod("OnDraw").Invoke(null, null);
        cardToTest.cardBehavior.GetClass().GetMethod("OnPlay").Invoke(null, null);
        cardToTest.cardBehavior.GetClass().GetMethod("OnDiscard").Invoke(null, null);
    }
}
