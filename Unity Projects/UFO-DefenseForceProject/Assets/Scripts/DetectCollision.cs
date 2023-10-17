using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
   public ScoreManager scoreManager; // access to ScoreManager
   public int scoreToGive; // score associated with attached gameObject

   void Start()
   {
      scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // finds ScoreManager gameObject and references ScoreManager script
   }

   void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.CompareTag("Player"))
      {
         // when it hits player, gameObject destroys itself
         Destroy(gameObject);
      }
      else if (other.gameObject.CompareTag("Item"))
      {
         // ignores objects w/ Item tag
      }
      else
      {
         // increases score when gameObject hits other and destroys both gameObject and other
         scoreManager.IncreaseScore(scoreToGive);
         Destroy(gameObject);
         Destroy(other.gameObject);
      }
   }
}
