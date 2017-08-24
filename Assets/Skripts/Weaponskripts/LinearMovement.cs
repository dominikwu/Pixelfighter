using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearMovement : MonoBehaviour {
    private WeaponStats Stats; // Referece to Weaponstats
    private Rigidbody   rb;
    // private Collider others;
    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        Stats = GetComponent<WeaponStats>();
        if (Stats.IsAdditionalShot == false)
        {
            transform.parent = null;
        }
        rb.velocity = transform.forward * Stats.speed;
    }
	
	// Update is called once per frame
	void Update ()
    {
        //transform.position = transform.position + (transform.forward * Time.deltaTime * Stats.speed);
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Boundary"))
        {
            Destroy(gameObject);

        }
    }

}
