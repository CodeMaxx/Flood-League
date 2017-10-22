using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L1SupermanComponent : MonoBehaviour
{
    public GameObject ship;
    private int currHero;
    public ParticleSystem explosion;
    public LineRenderer laser;
    public GameObject abilityBar;
    public AbilityBarTimer abilityBarTimer;

    public void explode(Vector3 position)
    {
        Instantiate(explosion, position, Quaternion.identity);
    }

    // Use this for initialization
    void Start()
    {
        abilityBarTimer = abilityBar.GetComponent<AbilityBarTimer>();
    }

    // Update is called once per frame
    void Update()
    {
        L1SuperheroChoose superheroChooseScript = ship.GetComponent<L1SuperheroChoose>();
        currHero = superheroChooseScript.chosenHero;
    }

    private void OnMouseDown()
    {
        if (currHero == 1 && abilityBarTimer.amount == 5)
        {
            Vector3 newPosition = new Vector3(0, 0, 0);
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                newPosition = hit.point;
            }
            laser.SetPosition(0, laser.transform.position);
            laser.SetPosition(1, newPosition);
            abilityBarTimer.amount = 0;
            Invoke("destroyTarget", 0.2f);
        }
    }

    void destroyTarget()
    {
        explode(transform.position);
        Destroy(this.gameObject);
        laser.SetPosition(0, laser.transform.position);
        laser.SetPosition(1, laser.transform.position);
    }
}