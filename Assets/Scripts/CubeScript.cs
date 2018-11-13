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
        Text p = GameObject.Find("Text").GetComponent<Text>();
        Debug.Log(p.text);
	}

    public void RotateCube() {
        transform.rotation = Quaternion.AngleAxis(45, new Vector3(0, 1, 0));
    }
}
