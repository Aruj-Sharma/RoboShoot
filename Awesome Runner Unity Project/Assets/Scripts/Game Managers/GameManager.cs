using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	[HideInInspector]
	public bool gameStartedFromMainMenu, gameRestartedPlayerDied;

	[HideInInspector]
	public float score, health, level;

	[HideInInspector]
	public bool canPlayMusic = true;

	void Awake () {
		MakeSingleton ();
	}

    private void Start()
    {
        GameInit();
    }
    void MakeSingleton() {
		if (instance != null) {
			Destroy (gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
	}

    void GameInit()
    {
        if(!PlayerPrefs.HasKey("Game Started"))
        {
            GamePreferences.SetIsMusicOn(1);
            GamePreferences.SetHighscore(0);

            PlayerPrefs.SetInt("Game Started", 123);
        }
    }


} // class

































