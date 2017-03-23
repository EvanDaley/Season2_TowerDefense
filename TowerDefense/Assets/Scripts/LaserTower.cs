using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTower : MonoBehaviour {

	public float damage;
	public GameObject attackPrefab;
	public GameObject attackInstance;
	public BasicTargeting basicTargeting;

	void Start () 
	{
		basicTargeting = GetComponent<BasicTargeting> ();
		attackInstance = GameObject.Instantiate (attackPrefab, transform.position, transform.rotation, transform) as GameObject;
		attackInstance.SetActive (false);
	}
	
	void Update ()
	{
		if (basicTargeting.shouldFire)
		{
			if (attackInstance.activeSelf == false)
				attackInstance.SetActive (true);
		} else
		{
			if (attackInstance.activeSelf)
				attackInstance.SetActive (false);
		}
	}
		
}
