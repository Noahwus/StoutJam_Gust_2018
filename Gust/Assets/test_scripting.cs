﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_scripting : MonoBehaviour {

    public GameObject spawn_test;

    public float thrust;
    public Rigidbody rb;
    Vector3 mouse_pos;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();
        //transform.Translate(5, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(transform.right);
        rb.AddForce(transform.up);
	}

    void OnMouseDown()
    {
        //Destroy(gameObject);
        mouse_pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);

        Instantiate(spawn_test, mouse_pos, Quaternion.identity);

        Debug.Log(mouse_pos);
    }
}