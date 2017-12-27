using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ultimate : MonoBehaviour
{
	public Image icon;
	public float coolDown = 10.0f;
	public GameObject Ram;
	public GameObject player;
	public float count;
	public GameObject textAnim;
	public GameObject Effect;

	private Button skillButton;
	private GameObject assist;

	// Use this for initialization
	void Start ()
	{
		this.skillButton = this.GetComponent<Button> ();
		skillButton.onClick.AddListener (() => this.UltimateSkill ());
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (count <= 10) {
			this.icon.fillAmount = count / coolDown;
		}
		if (count >= coolDown) {
			textAnim.SetActive (true);
		}
	}

	public void UltimateSkill ()
	{
		if (count >= coolDown) {
			assist = Instantiate (Ram, player.transform.position + new Vector3 (2, 0, 0), Quaternion.identity)as GameObject;
			Instantiate (Effect, assist.transform.position, Quaternion.identity);
			textAnim.SetActive (false);
			count = 0;
			Destroy (assist, 5.0f);
			//Invoke ("UltimateOver", 5.0f);
		}
	}
}
