using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemCtrl : MonoBehaviour
{
	// Use this for initialization

	public float Speed = 4;
	//public float rotSpeed = 120;
	public RawImage logo;
	public GameObject blood;
	public Slider HPStrip;
	public int HP = 10;

	void Start ()
	{
		Time.timeScale = 1;
		HPStrip.value = HPStrip.maxValue; 
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position += transform.forward * Speed * Time.deltaTime;
//		if (Input.GetKey (KeyCode.A)) {
//			transform.Rotate (Vector3.up * -rotSpeed * Time.deltaTime);
//		}
//		if (Input.GetKey (KeyCode.D)) {
//			transform.Rotate (Vector3.up * rotSpeed * Time.deltaTime);
//		}

	}

	void OnTriggerEnter (Collider coll)
	{
		if (coll.tag == "Enemy") {
			Instantiate (blood, transform.position, Quaternion.identity);
			HealthDmg (2);
			logo = logo.GetComponent<RawImage> ();
			logo.color = Color.red;
		}
	}

	void OnTriggerExit (Collider coll)
	{
		if (coll.tag == "Enemy") {
			logo = logo.GetComponent<RawImage> ();
			logo.color = Color.white;
		}
	}

	void HealthDmg (int damage)
	{
		HP -= damage;
		HPStrip.value = HP; 
		if (HP == 0) {
			GameObject.Find ("SceneManager").GetComponent<ExitManager> ().GameOver ();
		}
	}
}


