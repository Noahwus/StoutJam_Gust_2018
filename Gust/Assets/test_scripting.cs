using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_scripting : MonoBehaviour {

    public float thrust;
    public Rigidbody rb;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody>();
       // transform.Translate(5, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(transform.right);
        rb.AddForce(transform.up);
	}

    void OnMouseDown()
    {
        //Destroy(gameObject);
        rb.Sleep();
    }
}
