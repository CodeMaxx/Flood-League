using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGame()
    {
        ApplicationModel.score = 0;
        ApplicationModel.currentLevel = 1;
        SceneManager.LoadScene("Transition");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("Level Select");
    }

    public void TryAgain() {
        SceneManager.LoadScene("Menu");
    }
}
