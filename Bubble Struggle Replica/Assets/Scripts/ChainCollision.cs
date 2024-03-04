using UnityEngine;

public class ChainCollision : MonoBehaviour {

	public Chain chain;

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Ball")
		{
			col.GetComponent<Ball>().Split();
		}

		// remove from active number of chains
		GameLogic.Instance.activeNumberOfChains--;
		Destroy(chain.gameObject);
	}

}
