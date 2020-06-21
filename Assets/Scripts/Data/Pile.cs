using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Pile : MonoBehaviour {
  public bool isDeck = true;
  
    private void MoveCardPile(Card card, Pile pile){
      CardObject obj = CardManager.GetCards(card)[0];
      obj.transform.parent = pile.transform;
      pile.RearrangeCards();
    }

    public void RearrangeCards() {
      
    }
}
