﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    public int score;



    void Start()
    {
        
    }

    
    void Update()
    {
        scoreText.text = "" + score;
    }


    public void IncreaseScore(int amountToIncrease)
    {
        score += amountToIncrease;
    }






}
