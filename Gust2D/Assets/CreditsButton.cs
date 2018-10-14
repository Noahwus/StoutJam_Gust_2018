using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsButton : MonoBehaviour {


	public GameObject Credits;
	

	void Start () {
		Vector3 point = transform.position;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "win")
		{
			//Instantiate (Credits, point);	
		}
	}
}
