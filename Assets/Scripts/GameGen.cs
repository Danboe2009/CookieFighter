using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameGen : MonoBehaviour
{

	public int cookies;
	public GameObject attacker;
	float attX, attZ;
	public Text cookieText;

	// Use this for initialization
	void Start ()
	{
		cookies = 100;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (GameObject.FindGameObjectsWithTag ("Attacker").Length < 1) {
			GenRandom ();
			GameObject temp = Instantiate (attacker);
			temp.transform.position = new Vector3 (attX, 0.1f, attZ);
		}

		cookieText.text = cookies.ToString();
	}

	void GenRandom ()
	{
		int Left = Random.Range (0, 2);
		//Debug.Log ("Left" + Left);
		if (Left == 0) {
			attX = -10;
		} else {
			attX = 10;
		}

		attZ = Random.Range (-10, 2);
	}
}
