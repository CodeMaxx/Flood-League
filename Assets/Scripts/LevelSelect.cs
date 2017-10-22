using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour {

	// Use this for initialization
	void Start () {

        print("level- " + ApplicationModel.currentLevel);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Level1()
    {
        ApplicationModel.score = 0;
        ApplicationModel.currentLevel = 1;
        SceneManager.LoadScene("Transition");
    }

    public void Level2()
    {
        ApplicationModel.score = 0;
        ApplicationModel.currentLevel = 2;
        SceneManager.LoadScene("Transition");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
