﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

  
    void Start () {

        Destroy(gameObject, 2f);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
