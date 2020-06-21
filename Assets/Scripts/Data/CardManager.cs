using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour {
  private List<GameObject> cards;
  [SerializeField] private GameObject cardPrefab;

  public void InitializeCards(int numDecks) {
    for (int rank = 1; rank <= 13; rank++) {
      for (int suit = 0; suit < 4; suit++) {
        GameObject card = Instantiate(cardPrefab, new Vector3(rank, 0, suit), Quaternion.identity);
        card.GetComponent<CardObject>().InitializeSuit(new Card(rank, (CardSuit) suit));
        this.cards.Add(card);
      }
    }
  }

  public void Start() {
    this.cards = new List<GameObject>();
    this.InitializeCards(1);
  }
}
