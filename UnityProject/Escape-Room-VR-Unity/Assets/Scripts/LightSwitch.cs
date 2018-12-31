using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour {

	public string chandelierLightName = "ChandelierLight";
	private GameObject chandelierLight;

	// Use this for initialization
	void Start () {
		chandelierLight = GameObject.Find(chandelierLightName);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter(Collider collider)
    {
        if (collider.transform.tag == "Player")
        {
            Debug.Log("Object Name: " + collider.transform.name);

			// if player interacts by pressing by any key 
			// OR 
			// just by coming in the trigger zone following actions will be performed

			// move the switch handle
			SwithcHandleAnimation();
			// and 
			// turn differnt lights (switch between them)
			SwitchDifferentLights();
        }
    }

	private void SwithcHandleAnimation()
	{
		// TODO
		Debug.Log("TODO");
	}

	private void SwitchDifferentLights()
	{
		// TODO
		Debug.Log("TODO");
	}
}
