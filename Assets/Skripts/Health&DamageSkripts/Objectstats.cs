using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objectstats : MonoBehaviour {
    //Contains all the Stats an Object can Have
    private Object[] StopEnemys;
    public float Healthpoints;
    public float Armor;
    public float speed;
    private bool IsPlayer = false;

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
        Healthpoints -= Mathf.Max(0,Damage - Armor);
        if(Healthpoints <=0)
        {
            if(CompareTag("Player"))
            {
                Destroy(gameObject);
            }
            else
            {
                Destroy(gameObject, 10f);
                gameObject.SetActive(false);
            }
      
            
            
        }
    }
    public void OnDestroy()
    {
        if(!IsPlayer)
        {
            EnemySpawns.EnemyCount--;
        }
        
       
    }
}
