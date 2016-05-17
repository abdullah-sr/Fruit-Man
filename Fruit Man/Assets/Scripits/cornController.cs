using UnityEngine;
using System.Collections;

public class cornController : MonoBehaviour {
	public GameObject cornBomb;

	public float fireRate;
	
	private float nextFire;

	// Use this for initialization
	void Start () {
		//Instantiate (cornBomb, transform.position, Quaternion.Euler(0,0,0));
	}
	
	void Update (){
		while (Time.time > nextFire)
		{
			
			nextFire = Time.time + fireRate;
			Instantiate(cornBomb, transform.position, Quaternion.Euler(0,0,0));
		}
		
	}
}
