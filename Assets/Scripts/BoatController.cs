using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoatController : MonoBehaviour {
    public float speed = 4;
    public float turn = 4;
    public float minimumSpeed = 0.5f;
    public float damage = 25;

    public GameObject healthBar;

    float max_health = 100f;
    float cur_health = 100f;

    private Rigidbody rb;

	void Start () {
        rb = GetComponent<Rigidbody>();
        setHealthBar();
	}

    private void Update () {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        if(moveVertical < minimumSpeed) {
            moveVertical = minimumSpeed;
        }

        rb.velocity = new Vector3 (moveHorizontal*turn, 0, moveVertical*speed);
        rb.rotation = Quaternion.Euler(new Vector3(0, 0, moveHorizontal * -1 * turn));
        rb.position = new Vector3(rb.position.x, 0, rb.position.z);
        setHealthBar();
    }

    public void setHealthBar()
    {
        ApplicationModel.currentHealth = Mathf.RoundToInt(cur_health);
        float health = cur_health / max_health;
        healthBar.transform.localScale = new Vector3(Mathf.Clamp(health, 0f, 1f), healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }

    void OnCollisionEnter(Collision col) {
        if(col.gameObject.CompareTag("Obstacle")) {
            Debug.Log("Collision with object");
            cur_health -= damage;

            if(cur_health <= 0) {
                Debug.Log("Health = 0");
                SceneManager.LoadScene("Game Over");
            }
            float force = 80f;
            Vector3 dir = col.contacts[0].point - transform.position;
            dir = -dir.normalized;
            rb.AddForce(dir*force, ForceMode.Impulse);
        }
    }

}
