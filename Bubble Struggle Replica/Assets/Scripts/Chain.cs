using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour {

	public Transform player;

	public float speed = 2f;

	// Update is called once per frame
	void Update () 
	{	
		transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * speed;
	}
}
