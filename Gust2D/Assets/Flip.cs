using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour {

	public GameObject Capsule;

	Vector3 prev;
	public bool fliped = false;

	void Update () {
		Vector3 curr = Capsule.transform.position;
		Vector3 temp = transform.localScale;

		if (prev.x < curr.x) {
			temp.x *= 1f;
			fliped = false;
		} else if(!fliped) {
			temp.x *= -1f;
			fliped = true;
		}

		transform.localScale = temp;

		prev = curr;
	}
}
