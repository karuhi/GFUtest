using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    transform.Rotate(new Vector3(0, 0, 5));
    transform.Rotate(new Vector3(0, 5, 0));
    transform.Rotate(new Vector3(5, 0, 0));
        Vector3 pos = transform.position;
        pos.y += (float)0.2;
        transform.position = pos;
}
}
