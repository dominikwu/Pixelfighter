using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementEasy : MonoBehaviour {
    private Objectstats Stats;

   
    private Vector3 PlayerDirection;
    private UnitController Controller;
    //private Ray RayToPlayer;
    //private RaycastHit RayHitPlayerFound;
	// Use this for initialization
	void Awake () {
        
        Stats = GetComponent<Objectstats>();
       
        Controller = GetComponent<UnitController>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
        
            PlayerDirection = Controller.Player.transform.position - transform.position;
            Controller.rb.rotation = Quaternion.LookRotation(PlayerDirection);
            Controller.rb.velocity = transform.forward.normalized * Time.deltaTime * Stats.speed ;
        
        
	}
}
