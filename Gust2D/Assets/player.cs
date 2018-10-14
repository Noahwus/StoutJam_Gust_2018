using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		pos.z = 1;
		transform.position = pos;

//		{
//			Vector3 targetPosition = Camera.main.gameObject.transform.position;
//			transform.LookAt (targetPosition);
//		}

		Quaternion.Euler(new Vector3(0, 0, transform.eulerAngles.z));
	}
}
