using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

	public int bulletsPerMag = 30;
	public int bulletsLeft = 30;
	public float fireRate = 10f;

	public Rigidbody rb;
	public GameObject firePoint;
	private int bulletSpeed = 100;	

	private float FireDelay;

	void Start () {

	}

	void Update () {

		if(Input.GetButton("Fire1")){
			
			//if(bulletsLeft > 0)
				FireBullet();
		}
		
		if(FireDelay < fireRate)
			FireDelay += Time.deltaTime;
	}

	void FireBullet(){


		if(FireDelay < fireRate)
			return;

 		FireDelay = 0.0f;
		
		bulletsLeft--;
		GetComponent<AudioSource>().Play();
		Rigidbody clone;
		clone = Instantiate(rb, firePoint.transform.position, firePoint.transform.rotation) as Rigidbody;
		clone.velocity = transform.TransformDirection(Vector3.forward * bulletSpeed);

	}
}
