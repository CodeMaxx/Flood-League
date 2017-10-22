using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetupTransition : MonoBehaviour {

    public Text Score;
    public Text LoadingLevel;

	// Use this for initialization
	void Start () {
        Score.text = "" + ApplicationModel.score;
        LoadingLevel.text = "Loading Level " + ApplicationModel.currentLevel;
        Invoke("Load", 3f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Load()
    {
        SceneManager.LoadScene("Level" + ApplicationModel.currentLevel);

    }
}
