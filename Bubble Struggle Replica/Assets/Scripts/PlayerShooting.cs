using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
	public Chain chain;

	public Transform chainParent;

	private GameLogic gameLogic;

    private void Start()
    {
		gameLogic = GameLogic.Instance;
    }

    // Update is called once per frame
    void Update()
	{
		// Check input
		if (Input.GetKeyDown("space"))
		{
			// Check number of shots
			if(gameLogic.activeNumberOfChains < gameLogic.activeRogueStats.maxChainShots)
            {
				Chain newChain = Instantiate(chain, this.transform.position, Quaternion.identity);
				newChain.transform.parent = chainParent;
				GameLogic.Instance.activeNumberOfChains++;
			}
		}
	}
}