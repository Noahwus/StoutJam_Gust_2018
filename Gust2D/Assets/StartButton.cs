using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour {

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
			Debug.Log("start Game");
			int i = Application.loadedLevel;
			Application.LoadLevel(i + 1);
		}
	}

}
