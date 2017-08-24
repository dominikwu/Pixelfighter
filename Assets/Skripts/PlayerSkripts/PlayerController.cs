using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Objectstats Stats;
    // Use this for initialization
    void Start () {
        Stats = GetComponent<Objectstats>();
    }
	
	// Update is called once per frame
	void Update () {
       
    }
    public void TakeDamage(float Damage)
    {
        Stats.Damagetaken(Damage);
    }
}
