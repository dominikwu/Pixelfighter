using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLinearMovement : MonoBehaviour {
    private EnemyWeaponStats Stats; // Referece to Weaponstats
    private Rigidbody   rb;
    // private Collider others;
    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        Stats = GetComponent<EnemyWeaponStats>();
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
