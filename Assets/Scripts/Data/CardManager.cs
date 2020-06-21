using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class CardManager {
  private static List<Dictionary<Card, CardObject>> decks;

  public static void InitializeCards(int numDecks, GameObject cardPrefab, Transform parent) {
    decks = new List<Dictionary<Card, CardObject>>();
    for (int deck = 0; deck < numDecks; deck++) {
      Dictionary<Card, CardObject> currDeck = new Dictionary<Card, CardObject>();
      for (int rank = 1; rank <= 13; rank++) {
        for (int suit = 0; suit < 4; suit++) {
          CardObject card = GameObject.Instantiate(cardPrefab, new Vector3(rank, deck, suit), Quaternion.identity, parent).GetComponent<CardObject>();
          Card cardData = new Card(rank, (CardSuit) suit);
          card.InitializeSuit(cardData);
          currDeck.Add(cardData, card);
        }
      }
          CardObject card0 = GameObject.Instantiate(cardPrefab, new Vector3(0, deck, 0), Quaternion.identity, parent).GetComponent<CardObject>();
          card0.InitializeSuit(new Card(0, CardSuit.Hearts));
          currDeck.Add(new Card(0, CardSuit.Hearts), card0);
          currDeck.Add(new Card(0, CardSuit.Diamonds), card0);
          CardObject card1 = GameObject.Instantiate(cardPrefab, new Vector3(0, deck, 0), Quaternion.identity, parent).GetComponent<CardObject>();
          card1.InitializeSuit(new Card(0, CardSuit.Spades));
          currDeck.Add(new Card(0, CardSuit.Spades), card1);
          currDeck.Add(new Card(0, CardSuit.Clubs), card1);
      decks.Add(currDeck);
    }
  }

  public static CardObject[] GetCards(Card cardData) {
    return decks.Select(x => x[cardData]).ToArray();
  }

  
}
