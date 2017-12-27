using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RamCtrl : MonoBehaviour
{
	public Transform player;
	public float rotSpd;
	public float movSpd = 6.5f;
	public GameObject magicBall;
	public int count;

	void Start ()
	{
		player = GameObject.Find ("REM").transform;
		InvokeRepeating ("Fire", 0, 0.5f);
	}

	void Update ()
	{
		Vector3 targetDir = transform.position - player.position;
		float step = rotSpd * Time.deltaTime;
		Vector3 newDir = Vector3.RotateTowards (transform.forward, targetDir, step, 0.0f);
		transform.rotation = Quaternion.LookRotation (newDir);
		transform.Translate (Vector3.forward * Time.deltaTime * -movSpd);

	}

	void Fire ()
	{
		GameObject bullet1 = Instantiate (magicBall, this.transform.position + new Vector3 (0, 2, 0), Quaternion.identity) as GameObject;
		GameObject bullet2 = Instantiate (magicBall, this.transform.position + new Vector3 (0, 2, 0), Quaternion.identity) as GameObject;
		GameObject bullet3 = Instantiate (magicBall, this.transform.position + new Vector3 (0, 2, 0), Quaternion.identity) as GameObject;
		bullet1.GetComponent<Rigidbody> ().velocity = (transform.forward + new Vector3 (1, 0, 0)) * -10;
		bullet2.GetComponent<Rigidbody> ().velocity = (transform.forward + new Vector3 (0, 0, 1)) * -10;
		bullet3.GetComponent<Rigidbody> ().velocity = this.transform.forward * -14;
		Destroy (bullet1, 4);
		Destroy (bullet2, 4);
		Destroy (bullet3, 4);
		count++;
		if (count > 5) {
			this.CancelInvoke ();
			count = 0;
		}
	}
}
