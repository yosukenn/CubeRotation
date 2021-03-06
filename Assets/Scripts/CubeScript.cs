﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeScript : MonoBehaviour {

    public Text err;

	// Use this for initialization
	void Start () {
        err.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
    }

    public void RotateCube() {
        if (err.enabled == true) {
            err.enabled = false;
        }

        Text x = GameObject.Find("AxisX").GetComponent<Text>();
        Text y = GameObject.Find("AxisY").GetComponent<Text>();
        Text z = GameObject.Find("AxisZ").GetComponent<Text>();
        Text angle = GameObject.Find("Angle").GetComponent<Text>();

        if (!string.IsNullOrEmpty(x.text) && !string.IsNullOrEmpty(y.text) && !string.IsNullOrEmpty(z.text) && !string.IsNullOrEmpty(angle.text)) {

            float xNum = float.Parse(x.text);
            float yNum = float.Parse(y.text);
            float zNum = float.Parse(z.text);
            float angleNum = float.Parse(angle.text);

            transform.rotation *= Quaternion.AngleAxis(angleNum, new Vector3(xNum, yNum, zNum));

        } else {

            err.enabled = true;

        }

    }

    public void ResetCube() {
        if (err.enabled == true)
        {
            err.enabled = false;
        }
        transform.rotation = Quaternion.AngleAxis(0, new Vector3(0, 0, 0));


    }

}
