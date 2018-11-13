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
        float xNum = float.Parse(x.text);
        float yNum = float.Parse(y.text);
        float zNum = float.Parse(z.text);
        float angleNum = float.Parse(angle.text);

        transform.rotation = Quaternion.AngleAxis(angleNum, new Vector3(xNum, yNum, zNum));
        // 「現地点から回転」ではなく「初期値からの回転」になっているのでは

    }
}
