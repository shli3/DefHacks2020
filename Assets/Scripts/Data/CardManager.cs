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
      decks.Add(currDeck);
    }
  }

  public static CardObject[] GetCards(Card cardData) {
    return decks.Select(x => x[cardData]).ToArray();
  }
}
