using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class setupFinalScore : MonoBehaviour {

    public Text Score;

    // Use this for initialization
    void Start () {
        Score.text = "" + ApplicationModel.score;
        Invoke("Load", 3f);
    }

    // Update is called once per frame
    void Update () {

    }

    void Load()
    {
        SceneManager.LoadScene("Menu");
    }
}
