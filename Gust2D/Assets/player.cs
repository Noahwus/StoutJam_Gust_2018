using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.z = 1;
		transform.position = pos;
		Quaternion.Euler(new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0));
	}
}
