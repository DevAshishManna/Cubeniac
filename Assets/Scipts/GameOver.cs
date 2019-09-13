using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    public Text scoreText;
    public Text highScoreText;
    private int highScore;

    void Start()
    {
        scoreText.text = "Score " + DataHelper.score;

        if (PlayerPrefs.HasKey("highScore"))
        {
            highScore = PlayerPrefs.GetInt("highScore");
        }
        else
        {
            highScore = 0;
        }

        if (DataHelper.score > highScore)
        {
            PlayerPrefs.SetInt("highScore", DataHelper.score);
            highScoreText.text = "New High score";
        }
        else
        {
            highScoreText.text = "Current High score : "+highScore;
        }
    }
   
}