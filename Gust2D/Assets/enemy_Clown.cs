using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Clown : MonoBehaviour {

    public float move_speed = 2.0f;
    public int furtherest_right = 20;
    public int furtherest_left = 16;
    public bool move_right = true;

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

    void OnTriggerEnter(Collider other)
    {
        int i = Application.loadedLevel;
        Application.LoadLevel(i);
    }

}
