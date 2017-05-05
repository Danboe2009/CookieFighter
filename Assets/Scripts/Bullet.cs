using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public Transform target;
	public float speed;
	// Use this for initialization
	void Start () {
		float distance = 1000f;
		GameObject closest = null;
		GameObject[] closestAtts = GameObject.FindGameObjectsWithTag("Attacker");
		foreach(GameObject posT in closestAtts){
			if (Vector3.Distance (posT.transform.position, this.transform.position) < distance) {
				distance = Vector3.Distance (posT.transform.position, this.transform.position);
				closest = posT;
			}
		}
		target = closest.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (target) {
			float step = speed * Time.deltaTime;
			Vector3 targetLoc = new Vector3 (target.position.x, target.position.y + 0.5f, target.position.z);
			transform.position = Vector3.MoveTowards (transform.position, targetLoc, step);
		} else {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter(Collision collision){
		//Debug.Log ("Bullet Collision: " + collision.gameObject.name);
		if (collision.gameObject.name == "Attacker") {
			Destroy (gameObject);
		}
	}
}
