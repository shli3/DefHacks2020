﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardObject : MonoBehaviour {
  
  public bool FaceUp;
  private float zRotation;
  private bool wasFaceUp;
  [SerializeField] private float flipTime = 0.5f;
  [SerializeField] private float flipHeight = 1f;
  
  void Start() {
    this.wasFaceUp = this.FaceUp;
    this.FlipCard();
  }
  
  void Update() {
    if (this.wasFaceUp == this.FaceUp) 
      return;
    
    this.FlipCard();
    this.wasFaceUp = this.FaceUp;
  }

  private void FlipCard() {
    this.zRotation = this.FaceUp ? 0 : 180;
    LeanTween.rotateZ(this.gameObject, this.zRotation, this.flipTime);
  }
  
}
