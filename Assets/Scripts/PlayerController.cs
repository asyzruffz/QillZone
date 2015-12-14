﻿using UnityEngine;
using System.Collections;

public class PlayerController : Controller {
    
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        cursor = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetKey("escape")) {
            Application.LoadLevel("Menu");
        }

        //if (Input.GetKey("space")) {
        if (Input.GetMouseButton(1)) {
            moving = true;
        } else {
            moving = false;
        }

        if (Input.GetMouseButton(0)) {
            firing = true;
        }
        else {
            firing = false;
        }

        faceTowards(cursor);
        moveTowards(cursor);
    }
}
