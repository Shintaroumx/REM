using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{

	void OnTriggerEnter (Collider coll)
	{
		if (coll.tag == "Enemy") {
			coll.GetComponent<FFFCtrl> ().Hurt ();
			GameObject.Find ("SP").GetComponent<Ultimate> ().count++;
		}
	}
}
