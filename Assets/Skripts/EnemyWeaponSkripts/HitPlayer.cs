using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlayer : MonoBehaviour {
    private EnemyWeaponStats Stats;      // Reference to the Stats of a Weapon
    private PlayerController UnitHit; // Reference to the Unit that got Hit

	// Use this for initialization
	void Start () {
        Stats = GetComponent<EnemyWeaponStats>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if((UnitHit = other.GetComponent<PlayerController>())!= null)
        {
            UnitHit.TakeDamage(Stats.Damage);
            Destroy(gameObject);
        }
    }
}
