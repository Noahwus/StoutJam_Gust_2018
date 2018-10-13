﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloon_pop : MonoBehaviour
{

    public GameObject balloon;
    public float power = 1500.0f;
    public float radius = 50.0f;
    public float upforce = 500.0f;

	int delay = 2;

    void FixedUpdate()
    {
        if (balloon == enabled)
        {
            Invoke("Pop", 1);
        }
    }

    void Pop()
    {
        Vector3 popPosition = balloon.transform.position;
        Collider[] colliders = Physics.OverlapSphere(popPosition, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce(power, popPosition, radius, upforce, ForceMode.Impulse);
				Destroy (balloon);
            }
        }
    }
}