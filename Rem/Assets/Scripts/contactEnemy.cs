using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contactEnemy : MonoBehaviour
{
	//public int Speed;
	public GameObject blood;

	void OnTriggerEnter (Collider other)
	{

		if (other.tag == "Enemy") {
			Destroy (other.gameObject);
			Destroy (this.gameObject);
			Instantiate (blood, transform.position, Quaternion.identity);
		}
	}

}

