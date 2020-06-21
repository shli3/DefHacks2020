using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pile : MonoBehaviour
{
    private void MoveCardPile(Card card, Pile pile){
        CardObject obj = CardManager.GetCards(1, Hearts);
        SetPile(obj, pile);
    }

    private void SetPile(Card c, Pile p){
        c.transform.parent = p.transform;
    }
}
