using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramovement : MonoBehaviour {

    public GameObject player;
    Vector3 lerptoposition;
    Vector3 startposition;
    float zoom;
    public float lerptime;
	// Use this for initialization
	void Start () {
        startposition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        zoom = Input.GetAxis("Mouse ScrollWheel")*-10;
        startposition.y += zoom;
        transform.position = player.transform.position + startposition;// Vector3.Lerp(transform.position, , Time.deltaTime*lerptime);
	}
}
