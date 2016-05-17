using UnityEngine;
using System.Collections;

public class broccoliController : MonoBehaviour {
	public float veleocity;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
		//rb2d.AddForce (new Vector2 (0, veleocity), ForceMode2D.Force);
		rb2d.MovePosition (rb2d.position + new Vector2(0,veleocity) * Time.fixedDeltaTime);

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log (veleocity);
		veleocity = -veleocity;
		Debug.Log (veleocity);
	}
}
