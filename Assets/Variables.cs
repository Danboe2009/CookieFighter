﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(!PlayerPrefs.HasKey ("Cookies")){
			PlayerPrefs.SetInt ("Cookies", 1);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}