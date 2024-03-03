using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
	public Chain chain;

	// Update is called once per frame
	void Update()
	{

		if (Input.GetKeyDown("space"))
		{
			Instantiate(chain, this.transform.position, Quaternion.identity);
		}
	}
}