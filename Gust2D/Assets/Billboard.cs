using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour {

	GameObject target;

	// Use this for initialization
	void Start() {
		
	}

	// Update is called once per frame
	void Update () {

		Vector3 targetPosition = Camera.main.gameObject.transform.position;

		transform.LookAt (targetPosition);
	}
}
