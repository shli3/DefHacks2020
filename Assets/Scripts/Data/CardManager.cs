using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CardManager : MonoBehaviour {
  private List<Dictionary<Card, GameObject>> decks;
  [SerializeField] private GameObject cardPrefab;

  public void InitializeCards(int numDecks) {
    this.decks = new List<Dictionary<Card, GameObject>>();
    for (int deck = 0; deck < numDecks; deck++) {
      Dictionary<Card, GameObject> currDeck = new Dictionary<Card, GameObject>();
      for (int rank = 1; rank <= 13; rank++) {
        for (int suit = 0; suit < 4; suit++) {
          GameObject card = Instantiate(cardPrefab, new Vector3(rank, deck, suit), Quaternion.identity);
          Card cardData = new Card(rank, (CardSuit) suit);
          card.GetComponent<CardObject>().InitializeSuit(cardData);
          currDeck.Add(cardData, card);
        }
      }
      this.decks.Add(currDeck);
    }
  }

  public GameObject[] GetCards(Card cardData) {
    return this.decks.Select(x => x[cardData]).ToArray();
  }

  public void Start() {
    //TODO: remove these lines, they are just 
    this.InitializeCards(2);
    this.GetCards(new Card(4, CardSuit.Diamonds))[0].GetComponent<CardObject>().FaceUp = false;
  }
}
