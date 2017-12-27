using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
	public GameObject Start;
	public GameObject Intro;
	public GameObject How;


	//	void Awake ()
	//	{
	//		Application.targetFrameRate = 60;
	//	}
	//
	public void LoadtoIntro ()
	{
		Start.SetActive (false);
		Intro.SetActive (true);
	}

	public void LoadtoHow ()
	{
		Intro.SetActive (false);
		How.SetActive (true);
	}

	public void LoadtoGame ()
	{
		Application.LoadLevel ("Rem");
	}

	public void Exit ()
	{
		Application.Quit ();
	}

	public void Reload ()
	{
		Application.LoadLevel ("Rem");
	}

	public void LoadtoMenu ()
	{
		Application.LoadLevel ("RemUI");
	}
	// Update is called once per frame

}
