using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSelector : MonoBehaviour {
    //Skript to Handle the Different Weapons and change them if necessary

    public GameObject[] Weapon;                 // List with all possible Weapons
    private GameObject WeaponSelected;          // Current equipped Weapon
    private WeaponStats WeaponStats;            //Stats of the current equipped Weapon
    public Transform[] ShotSpawns;              // List of all possible spawnpoints for Bullets and other Weapons
    private Transform ShotSpawn;                // Spawnpoint of the Current equipped Weapon
    private float NextShotReady;                // Timer until the next shot is ready
    private int WeaponNumber;                   // Int Variable to specify the equipped Weapon     
    public string WeaponName;

    public Dictionary<int, string> WeaponDictionary = new Dictionary<int, string>()
    {
        {0,"Bolt" },
        {1,"ShotGun" },
        {2,"Sniper" }
    };
     // Names of all possible Guns
    public enum WeaponNames
    {
    Bolt,
    ShotGun,
    TestGun
    };
	// Use this for initialization
	void Start () {
        
        NextShotReady = 0f;
        ShotSpawn = ShotSpawns[0];
        WeaponSelected = Weapon[1];
        WeaponStats = WeaponSelected.GetComponent<WeaponStats>();
        WeaponNumber = 1;
        WeaponName ="ShotGun";
    }
	
	// Update is called once per frame
	void Update ()
    {
#region Fire Weapon
        //Function to Fire Weapons
        if (Input.GetButton("Fire1") && (NextShotReady <= 0f))
        {   
            Instantiate(WeaponSelected, ShotSpawn.position, ShotSpawn.rotation);
            NextShotReady = WeaponStats.ReloadTime;
        }
        NextShotReady -= Time.deltaTime;
        #endregion
        if (Input.GetKeyDown(KeyCode.Keypad1) || Input.GetKeyDown(KeyCode.Alpha1))
        {
            WeaponNumber = 0;
            SetWeapon(WeaponNumber);
            
        }
        if (Input.GetKeyDown(KeyCode.Keypad2)||Input.GetKeyDown(KeyCode.Alpha2))
        {
            WeaponNumber = 1;
            SetWeapon(WeaponNumber);
           
        }
        if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            WeaponNumber = 2;
            SetWeapon(WeaponNumber);

        }

        if (Input.GetAxis("Mouse ScrollWheel") == 1)
        {
            SwitchToNextWeapon(1);
        }

        if (Input.GetAxis("Mouse ScrollWheel") == -1)
        {
            SwitchToNextWeapon(-1);
        }

    }
#region SetWeapon with Buttons
    //Function to switch the Weapons (Button Clicked)
    public void SetWeapon(string NewWeapon)
    {
        if (WeaponNames.Bolt.ToString().Equals(NewWeapon))
        {
            WeaponNumber = 0;
            WeaponName = NewWeapon;
        }
        if (WeaponNames.ShotGun.ToString().Equals(NewWeapon))
        {
            WeaponNumber = 1;
            WeaponName = NewWeapon;
        }
        if (WeaponNames.ShotGun.ToString().Equals(NewWeapon))
        {
            WeaponNumber = 2;
            WeaponName = NewWeapon;
        }

        //ShotSpawn = ShotSpawns[WeaponNumber];
        WeaponSelected = Weapon[WeaponNumber];
        WeaponStats = WeaponSelected.GetComponent<WeaponStats>();
    }
    #endregion

#region SetWeapon with KeyBoard
    //Function to switch the Weapons (Button pressed on KeyBoard)
    public void SetWeapon(int NewWeapon)
    {

        //ShotSpawn = ShotSpawns[WeaponNumber];
        WeaponName = WeaponDictionary[NewWeapon];
        WeaponSelected = Weapon[WeaponNumber];
        WeaponStats = WeaponSelected.GetComponent<WeaponStats>();
    }
#endregion

    public void SwitchToNextWeapon(int next)
    {
       
        WeaponNumber += next;
        Mathf.Clamp(WeaponNumber, 0, WeaponDictionary.Count);
        WeaponSelected = Weapon[WeaponNumber];
        WeaponName = WeaponDictionary[WeaponNumber];
        WeaponStats = WeaponSelected.GetComponent<WeaponStats>();
    }
}
