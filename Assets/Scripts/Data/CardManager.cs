using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class CardManager {
  private static List<Dictionary<Card, GameObject>> decks;

  public static void InitializeCards(int numDecks, GameObject cardPrefab, Transform parent) {
    decks = new List<Dictionary<Card, GameObject>>();
    for (int deck = 0; deck < numDecks; deck++) {
      Dictionary<Card, GameObject> currDeck = new Dictionary<Card, GameObject>();
      for (int rank = 1; rank <= 13; rank++) {
        for (int suit = 0; suit < 4; suit++) {
          GameObject card = GameObject.Instantiate(cardPrefab, new Vector3(rank, deck, suit), Quaternion.identity, parent);
          Card cardData = new Card(rank, (CardSuit) suit);
          card.GetComponent<CardObject>().InitializeSuit(cardData);
          currDeck.Add(cardData, card);
        }
      }
      decks.Add(currDeck);
    }
  }

  public static GameObject[] GetCards(Card cardData) {
    return decks.Select(x => x[cardData]).ToArray();
  }
}
