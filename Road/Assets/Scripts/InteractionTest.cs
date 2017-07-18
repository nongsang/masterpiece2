using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionTest : MonoBehaviour {

    GameObject Interobj, textfobj, talkobj;
    Image interimage;
    Text TextF, talkText;

	// Use this for initialization
	void Start () {
        Interobj = GameObject.Find("Interaction");
        interimage = Interobj.GetComponent<Image>();

        textfobj = GameObject.Find("TextF");
        TextF = textfobj.GetComponent<Text>();

        talkobj = GameObject.Find("TalkingText");
        talkText = talkobj.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            interimage.enabled = true;
            TextF.enabled = true;
            talkText.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            interimage.enabled = false;
            TextF.enabled = false;
            talkText.enabled = false;
        }
    }
}
