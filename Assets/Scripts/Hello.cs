﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Hello from " + gameObject.name + " the " + gameObject.GetType());
	}
	
	// Update is called once per frame
	void Update () {
        
    }

}
