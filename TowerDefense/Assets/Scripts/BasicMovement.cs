using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicMovement : MonoBehaviour {

	public NavMeshAgent navMeshAgent;
	public Transform moveTarget;

	void Start () 
	{
		navMeshAgent.destination = moveTarget.position;
	}
	
	void Update () 
	{
		
	}
}
