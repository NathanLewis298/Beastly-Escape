using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConfirmPanel : MonoBehaviour
{

    public string levelToLoad;
    public int level;
    private GameData gameData;
    private int highScore;

    public Text highScoreText;
    void OnEnable()
    {
        gameData = FindObjectOfType<GameData>();
        LoadData();
        SetText();
    }

    void LoadData()
    {
        if(gameData != null)
        {
            highScore = gameData.saveData.highScores[level - 1];
        }
    }
    
    void SetText()
    {
        highScoreText.text = "" + highScore;
    }
    
    
    void Update()
    {
        
    }



    public void Cancel()
    {
        this.gameObject.SetActive(false);

    }

    public void Play()
    {
        PlayerPrefs.SetInt("Current Level", level - 1);
        SceneManager.LoadScene(levelToLoad);
    }
}
