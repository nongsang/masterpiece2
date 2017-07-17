using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartitionCtrl : MonoBehaviour {

    Rigidbody partition;
    bool kinematic = false;


    private void Awake()
    {
        partition = GetComponent<Rigidbody>();
        partition.isKinematic = true;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void Switch()
    {
        partition.isKinematic = false;
    }
}
