using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HighscoreController : MonoBehaviour
{
    [SerializeField]
    private Text Hscore;

    void Start()
    {
        SetScoreOnGP();
         
    }

    void SetScore( int score)
    {
        Hscore.text = "HighScore : " + score.ToString();
    }

    void SetScoreOnGP()
    {
        SetScore(GamePreferences.GetHighscore());
    }

    public void OnBackButton()
    {
        SceneManager.LoadScene(Tags.MAINMENU_SCENE);
    }
    void Update()
    {
        
    }
}
