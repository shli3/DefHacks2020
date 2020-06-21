using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public enum CardSuit {
//    Hearts,
//    Clubs,
//    Diamonds,
//    Spades,
// }
//  
// public class Card {
//    private CardSuit _suit;
//    private int _rank;
//  
//    public CardSuit Suit { get { return _suit; } }
//    public int Rank { get { return _rank; } }
//  
//    private GameObject _card;
//  
//    public Card(CardSuit suit, int rank, Vector3 position, Quaternion rotation) {
//       // to do: validate rank, position, and rotation
//       string assetName = string.Format("Card_{0}_{1}", suit, rank);  // Example:  "Card_1_10" would be the Jack of Hearts.
//       GameObject asset = GameObject.Find(assetName);
//       if (asset == null) {
//           Debug.LogError("Asset '" + assetName + "' could not be found.");
//       } else {
//          _card = Instantiate(asset, position, rotation);
//          _suit = suit;
//          _rank = rank;
//       }
//    }
// }
//  
// public class Deck {
//    private List<Card> _deck = new List<Card>();
//    private List<Card> _discardPile = new List<Card>();
//  
//    public void Shuffle() {
//       /* To Do: Code needs to be complete*/
//    }
//  
//    public Card TakeCard() {
//       if (_deck.Count == 0)
//          return null; // the deck is depleted
//        
//       // take the first card off the deck and add it to the discard pile
//       Card card = _deck[0];
//       _deck.RemoveAt(0);
//       _discardPile.Add(card);
//  
//       return card;
//    }
//  
//    /* any source to add... */
// }