using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private CardData cardToTest;
    [Space(10f)]
    [SerializeField] private MeshRenderer meshRenderer;

    void Start() {
        cardToTest.OnDraw();
        cardToTest.OnPlay();
        cardToTest.OnDiscard();
    }
}
