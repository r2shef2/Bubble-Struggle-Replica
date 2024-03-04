using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chain : MonoBehaviour 
{

    // Update is called once per frame
    void Update () 
	{
		float speed = GameLogic.Instance.activeRogueStats.chainSpeed;
		transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * speed;
	}
}
