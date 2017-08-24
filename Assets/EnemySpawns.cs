using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawns : MonoBehaviour {
    public GameObject[] EnemytoSpawn;
    public int EnemyCountMax;
    public static int EnemyCount = 0;
	// Use this for initialization
	void Start () {
		
	}
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Game", LoadSceneMode.Single);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    // Update is called once per frame
    void LateUpdate () {
        if (EnemyCount < EnemyCountMax && Time.timeSinceLevelLoad > 3)
        {
            Instantiate(EnemytoSpawn[0], new Vector3(Random.Range(-30, 30), 1, Random.Range(-30, 30)), Quaternion.Euler(0, 0, 0));
        }
    }

    public void SpawnNewEnemy()
    {
        
    }
}
