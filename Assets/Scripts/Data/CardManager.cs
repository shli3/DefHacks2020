using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour {
  private Dictionary<Card, GameObject> deck;
  [SerializeField] private GameObject cardPrefab;

  public void InitializeCards(int numDecks) {
    for (int rank = 1; rank <= 13; rank++) {
      for (int suit = 0; suit < 4; suit++) {
        GameObject card = Instantiate(cardPrefab, new Vector3(rank, 0, suit), Quaternion.identity);
        Card cardData = new Card(rank, (CardSuit) suit);
        card.GetComponent<CardObject>().InitializeSuit(cardData);
        this.deck.Add(cardData, card);
      }
    }
  }

  public GameObject GetCard(Card cardData) {
    return this.deck[cardData];
  }

  public void Start() {
    this.deck = new Dictionary<Card, GameObject>();
    this.InitializeCards(1);
    this.GetCard(new Card(4, CardSuit.Diamonds)).GetComponent<CardObject>().FaceUp = false;
  }
}
