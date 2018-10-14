using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public bool LookAt = true;

	public float smoothSpeed = .08f;
	public Vector3 offset;

	void FixedUpdate(){
		Vector3 desPos = target.position + offset;

		Vector3 pos = Vector3.Lerp (transform.position, desPos, smoothSpeed);
		pos.z = -10;
		transform.position = pos;
		if (LookAt) {
			transform.LookAt (target);
		}
	}
}
