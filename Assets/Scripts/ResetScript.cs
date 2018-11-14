using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetScript : MonoBehaviour {

    public InputField x;
    public InputField y;
    public InputField z;
    public InputField angle;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ResetText() {
        x.text = "0";
        y.text = "0";
        z.text = "0";
        angle.text = "0";

    }
}
