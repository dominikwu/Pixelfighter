using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootingEasy : MonoBehaviour {
    
    private EnemyWeaponController WeaponController;
    private WeaponStats WeaponStats;
    private Objectstats Stats;
    private int WeaponSwitchTimer = 0;
	// Use this for initialization
	void Start () {
        
        WeaponController = GetComponent<EnemyWeaponController>();
        Stats = GetComponent<Objectstats>();
	}
	
	// Update is called once per frame
	void Update () {
        if (WeaponController.ShotReady)
        {
            Instantiate(WeaponController.SelectedWeapon, WeaponController.ShotSpawn.position,  WeaponController.ShotSpawn.rotation);
            WeaponController.LeftReloadTime = WeaponController.Stats.ReloadTime;
            WeaponController.ShotReady = false;
            WeaponSwitchTimer++;
            if(WeaponSwitchTimer == 5)
            {
                WeaponController.SelectWeapon("ShotGun");
            }
            if (WeaponSwitchTimer == 20)
            {
                WeaponController.SelectWeapon("Bolt");
                WeaponSwitchTimer = 0;
            }
        }
        
    }
}
