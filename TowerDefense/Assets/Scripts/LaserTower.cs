using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTower : MonoBehaviour {

	public float damage;
	public GameObject attackPrefab;
	public BasicTargeting basicTargeting;

	void Start () 
	{
		basicTargeting = GetComponent<BasicTargeting> ();
	}
	
	void Update ()
	{
		if (basicTargeting.shouldFire)
		{
			print ("Should fire");
		}
	}
}
