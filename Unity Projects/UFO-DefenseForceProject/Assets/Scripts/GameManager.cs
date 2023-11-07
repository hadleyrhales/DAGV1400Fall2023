using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isGameOver; // helps determines game's state
    private GameObject gameOverText; // access to GameOverText UI element
    public AudioClip failSound;
    private AudioSource managerAudio;

    void Awake()
    {
        Time.timeScale = 1;
        isGameOver = false; // set to false as default
    }

    // Start is called before the first frame update
    void Start()
    {
        managerAudio = GetComponent<AudioSource>();
        gameOverText = GameObject.Find("GameOverText"); // finds GameOverText UI element
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            // if isGameOver is true, calls EndGame method
            EndGame();
        }
        else
        {
            // GameOverText is hidden
            gameOverText.gameObject.SetActive(false);
        }
    }

    public void EndGame()
    {
        // plays failSound, reveals GameOverText, and freezes game
        managerAudio.PlayOneShot(failSound, 1f);
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
