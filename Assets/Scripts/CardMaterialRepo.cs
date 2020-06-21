using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CardMaterialRepo {
  
  public static Material GetCardMaterial(Card card) {
    int rank = card.Rank;
    CardSuit suit = card.Suit;
    
    if (rank < 0 || rank > 13) {
      throw new Exception("CardMaterialRepo: Invalid card rank!");
    }

    string materialName = "";
    
    if (rank == 0) {
      materialName = suit == CardSuit.Diamonds || suit == CardSuit.Hearts ? "Joker_Red" : "Joker_Black";
    } else {
      string rankName;
      if (rank == 1) {
        rankName = "A";
      } else if (rank == 11) {
        rankName = "J";
      } else if (rank == 12) {
        rankName = "Q";
      } else if (rank == 13) {
        rankName = "K";
      } else {
        rankName = rank.ToString();
      }

      string suitName = suit.ToString();
      materialName = rankName + "_" + suitName;
    }
    return Resources.Load("CardMaterials/" + materialName) as Material;
  }
}
