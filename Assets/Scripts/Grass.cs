using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grass : MonoBehaviour {

	public GameObject[,] gameBoard; 
	public GameObject[] grass;

	// Use this for initialization
	void Start () {
		int width = 20;

		gameBoard = new GameObject[width,width];
		for (int x = 0; x < width; x++) {
			for (int y = 0; y < width; y++) {
				GameObject temp = Instantiate (grass[Random.Range(0,3)]);
				temp.transform.position = new Vector3((x - (width *0.5f)) * 3.2f, 0, (y-2) * 3.2f);
				temp.transform.SetParent(this.gameObject.transform);
			}
		}
		
	}

	// Update is called once per frame
	void Update () {
		
	}
}
