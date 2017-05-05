using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public GameObject bullet;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//this.transform.position = new Vector3 (0, 0, 0);
		//this.transform.Rotate(new Vector3(0,1.0f,0));
		float distance = 1000f;
		GameObject closest = null;
		GameObject[] closestAtts = GameObject.FindGameObjectsWithTag("Attacker");
		foreach(GameObject posT in closestAtts){
			if (Vector3.Distance (posT.transform.position, this.transform.position) < distance) {
				distance = Vector3.Distance (posT.transform.position, this.transform.position);
				closest = posT;
			}
		}
		if (closest) {
			if (Vector3.Distance (closest.transform.position, this.transform.position) < 5) {
			Transform target = closest.GetComponent<Transform> ();
			transform.LookAt (target);
			Shoot ();
			}
		}
	}

	void Shoot(){
		if (GameObject.FindGameObjectsWithTag ("Bullet").Length < 1) {
			Instantiate (bullet);
		}
	}
}
