using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetScript : MonoBehaviour {

    public InputField x;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ResetText() {
        Debug.Log(x);
        Debug.Log(x.text);
        x.text = "0";
        Debug.Log(x.text);

    }
}
