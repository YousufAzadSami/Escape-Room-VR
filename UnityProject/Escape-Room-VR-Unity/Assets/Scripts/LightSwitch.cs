using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
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
			
        }
    }
}
