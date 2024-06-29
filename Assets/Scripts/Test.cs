using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private Deck deck = new();
    [Space(10f)]
    [SerializeField] private MeshRenderer meshRenderer;

    void Start() {
        // Initialize deck, log it, and retrieve a card
        deck.Initialize();

        Debug.Log(deck.ToString());

        CardData card = deck.DrawCard();

        // Set this object's material to use the card's texture
        Material newMaterial = meshRenderer.material;

        newMaterial.mainTexture = card.frontTexture;

        meshRenderer.material = newMaterial;

        // Call card methods
        card.OnDraw();

        card.OnPlay();

        // Log the deck after drawing the card
        Debug.Log(deck.ToString());
    }
}
