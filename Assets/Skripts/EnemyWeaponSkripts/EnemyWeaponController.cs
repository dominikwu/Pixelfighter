using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeaponController : MonoBehaviour {
    public GameObject[] Weapons;        // all possible weapons are attached to this
    public GameObject SelectedWeapon;   
    public Transform[] ShotSpawns;
    public Transform ShotSpawn;
    public EnemyWeaponStats Stats;
    public bool ShotReady;
    public float LeftReloadTime;
    public Dictionary<string, int> WeaponDictionary = new Dictionary<string, int>()
    {
        {"Bolt",0},
        {"ShotGun",1}
    };
	// Use this for initialization
	void Start () {
        ShotReady = true;
        SelectedWeapon = Weapons[0];
        ShotSpawn = ShotSpawns[0];
        Stats = SelectedWeapon.GetComponent<EnemyWeaponStats>();
	}
	
	// Update is called once per frame
	void Update () {
		if(ShotReady == false)
        {
            LeftReloadTime -= Time.deltaTime;
            if(LeftReloadTime <= 0)
            {
                ShotReady = true;
            }
        }
	}

    public void SelectWeapon(string Name)
    {
        SelectedWeapon = Weapons[WeaponDictionary[Name]];
        ShotSpawn = ShotSpawns[0];
        Stats = SelectedWeapon.GetComponent<EnemyWeaponStats>();
    }
}
