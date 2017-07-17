﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSwitch : MonoBehaviour {

    //GameObject player;
    private GameObject Camera;
    //private GameObject[] Oj;
    bool breakerSwitch1;
    bool breakerSwitch2;
    bool breakerSwitch3;
    bool valve;

    GameObject Elevator;

	// Use this for initialization
	void Start () {
        //Oj = GameObject.FindWithTag("Mug");
        //Oj = GameObject.FindGameObjectsWithTag("OBJECT");

        Camera = GameObject.Find("FirstPersonCharacter");
        Elevator = GameObject.Find("ElevatorButton");
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player" && (breakerSwitch1 & breakerSwitch2 & breakerSwitch3 & valve == true))
        {
            Camera.SendMessage("Switch",SendMessageOptions.DontRequireReceiver);
            Elevator.SendMessage("Switch", SendMessageOptions.DontRequireReceiver);
            //Oj.SendMessage("Switch", SendMessageOptions.DontRequireReceiver);
            //foreach (GameObject o in Oj)
            //{
            //    o.SendMessage("Switch", SendMessageOptions.DontRequireReceiver);
            //}
            breakerSwitch1 = false;
            breakerSwitch2 = false;
            breakerSwitch3 = false;
            valve = false;
        }
    }

    //bool AllTrue(bool breaker1, bool breaker2, bool breaker3, bool valve)
    //{
    //    if (breaker1 & breaker2 & breaker3 & valve == true)
    //        return true;
    //}

    public void SetBreakerSwitch1()
    {
        breakerSwitch1 = true;
    }
    public void SetBreakerSwitch2()
    {
        breakerSwitch2 = true;
    }
    public void SetBreakerSwitch3()
    {
        breakerSwitch3 = true;
    }
    public void SetValve()
    {
        valve = true;
    }
}
