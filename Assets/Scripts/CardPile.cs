using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPile : MonoBehaviour
{
    
    private Card InDeck;
    private bool FaceDown = true;
    [SerializeField] private MeshRenderer model;


    public void InitializeDeck(List<Card> deck = new List<Card>()){
        this.InDeck = card;
        this.model.material = CardMaterialRepo.GetCardMaterial(this.InDeck);
    }
    void Start()
    {
        // CardManager.InitializeCards(1);                     //Makes one deck
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
