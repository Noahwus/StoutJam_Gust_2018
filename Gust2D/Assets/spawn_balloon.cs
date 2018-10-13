using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_balloon : MonoBehaviour
{
    public GameObject balloon;
   
    // Update is called once per frame
    void Update()
    {
		Vector3 spawnPosition = -Vector3.one;

		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit)) {
				spawnPosition = hit.point;

				spawnPosition.Set(spawnPosition.x, spawnPosition.y, 1);
				GameObject objectInstance = Instantiate (balloon, spawnPosition, Quaternion.identity);
				Quaternion.Euler(new Vector3(0, 0, 0));

				Debug.Log (spawn);
			}
				

		}
    }
}
