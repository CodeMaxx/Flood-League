using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject boat;
    public Vector3 offset;
    
	void Start () {
        transform.position = boat.transform.position + offset;
	}
	
	void LateUpdate () {
        transform.position = boat.transform.position + offset;
	}
}
