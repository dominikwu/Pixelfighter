using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectstats : MonoBehaviour {
    //Contains all the Stats an Object can Have
    private Object[] StopEnemys;
    public float Healthpoints;      // Healthpoints of the Object
    public float Armor;             // Armor of the Object
    public float speed;             // Speed of the Object with which it can move    
    private bool IsPlayer = false;  // Check if the Object is a Player

	// Use this for initialization
	void Start () {
		if(CompareTag("Player"))
        {
            IsPlayer = true;
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    //The Damage taken is handled
    public void Damagetaken(float Damage)
    {
        Healthpoints -= Mathf.Max(0,Damage - Armor); // Reduce Healthpoints when hit (clamp to not increase HP if armor is > than Damage
        if(Healthpoints <=0)
        {
            if(CompareTag("Player"))    // Players get destroyed immediately
            {
                Destroy(gameObject);
            }
            else
            {
                Destroy(gameObject, 10f); // Enemys get destoryed after 10 seconds and are disabled immediately( this is to make the enemys not to respawn immediately)
                gameObject.SetActive(false);
            }
      
            
            
        }
    }
    public void OnDestroy()
    {
        if(!IsPlayer)
        {
            EnemySpawns.EnemyCount--;       // reduce global enemycount by 1 if this enemy is destroyed and is no player
        }
        
       
    }
}
