using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D rb2d;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		//Instantiate(this.gameObject, Vector2.zero, Quaternion.Euler(0,0,0));
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		float moveHorizontal = Input.GetAxisRaw ("Horizontal");
		float moveVertical = Input.GetAxisRaw("Vertical");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		rb2d.MovePosition (rb2d.position + movement * Time.deltaTime*2);

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "door") {
			Application.LoadLevel ("cave");
		} else if (other.tag == "door2" || other.tag == "door3") {
			Application.LoadLevel ("Main");
		}
	}
}
