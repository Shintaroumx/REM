using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skill : MonoBehaviour
{
	public Image icon;
	public float coolDown = 10.0f;
	public GameObject speedLine;

	private float currentCoolDown;
	private Button skillButton;

	void Start ()
	{
		this.skillButton = this.GetComponent<Button> ();
		skillButton.onClick.AddListener (() => this.RemSkill ());
		currentCoolDown = coolDown;
	}

	void Update ()
	{
		if (currentCoolDown < coolDown) {
			currentCoolDown += Time.deltaTime;
			this.icon.fillAmount = currentCoolDown / coolDown;
		}
	}

	public void RemSkill ()
	{
		if (currentCoolDown >= coolDown) {
			//Debug.LogFormat ("使用 【{0}】", skillName);
			GameObject.Find ("REM").GetComponent<RemCtrl> ().Speed += 6;
			speedLine.SetActive (true);
			Invoke ("SpeedDown", 3.0f);
			currentCoolDown = 0;
		}
	}

	void SpeedDown ()
	{
		GameObject.Find ("REM").GetComponent<RemCtrl> ().Speed -= 6;
		speedLine.SetActive (false);
	}
}
