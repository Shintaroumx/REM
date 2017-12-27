using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

	// Use this for initialization
	public float lifeTime = 2.0f;

	void Start ()
	{
		Destroy (gameObject, lifeTime);
	}

}
