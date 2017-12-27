using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitManager : MonoBehaviour
{
	public GameObject player;
	public GameObject panel;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}
		if (player.transform.position.y < -2) {
			GameOver ();
		}
	}

	public void GameOver ()
	{
		Time.timeScale = 0;
		panel.SetActive (true);
	}
}
