using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStats : MonoBehaviour {
    public bool IsAdditionalShot; // flag for a weapon which uses multiple shots (can be ignored)
    public float Damage;        // the damage the weapon does
    public float speed;         // the Speed with what the Bullets are flying
    public float ReloadTime;    // reloadtime for a weapon(needs to be assigned to the parent if multiple shoots are used)
    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
       
    }

    
}
