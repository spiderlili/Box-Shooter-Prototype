﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTarget : MonoBehaviour {

    public float spinSpeed = 180.0f;
    public float motionMagnitude = 0.1f;
    public bool doSpin = true;
    public bool doMotion = true;

	// Update is called once per frame
	void Update () {

        if (doSpin)
        {
            //rotate around the up axis of the gameObject(0, 1, 0)
            gameObject.transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
        }

        if (doMotion)
        {
            //move up and down over time
            gameObject.transform.Translate(Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad));
        }
	}
}
