using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextAnim : MonoBehaviour
{

	public AnimationCurve ac;
	public float playSpeed = 1.0f;
	float timeOffset = 0.0f;
	Vector3 sca;
	// Use this for initialization
	void Start ()
	{
		sca = transform.localScale;
		timeOffset = Random.value;
	}
	
	// Update is called once per frame
	void Update ()
	{
		timeOffset += Time.deltaTime;
		float tens = ac.Evaluate (timeOffset * playSpeed);
		transform.localScale = new Vector3 (sca.x * tens, sca.y * tens, sca.z);
	}
}
