using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 pos = this.transform.position;
		pos.y = pos.y / 2;
		Vector3 cpos = Camera.main.transform.position;
		cpos.x = pos.x;
		Camera.main.transform.position = cpos;
		Camera.main.transform.LookAt (pos);
	}
}
