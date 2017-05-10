using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour {

	public int Dir;

	private float Health;
	private float range;


	// Use this for initialization
	void Start () {
		Health = 1f;
		range  = Random.Range (0.5f, 1.5f);
		//Debug.Log ("Range: " + range);
	}
	
	// Update is called once per frame
	void Update () {
		if (Dir == 0) {
			this.transform.Rotate (new Vector3 (0.0f, 0.0f, range));
		} else {
			this.transform.Rotate (new Vector3 (0.0f, 0.0f, (-1f * range)));
		}
		this.gameObject.transform.localScale = new Vector3 (1 * (Health), 1 * (Health), .25f * (Health));
	}

	float GetHealth(){
		return Health;
	}

	void SetHealth(float num){
		Health -= num;
	}
}
