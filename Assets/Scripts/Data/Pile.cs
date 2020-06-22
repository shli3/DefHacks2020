using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Pile : MonoBehaviour {
  public bool isDeck = true;

    void Start() {

    }

    void Update() {
      MoveCardPile(new Card(1, CardSuit.Hearts), this);
      MoveCardPile(new Card(3, CardSuit.Hearts), this);
      MoveCardPile(new Card(3, CardSuit.Diamonds), this);
      MoveCardPile(new Card(1, CardSuit.Spades), this);
      MoveCardPile(new Card(0, CardSuit.Hearts), this);
      MoveCardPile(new Card(5, CardSuit.Clubs), this);
      MoveCardPile(new Card(4, CardSuit.Hearts), this);
      MoveCardPile(new Card(2, CardSuit.Hearts), this);
      MoveCardPile(new Card(0, CardSuit.Spades), this);
    }
  
    private void MoveCardPile(Card card, Pile pile){
      CardObject singleCard = CardManager.GetCards(card)[0];
      singleCard.transform.parent = pile.transform;
      pile.RearrangeCards();
    }

    //Right now we're doing just decks and rivers
    public void RearrangeCards() {
      
      if(isDeck){
        for(int i = 0; i < this.transform.childCount; i++){
          this.transform.GetChild(i).localPosition = new Vector3(0, 0.01f*i, 0);
        }
      }
      else{                             //River
        for(int j = 0; j < this.transform.childCount; j++){
          this.transform.GetChild(j).localPosition = new Vector3(0.2f*j, 0, 0);
        }
      }
    }
}
