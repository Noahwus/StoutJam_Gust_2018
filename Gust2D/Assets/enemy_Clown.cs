﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Clown : MonoBehaviour {

    public float move_speed = 2.0f;
    public float furtherest_right = 20f;
    public float furtherest_left = 16f;
    public bool move_right = true;
	public bool canKill = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (move_right)
        {
            transform.Translate(Vector2.right * move_speed * Time.deltaTime);
            if (transform.position.x >= furtherest_right)
            {
                move_right = false;
            }

        }
        else if (!move_right)
        {
            transform.Translate(-Vector2.right * move_speed * Time.deltaTime);
            if (transform.position.x <= furtherest_left)
            {
                move_right = true;
            }
        }

    }

    void OnCollisionEnter(Collision col)
    {
		if (col.gameObject.tag == "win" && canKill)
        {
            //Debug.Log("I was attacked by a clown!");
            int i = Application.loadedLevel;
            Application.LoadLevel(i);
        }
    }

}
