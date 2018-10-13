using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_balloon : MonoBehaviour
{
    public GameObject balloon;
    public float coolDownTime = .7f;
    public float timeStamp = 0.0f;
    public float timeTilBoom = 3.0f;
   
    // Update is called once per frame
    void Update()
    {
		Vector3 spawnPosition = -Vector3.one;

		if (Input.GetMouseButtonDown (0)) {
            if (timeStamp <= Time.time)
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                timeStamp = Time.time + coolDownTime;

                if (Physics.Raycast(ray, out hit))
                {
                    spawnPosition = hit.point;

                    spawnPosition.Set(spawnPosition.x, spawnPosition.y, 1);
                    GameObject objectInstance = Instantiate(balloon, spawnPosition, Quaternion.identity);
                    Quaternion.Euler(new Vector3(0, 0, 0));

                    Debug.Log(spawnPosition);
                    Destroy(objectInstance, timeTilBoom);
                }

            }
            /*Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit)) {
				spawnPosition = hit.point;

				spawnPosition.Set(spawnPosition.x, spawnPosition.y, 1);
				GameObject objectInstance = Instantiate (balloon, spawnPosition, Quaternion.identity);
				Quaternion.Euler(new Vector3(0, 0, 0));

				Debug.Log (spawnPosition);
			}*/


        }
    }
}
