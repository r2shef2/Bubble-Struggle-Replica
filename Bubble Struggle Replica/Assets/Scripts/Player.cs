using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public Rigidbody2D rb;

	public Joystick joystick;

	public int lives;

	private float movement = 0f;

	public float upwardHitOnLife = 7f;

	// Update is called once per frame
	void Update () {
		float inputForce = joystick.Horizontal;
#if UNITY_EDITOR
		if(inputForce == 0)
        {
			inputForce = Input.GetAxis("Horizontal");
        }
#endif
		movement = inputForce * GameLogic.Instance.activeRogueStats.playerSpeed;
	}

	void FixedUpdate ()
	{
		rb.MovePosition(rb.position + new Vector2 (movement * Time.fixedDeltaTime, 0f));
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.transform.GetComponent<Ball>() != null)
		{
			col.transform.GetComponent<Ball>().Split(upwardHitOnLife);

			lives--;
			if(lives == 0)
            {
				Debug.Log("GAME OVER!");
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			}
		}
	}

}
