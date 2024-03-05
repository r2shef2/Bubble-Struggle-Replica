using UnityEngine;

public class Ball : MonoBehaviour {

	public Vector2 startForce;

	public GameObject nextBall;

	public Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb.AddForce(startForce, ForceMode2D.Impulse);
	}

	public void Split (float upwardsVelocity = 4)
	{
		if (nextBall != null)
		{
			GameObject ball1 = Instantiate(nextBall, rb.position + Vector2.right / 4f, Quaternion.identity);
			GameObject ball2 = Instantiate(nextBall, rb.position + Vector2.left / 4f, Quaternion.identity);

			ball1.transform.parent = this.transform.parent;
			ball2.transform.parent = this.transform.parent;

			ball1.GetComponent<Ball>().startForce = new Vector2(2f, upwardsVelocity);
			ball2.GetComponent<Ball>().startForce = new Vector2(-2f, upwardsVelocity);
		}

		Destroy(gameObject);
	}

}
