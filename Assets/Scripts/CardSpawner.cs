using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSpawner : MonoBehaviour
{
  [SerializeField] private GameObject cardPrefab;
  // Start is called before the first frame update
  void Start()
  {
      CardManager.InitializeCards(1, cardPrefab, this.transform);
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.anyKey) {
      foreach (GameObject card in CardManager.GetCards(new Card(6, CardSuit.Clubs))) {
        card.GetComponent<CardObject>().FaceUp = !card.GetComponent<CardObject>().FaceUp;
      }
    }
  }
}
