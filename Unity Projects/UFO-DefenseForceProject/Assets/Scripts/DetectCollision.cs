using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
   public ScoreManager scoreManager; // access to ScoreManager
   public int scoreToGive; // score associated with attached gameObject
   public AudioClip destructSound;
   public AudioSource enemyAudio;

   void Start()
   {
      scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // finds ScoreManager gameObject and references ScoreManager script
      enemyAudio = GameObject.Find("AudioManager").GetComponent<AudioSource>();
      //enemyAudio.PlayOneShot(destructSound, 1.5f);
   }

   void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.CompareTag("Player"))
      {
         // when it hits player, gameObject destroys itself
         enemyAudio.PlayOneShot(destructSound, 1.5f);
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
         enemyAudio.PlayOneShot(destructSound, 1.5f);
         Destroy(gameObject);
         Destroy(other.gameObject);
      }
   }
}
