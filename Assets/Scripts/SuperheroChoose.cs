using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuperheroChoose : MonoBehaviour
{
    public GameObject superman;
    public GameObject armadillo;
    public int chosenHero;

    // Use this for initialization
    void Start()
    {
        chosenHero = 1;
        setHero(1);
    }

    void setHero(int heroNo)
    {
        if (heroNo == 1)
        {
            superman.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            armadillo.GetComponent<Image>().color = new Color32(255, 255, 255, 80);
        }
        else
        {
            superman.GetComponent<Image>().color = new Color32(255, 255, 255, 80);
            armadillo.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (!(chosenHero == 1))
            {
                chosenHero = 1;
                setHero(1);
            }
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (!(chosenHero == 2))
            {
                chosenHero = 2;
                setHero(2);
            }
        }
    }
}
