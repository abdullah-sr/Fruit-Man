using UnityEngine;
using System.Collections;

public class turnipController : MonoBehaviour {
	public float width;
	public float height;
	public float speed;

	private Rigidbody2D rb2d;
	private float timerCounter;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		timerCounter += Time.deltaTime*speed;

		float x = Mathf.Cos (timerCounter) * width;
		float y = Mathf.Sin (timerCounter) * height;
		rb2d.MovePosition (rb2d.position + new Vector2(x, y) * Time.fixedDeltaTime);
	
	}
}
