﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms;

public class Logic : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    // Use this for initialization
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
        max = max + 1;
    }

    public void OnPressHigher()
    {
        max = guess -1;
        NextGuess();
    }

    public void OnPressLower() 
    {
        min = guess + 1;
        NextGuess();
    }
    
    public void NextGuess()
    {
        guess = (Random.Range(min, max + 1));
        guessText.text = guess.ToString();
    }
}

