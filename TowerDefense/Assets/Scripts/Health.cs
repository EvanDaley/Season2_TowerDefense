using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public float health;

	public void TakeDamage(float amount)
	{
		health -= amount;

		if (health < 1)
			Die ();
	}

	public void Die()
	{
		//Destroy (gameObject);
		gameObject.SetActive(false);
	}
}
