using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {

	public Transform target;
	public float speed;
	public GameObject[] person;

	// Use this for initialization
	void Start () {
		int volunteer = Random.Range (0, person.Length);
		Debug.Log ("Volunteer : " + volunteer);
		GameObject temp = Instantiate (person[volunteer]);
		temp.transform.position = this.transform.position;
		temp.transform.SetParent (this.transform);
		target = GameObject.FindGameObjectWithTag ("Surviver").GetComponent<Transform> ();
		transform.LookAt (target);
	}
	

	void Update() {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.position, step);
	}

	void OnCollisionEnter(Collision collision){
		//Debug.Log ("Attacker Collision: " + collision.gameObject.tag);
		if (collision.gameObject.tag == "Bullet") {
			Destroy (gameObject);
		}
	}
}
