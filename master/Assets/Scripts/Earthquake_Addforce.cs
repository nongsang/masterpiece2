using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earthquake_Addforce : MonoBehaviour {

    public float speed = 1000.0f;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 fDir = Vector3.forward * Random.Range(-1.0f, 1.0f);
        Vector3 uDir = Vector3.up * Random.Range(-1.0f, 1.0f);
        Vector3 rDir = Vector3.right * Random.Range(-1.0f, 1.0f);

        Vector3 Dir = fDir + uDir + rDir;
        if (Input.GetKeyDown(KeyCode.N))
        {
            GetComponent<Rigidbody>().AddForce(Dir.normalized * speed);
        }
        //GetComponent<Rigidbody>().AddForce(Dir.normalized * speed);
    }
}
