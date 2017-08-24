using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownScreen : MonoBehaviour {
    private Text CountDownText;
	// Use this for initialization
	void Start () {
        CountDownText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.timeSinceLevelLoad <= 1)
        {
            CountDownText.fontSize = (int)Mathf.Lerp((int)80, (int)10, Time.timeSinceLevelLoad);
            CountDownText.text = "3";
        }
        if (Time.timeSinceLevelLoad <= 2 && Time.timeSinceLevelLoad > 1)
        {
            CountDownText.fontSize = (int)Mathf.Lerp((int)80, (int)10, Time.timeSinceLevelLoad - 1);
            CountDownText.text = "2";
        }
        if (Time.timeSinceLevelLoad <= 3 && Time.timeSinceLevelLoad > 2)
        {
            CountDownText.fontSize = (int)Mathf.Lerp((int)80, (int)10, Time.timeSinceLevelLoad - 2);
            CountDownText.text = "1";
        }
        if (Time.timeSinceLevelLoad > 3)
        {
            gameObject.SetActive(false);
        }
    }
}
