using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndSceneManagerScript : MonoBehaviour
{
    public Text hiScoreText;
    public Text hiScoreLabelText;
    public Text LastScoreText;
    public Text LastScoreLaberText;
    int hiScore;
    int lastScore;
    public Text buttonText;

    // Start is called before the first frame update
    void Start()
    {
        buttonText.text = "RETRY!!";
        hiScoreLabelText.text = "HighSCORE";
        LastScoreLaberText.text = "LastSCORE";
        
       

        lastScore = PlayerPrefs.GetInt("score");
        LastScoreText.text = lastScore.ToString();
        if (PlayerPrefs.HasKey("hiScore") == true)//初期値でない
        {
            hiScore = PlayerPrefs.GetInt("hiScore");
            if (hiScore < lastScore)
            {
                hiScore = lastScore;
                PlayerPrefs.SetInt("hiScore", hiScore);
            }
        }
        else//初期値
        {
            hiScore = lastScore;
            PlayerPrefs.SetInt("hiScore", hiScore);
           
        }

        hiScoreText.text = hiScore.ToString();
    }

    // Update is called once per frame
    public void RetryButton()
    {
        SceneManager.LoadScene("StartScene");
    }
}
