using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StatDisplay : MonoBehaviour {
    public Objectstats Stats;
    public WeaponSelector SelectedWeapon;
    private Text Stat;
    private string DisplayedValue;
    public  string StatToDisplay;
    private string displayedStat;

    enum StatsToDisplay
    {Healthpoints,
        Armor,
        Weapon}
    
	// Use this for initialization
	void Start () {
        if(StatToDisplay == StatsToDisplay.Healthpoints.ToString())
        {
            DisplayedValue = Stats.Healthpoints.ToString();
            displayedStat = "Healthpoints : ";
        }
        
        if(StatToDisplay == StatsToDisplay.Armor.ToString())
        {
            DisplayedValue = Stats.Armor.ToString();
            displayedStat = "Armor : ";
        }
        if (StatToDisplay == StatsToDisplay.Weapon.ToString())
        {
            DisplayedValue = SelectedWeapon.WeaponName;
            displayedStat = "Weapon : ";
        }
        Stat = GetComponent<Text>();
        
	}
	
	// Update is called once per frame
	void Update () {
        if (StatToDisplay == StatsToDisplay.Healthpoints.ToString())
        {
            DisplayedValue = Stats.Healthpoints.ToString();
            displayedStat = "Healthpoints : ";
        }

        if (StatToDisplay == StatsToDisplay.Armor.ToString())
        {
            DisplayedValue = Stats.Armor.ToString();
            displayedStat = "Armor : ";
        }
        if (StatToDisplay == StatsToDisplay.Weapon.ToString())
        {
            DisplayedValue = SelectedWeapon.WeaponName;
            displayedStat = "Weapon : ";
        }
        Stat.text = displayedStat  + DisplayedValue;
        
	}
}
