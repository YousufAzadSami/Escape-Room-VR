using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour {

	public string chandelierLightName = "ChandelierLight";
	private GameObject chandelierLight;
	private GameObject[] wallText;
	private int indexWallText = -2;
	private bool wallTextFake;

	// Use this for initialization
	void Start () {
		chandelierLight = GameObject.Find(chandelierLightName);

		initWallTextStuff();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerStay(Collider collider)
    {
        if (collider.transform.tag == "Player")
        {
			// Debug.Log("Object Name: " + collider.transform.name);

			if(Input.GetKeyDown(KeyCode.E))
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
			}
        }
    }

	private void SwithcHandleAnimation()
	{
		// TODO
		Debug.Log("TODO");
	}

	private void SwitchDifferentLights()
	{		
		chandelierLight.GetComponent<ChandelierLIght>().ChangeLight();
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
				textMesh.text = textMesh.text + indexWallText.ToString();
			}

			// TODO
			// start animation (invisible to visible, and back)
		}
		else
		{
			wallTextFake = true;
		}
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
}
