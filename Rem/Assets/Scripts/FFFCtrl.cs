using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FFFCtrl : MonoBehaviour
{
	public Transform player;
	public float rotSpd;
	public float movSpd = 7.0f;
	public GameObject blood;

	// Use this for initialization
	void Start ()
	{
		player = GameObject.Find ("REM").transform;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 targetDir = player.position - this.transform.position;
		float step = rotSpd * Time.deltaTime;
		Vector3 newDir = Vector3.RotateTowards (transform.forward, targetDir, step, 0.0f);
		transform.rotation = Quaternion.LookRotation (newDir);
		transform.Translate (Vector3.forward * Time.deltaTime * movSpd);
	}

	public void Hurt ()
	{
		Destroy (gameObject);
		Instantiate (blood, transform.position, Quaternion.identity);
	}
}
