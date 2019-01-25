using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class InputTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        float x = SteamVR_Input._default.inActions.Squeeze.GetAxis(SteamVR_Input_Sources.Any);
        if (x > 0)
        {
            Debug.Log("Squeeze : " + x);
        }
        
	}
}
