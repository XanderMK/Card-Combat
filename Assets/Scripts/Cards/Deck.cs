using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[System.Serializable]
public class Deck
{
    // Used to dictate the number of each type of card in the deck
    // in the inspector.
    [System.Serializable]
    public struct CardTypeInDeck 
    {
        public CardData card;
        public uint cardAmount;
    }

    [SerializeField]
    private List<CardTypeInDeck> deckBuild = new();

    [HideInInspector] 
    public List<CardData> cards = new();

    public void Initialize() 
    {
        // Add all cards to the deck
        foreach (CardTypeInDeck cardTypeInDeck in deckBuild)
        {
            for (int i = 0; i < cardTypeInDeck.cardAmount; i++)
            {
                cards.Add(cardTypeInDeck.card);
            }
        }

        // Shuffle the newly created deck
        Shuffle();
    }

    public void Shuffle() 
    {
        // Randomize the order of all cards in the deck
        var shuffledDeck = cards.OrderBy(_ => Random.value).ToList();
        cards.Clear();
        cards.AddRange(shuffledDeck);
    }

    public CardData DrawCard()
    {
        if (cards.Count == 0)
        {
            Debug.LogError("Trying to draw from the deck when it is empty!");
            return null;
        }

        CardData card = cards[0];
        cards.RemoveAt(0);
        return card;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();

        stringBuilder.Append("Deck: ");
        foreach (CardData card in cards)
        {
            stringBuilder.Append(card.displayName);
            stringBuilder.Append(", ");
        }
        return stringBuilder.ToString();
    }
}

