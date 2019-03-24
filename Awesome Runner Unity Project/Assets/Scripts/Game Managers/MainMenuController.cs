using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour {

    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
	private Button musicBtn;

	[SerializeField]
	private Sprite soundOff, soundOn;

   
    void Start()
    {
        if (GamePreferences.GetIsMusicOn() == 1)
        {
            audioSource.Play();
            
        }
        else
        {
            audioSource.Pause();
            
        }
    }

    private void Update()
    {
        if (GamePreferences.GetIsMusicOn() == 1)
        {
            audioSource.UnPause();
            musicBtn.image.sprite = soundOn;

        }
        else
        {
            audioSource.Pause();
            musicBtn.image.sprite = soundOff;
        }
    }

    public void PlayGame() {
		GameManager.instance.gameStartedFromMainMenu = true;
		SceneManager.LoadScene (Tags.GAMEPLAY_SCENE);
	}

	public void ControlMusic() {
		if (GamePreferences.GetIsMusicOn() == 1) {
			musicBtn.image.sprite = soundOn;
            GamePreferences.SetIsMusicOn(0);
        } else {
			musicBtn.image.sprite = soundOff;
            GamePreferences.SetIsMusicOn(1);
        }
	}

    public void GetHighScore()
    {
                SceneManager.LoadScene("HighScore");
    }

    public void SeeCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void AboutUs()
    {
        SceneManager.LoadScene("AboutUs");
    }

} // class































