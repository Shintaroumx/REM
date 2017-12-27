using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelManager : MonoBehaviour
{

	static public levelManager lm;
	public Transform player;
	public GameObject enemy;
	public Text Level;

	public float rateTime = 1.8f;

	private float countTime;
	private float totalTime;
	private int level = 0;

	void Awake ()
	{
		lm = this;
	}


	void Update ()
	{
		countTime += Time.deltaTime;
		totalTime += Time.deltaTime;

		Level.GetComponent<Text> ().text = "Lv." + level.ToString ();

		if (countTime > rateTime) {
			Vector2 r = Random.insideUnitCircle.normalized * 30;
			Instantiate (enemy, player.position + new Vector3 (r.x, 0, r.y), Quaternion.Euler (new Vector3 (0, Random.Range (0.0f, 360.0f), 0)));
			countTime -= rateTime;
		}
		if (rateTime > 0) {
			if ((int)totalTime % 10 == 0) {
				rateTime -= 0.1f;
				level++;
				GameObject.Find ("REM").GetComponent<RemCtrl> ().HPStrip.value = 10;
				GameObject.Find ("REM").GetComponent<RemCtrl> ().HP = 10;
				totalTime += 1;
			}
		}
	}
}
