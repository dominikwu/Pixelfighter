using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartText : MonoBehaviour {
    private GameObject Player;
    private GameObject[] Enemys;
    private Text text;
    private float RestartTimer = 0;
    
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        Player = GameObject.FindGameObjectWithTag("Player");
        text.text = "";
	}
	
	// Update is called once per frame
	void Update () {
        if (Player == null)
        {
            RestartTimer -= Time.deltaTime;
            if (RestartTimer <= 0)
            {
                text.text = "You died, press 'R' to Restart";
                text.fontSize = 40;
                Enemys = GameObject.FindGameObjectsWithTag("Enemy");
                for (int i = 0; i < Enemys.Length; i++)
                {
                    Enemys[i].SetActive(false);
                }
            }
        }

	}
}
