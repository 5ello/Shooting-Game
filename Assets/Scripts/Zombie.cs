using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour {

	public Transform target;
	private bool isWalking = true;
	private bool isAttacking = false;
	private bool isDead = false;
	
	private int hits = 0;
	// Use this for initialization
	void Start () {
		
	}

	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "Bullet"){

			hits++;

			Debug.Log("HIT");
			if(hits == 3){
				Destroy(gameObject);
				Debug.Log("HIT: " + other.gameObject.name);
				//Die;
			}

			Destroy(other.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {

		if(isWalking == true){
			transform.Translate(Vector3.forward * Time.deltaTime);
			transform.LookAt(target);
		}
		
	}
}
