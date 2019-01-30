using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class LightSwitch : MonoBehaviour {

	public string chandelierLightName = "ChandelierLight";
	private GameObject chandelierLight;
	private GameObject[] wallText;
	private int indexWallText = -2;
	private bool wallTextFake;

	private Animator animator;

	// Use this for initialization
	void Start () {
		chandelierLight = GameObject.Find(chandelierLightName);

		initWallTextStuff();

		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay(Collider collider)
    {
        if (collider.transform.tag == "Player")
        {
			// Debug.Log("Object Name: " + collider.transform.name);

			if(Input.GetKeyDown(KeyCode.E))
			{
                AllSwithHandleStuff();
			}
        }

        if (collider.transform.tag == "Hand")
        {
            // Debug.Log("Object Name: " + collider.transform.name);

            if (SteamVR_Input._default.inActions.GrabPinch.GetStateDown(SteamVR_Input_Sources.Any))
            {
                //Debug.Log("Grab Pinch Down");
                AllSwithHandleStuff();
            }
        }


        // Debug.Log("Object Name: " + collider.transform.name);
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("OnTriggerEnter");
        //Debug.Log("Object Name: " + other.transform.name);
    }

    private void AllSwithHandleStuff()
    {
        // if player interacts by pressing by any key 
        // OR 
        // just by coming in the trigger zone following actions will be performed
        // idea #1 4 different lights can be found by swithcing off(bottom), on(top) the light
        // and Vive controller key press will determine wihch will be shown
        // idea #2 4 different lights can be found by swithching off(bottom), on(top), right and left
        // and Vive controller direction will determine which will be shown

        // move the switch handle
        SwithcHandleAnimation();
        // and 
        // turn differnt lights (switch between them)
        SwitchDifferentLights();
        // and 
        // change text on the wall
        ChangeTextWall();

        // change satatus light
        PuzzleManager.OnPuzzleOneSolved();
    }

    private void SwithcHandleAnimation()
	{
		bool isSwitchOn = animator.GetBool("isSwitchOn");
		if(isSwitchOn)
		{
			animator.SetBool("isSwitchOn", false);
		}
		else 
		{
			animator.SetBool("isSwitchOn", true);
		}
	}

	private void SwitchDifferentLights()
	{		
		chandelierLight.GetComponent<ChandelierLIght>().ChangeLight();
	}

	private void initWallTextStuff()
	{
		// finds the gameobjects with wall text (for numbers)
		wallText = GameObject.FindGameObjectsWithTag("WallText");
		indexWallText = -1;
		// initially setting to false, so that when switching on first time
		// nothing will happen.
		wallTextFake = false;
	}

	private void ChangeTextWall()
	{
		if(wallTextFake)
		{
			indexWallText++;
			if(indexWallText >= wallText.Length)
			{
				indexWallText = 0;
			}
			// change the text
			TextMesh textMesh = wallText[indexWallText].GetComponent<TextMesh>();
			if(textMesh.text.Length < 1)
			{
				string passCode = PuzzleManager.GetPassCodes().ToString();
				textMesh.text = textMesh.text + passCode[indexWallText];
			}

			// TODO
			// start animation (invisible to visible, and back)
		}
		else
		{
			wallTextFake = true;
		}
	}
}
