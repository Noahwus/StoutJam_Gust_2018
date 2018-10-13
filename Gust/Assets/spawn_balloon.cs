using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_balloon : MonoBehaviour {

    public GameObject spawn_test;
    Vector3 mouse_pos;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        //Destroy(gameObject);
        mouse_pos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);

        Debug.Log(mouse_pos);

        Instantiate(spawn_test, new Vector3(-10, -10, 0), Quaternion.identity);

        Debug.Log(mouse_pos);
    }
}
