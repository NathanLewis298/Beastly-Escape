using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HeartManager : MonoBehaviour
{
    

    public Text amountOfHeartsText;
    public Text countdownTimeText;


    // Needs to be converted into 10:00 mins
    public float currentTimer = 5;


    public int currentAmountOfHearts = 5;
    public int maxHeartsAllowed = 5;











    void Start()
    {
        currentAmountOfHearts = GameData.gameData.saveData.amountOfLives;
        SetTextUILol();



    }

   
    void Update()
    {

        

        if (currentAmountOfHearts < maxHeartsAllowed)
        {
            
            currentTimer -= Time.deltaTime;
            if (currentTimer <= 0)
            {
                currentAmountOfHearts++;
                currentTimer = 5;

                GameData.gameData.saveData.amountOfLives = currentAmountOfHearts;
            }

            SetTextUILol();

        }


    }



    void SetTextUILol()
    {
        TimeSpan t = TimeSpan.FromSeconds(currentTimer);

        string answer = string.Format("{0:D2}:{1:D2}",
                        
                        t.Minutes,
                        t.Seconds);


        amountOfHeartsText.text = currentAmountOfHearts.ToString();
        countdownTimeText.text = answer;

        if(currentAmountOfHearts == maxHeartsAllowed)
        {
            countdownTimeText.text = "Full!";
        }

    }


}
