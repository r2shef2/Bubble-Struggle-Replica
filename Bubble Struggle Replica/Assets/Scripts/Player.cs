using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public float speed = 4f;

	public Rigidbody2D rb;

	public Joystick joystick;

	private float movement = 0f;

	// Update is called once per frame
	void Update () {
		float inputForce = joystick.Horizontal;
		movement = inputForce * speed;
	}

	void FixedUpdate ()
	{
		rb.MovePosition(rb.position + new Vector2 (movement * Time.fixedDeltaTime, 0f));
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.collider.tag == "Ball")
		{
			Debug.Log("GAME OVER!");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}

}
