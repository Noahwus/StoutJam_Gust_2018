﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_player_win : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "win")
        {
            Debug.Log("I won");
            int i = Application.loadedLevel;
            Application.LoadLevel(i);
        }
    }

}
