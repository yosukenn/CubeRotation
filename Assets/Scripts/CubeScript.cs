using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    }

    public void RotateCube() {
        Text x = GameObject.Find("AxisX").GetComponent<Text>();
        Text y = GameObject.Find("AxisY").GetComponent<Text>();
        Text z = GameObject.Find("AxisZ").GetComponent<Text>();
        Text angle = GameObject.Find("Angle").GetComponent<Text>();

        transform.rotation = Quaternion.AngleAxis(45, new Vector3(0, 1, 0));

    }
}
