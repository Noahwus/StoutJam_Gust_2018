using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test_player_win : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter (Collision col)
    {
		int i = SceneManager.GetActiveScene().buildIndex;
		Debug.Log ("Scene Build Index: " + i);
        if (col.gameObject.tag == "win")
        {
			Debug.Log ("I won");
			if (i < SceneManager.sceneCountInBuildSettings-1) {
				Debug.Log ("Can Be Loaded");
				SceneManager.LoadScene(i + 1);
			} else {
				SceneManager.LoadScene(0);
			}

        }
    }

}
