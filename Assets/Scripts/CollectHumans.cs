using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectHumans : MonoBehaviour {

    public int currentRescueScore = 0;
    public int totalRescues = 3;
    public Text RescueScore;
    // public GameObject b;

    // Use this for initialization
    void Start()
    {
        RescueScore.text = currentRescueScore.ToString() + "/" + totalRescues;
        ApplicationModel.currentRescues = currentRescueScore;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.CompareTag("Human")) {
            currentRescueScore+=1;
            updateRescueScore();
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("Finish"))
        {
            Debug.Log("Finish");
            ApplicationModel.score += ApplicationModel.currentRescues * 10 + ApplicationModel.currentHealth;
            ApplicationModel.currentLevel++;
            if(ApplicationModel.currentLevel == 3)
                SceneManager.LoadScene("Final Score");
            else
                SceneManager.LoadScene("Transition");
        }
    }

    void updateRescueScore()
    {
        RescueScore.text = currentRescueScore.ToString() + "/" + totalRescues;
        ApplicationModel.currentRescues = currentRescueScore;
    }
}
