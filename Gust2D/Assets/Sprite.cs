using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite : MonoBehaviour {
	public GameObject Cap;
	void FixedUpdate(){

		Vector3 pos = Cap.transform.position;

		pos.z = pos.z;
		//pos.y = Cap.transform.position.y;
		transform.position = pos;

		//		{
		//			Vector3 targetPosition = Camera.main.gameObject.transform.position;
		//			transform.LookAt (targetPosition);
		//		}

		Quaternion.Euler (new Vector3 (0, 0, transform.eulerAngles.z));
	}
}
