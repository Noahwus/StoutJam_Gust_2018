using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsButton : MonoBehaviour {


	public GameObject Credits;
	//public Sprite []creditS;
	 GameObject creditsInst;
	public Vector3 Placement;


	void Start () {
		Vector3 point = transform.position;	
		//GetComponent<SpriteRenderer>().sprite
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "win")
		{
			//creditsInst = Instantiate(Credits, point);
		}
	}
}
