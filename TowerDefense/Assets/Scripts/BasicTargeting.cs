using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTargeting : MonoBehaviour {

	public float range = 8f;
	public float rotationSpeed = 110f;
	public Transform target;
	public bool shouldFire;

	void Update () 
	{
		float distance = Vector3.Distance (transform.position, target.position);

		if (distance <= range)
		{
			Vector3 direction = target.position - transform.position;
			Quaternion desiredRotation = Quaternion.LookRotation (direction, Vector3.up);
			transform.rotation = Quaternion.RotateTowards (transform.rotation, desiredRotation, rotationSpeed * Time.deltaTime);
			shouldFire = true;
		} else
		{
			shouldFire = false;
		}
	
	}
}
