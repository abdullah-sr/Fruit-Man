using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {
	public GameObject target;
	public float speed;

	private Rigidbody2D rb2d;
	private Vector3 targetPosition;

	void Start() {

		rb2d = GetComponent<Rigidbody2D> ();
		//rb2d.AddForceAtPosition (Vector2.one*5, target.transform.position, ForceMode2D.Force);
		//GetComponent<Rigidbody2D>().MovePosition
		//Vector2 temp = new Vector2(target.transform.position.x, target.transform.position.y);
		//rb2d.MovePosition(temp + Vector2.one * Time.fixedDeltaTime);
		//rb2d.AddForce (target.transform.position*5, ForceMode2D.Force);\
		//Vector2

	}


	
	void Update () {
		
		//GetComponent<Rigidbody2D> ().MovePosition (target.transform.position * Time.fixedDeltaTime);

		//Vector2
		//rb2d.MovePosition ((new Vector2 (rb2d.position.x, rb2d.position.y) + new Vector2(target.transform.position.x, target.transform.position.y) * Time.fixedDeltaTime));

		float step = speed * Time.deltaTime;
		
		// Move our position a step closer to the target.
		Debug.Log (target.transform.position);
		transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
	}
}
