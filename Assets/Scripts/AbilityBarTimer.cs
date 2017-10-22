using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityBarTimer : MonoBehaviour {
    public int amount;

	// Use this for initialization
	void Start () {
        StartCoroutine(IncrementAbility());
	}
	
	// Update is called once per frame
	void Update () {
	}

    IEnumerator IncrementAbility()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            if (amount >= 0 && amount < 5)
            {
                incrementByOne();
            }
        }
    }

    void incrementByOne()
    {
        amount++;
        transform.localScale = new Vector3(Mathf.Clamp((float)amount/5, 0f, 1f), transform.localScale.y, transform.localScale.z);
    }
}
