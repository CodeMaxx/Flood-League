using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereExpansion : MonoBehaviour {
    public GameObject ship;
    public GameObject human;

    private int currHero;
    private CapsuleCollider humanCollider;

    private void Start() {
        humanCollider = human.GetComponent<CapsuleCollider>();
    }

    void Update () {
        SuperheroChoose superheroChooseScript = ship.GetComponent<SuperheroChoose>();
        currHero = superheroChooseScript.chosenHero;

        if (currHero == 2) {
            transform.localScale = new Vector3(5, 5, 5);
            humanCollider.radius = 2.5f;
        } else {
            transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
            humanCollider.radius = 1;
        }
    }
}
