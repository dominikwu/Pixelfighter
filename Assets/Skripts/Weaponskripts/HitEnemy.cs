using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEnemy : MonoBehaviour {
    private WeaponStats Stats;      // Reference to the Stats of a Weapon
    private UnitController UnitHit; // Reference to the Unit that got Hit

	// Use this for initialization
	void Start () {
        Stats = GetComponent<WeaponStats>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if((UnitHit = other.GetComponent<UnitController>())!= null)
        {
            UnitHit.TakeDamage(Stats.Damage);
            Destroy(gameObject);
        }
    }
}
