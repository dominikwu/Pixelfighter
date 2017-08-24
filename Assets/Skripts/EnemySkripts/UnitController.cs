using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour {

    /* Controlls the behaviour and the Stats of an Object and has References to all possible skripts */
    public GameObject Player; // Reference to the Player to chase him
    private Objectstats                     Stats;  // Reference to the stats this enemy has
    private EnemyMovementEasy               MovementEasy;// different skripts for moving and shooting
    private EnemyMovementMedium             MovementMedium;
    private EnemyMovementHard               MovementHard;
    private EnemyShootingEasy               ShootingEasy;
    private EnemyShootingMedium             ShootingMedium;
    private EnemyShootingHard               ShootingHard;
    public  Rigidbody                       rb;
    private bool GameFinished;          // disable movement and  shooting when the player is dead
	// All Components get initialized
	void Awake () {
        Player = GameObject.FindGameObjectWithTag("Player");    // identify the player to chase
        EnemySpawns.EnemyCount++;           // increase the global enemycount by 1
        Stats           = GetComponent<Objectstats>();
        rb              = GetComponent<Rigidbody>();

        MovementEasy    = GetComponent<EnemyMovementEasy>();
        //MovementMedium  = GetComponent<EnemyMovementMedium>();
       // MovementHard    = GetComponent<EnemyMovementHard>();
        ShootingEasy    = GetComponent<EnemyShootingEasy>();
        //ShootingMedium  = GetComponent<EnemyShootingMedium>();
       // ShootingHard    = GetComponent<EnemyShootingHard>();

        //ShootingMedium.enabled = false;
        //ShootingHard.enabled = false;
        //MovementMedium.enabled = false;
        //MovementHard.enabled = false;
    }
	
	// No Updates
	void Update ()
    {
        if(Player == null&& !GameFinished)// disable all skripts when the player is dead and set game to finished
        {
            DisableAllSkripts();
            rb.velocity = new Vector3(0f, 0f, 0f);
            rb.rotation = Quaternion.Euler(0f, rb.rotation.y, 0f);
            GameFinished = true;
        }

        if (Stats.Healthpoints < 5) // different skripts when HP falls below some point
        {
            
            rb.velocity = new Vector3(0, 0, 0);
           // ChangeMovementSkript("Medium");

        }
    }

    //Registers the Incoming Damage and gives the Data to the Stats where they are handled and the stats are changed
    public void TakeDamage(float Damage)
    {
        Stats.Damagetaken(Damage);
    }
    public void ChangeShootingSkript(string NewSkript)
    {
        if(NewSkript == "Easy")
        {
            ShootingEasy.enabled = true;
            ShootingMedium.enabled = false;
            ShootingHard.enabled = false;
           
        }
        if (NewSkript == "Medium")
        {
            ShootingEasy.enabled = false;
            ShootingMedium.enabled = true;
            ShootingHard.enabled = false;

        }
        if (NewSkript == "Hard")
        {
            ShootingEasy.enabled = false;
            ShootingMedium.enabled = false;
            ShootingHard.enabled = true;

        }
    }


    public void ChangeMovementSkript(string NewSkript)
    {
        if (NewSkript == "Easy")
        {
            MovementEasy.enabled = true;
            MovementMedium.enabled = false;
            MovementHard.enabled = false;

        }
        if (NewSkript == "Medium")
        {
            MovementEasy.enabled = false;
            MovementMedium.enabled = true;
            MovementHard.enabled = false;

        }
        if (NewSkript == "Hard")
        {
            MovementEasy.enabled = false;
            MovementMedium.enabled = false;
            MovementHard.enabled = true;

        }
    }

    public void DisableAllSkripts()
    {
        MovementEasy.enabled = false;
        //MovementMedium.enabled = false;
        //MovementHard.enabled = false;
        ShootingEasy.enabled = false;
       // ShootingMedium.enabled = false;
        //ShootingHard.enabled = false;
    }
}
