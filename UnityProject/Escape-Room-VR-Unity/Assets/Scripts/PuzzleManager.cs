using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class PuzzleManager : MonoBehaviour {

	public static PuzzleManager instance;

	public static int PASS_CODE_01 = 123;
	public static int PASS_CODE_02 = 456;
	public static int PASS_CODE_03 = 789;

	public enum PuzzleLevel
	{
		One, Two, Three, Four
	}

	public static PuzzleLevel currentPuzzleLevel;

	// Use this for initialization
	void Start () {
		
		// //Check if instance already exists
		// if (instance == null)
		// {
		// 	//if not, set instance to this
		// 	instance = this;
		// }
		// //If instance already exists and it's not this:
		// else if (instance != this)
		// {
		// 	//Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
		// 	Destroy(gameObject);    	
		// }
		
		currentPuzzleLevel = PuzzleLevel.One;

        Debug.Log("Puzzle Manager GameObject name : " + transform.name);
    }
	
	// Update is called once per frame
	void Update () {
        if (SteamVR_Input._default.inActions.GrabPinch.GetStateDown(SteamVR_Input_Sources.Any))
        {
            //Debug.Log("Grab Pinch Down");
            OnPuzzleOneSolved();
        }
    }

	public static int GetPassCodes()
	{
		if(currentPuzzleLevel == PuzzleLevel.One)
		{
			return PASS_CODE_01;
		}
		return -1;
	}

    public static void OnPuzzleOneSolved()
    {
        GameObject pointLight00 = GameObject.Find("Point Light (0)");
        if (pointLight00)
        {
            pointLight00.GetComponent<Light>().color = Color.green;
        }

        // play audio 


        currentPuzzleLevel = PuzzleLevel.Two;
    }

    public static void OnPuzzleTwoSolved()
    {
        GameObject pointLight01 = GameObject.Find("Point Light (1)");
        if (pointLight01)
        {
            pointLight01.GetComponent<Light>().color = Color.green;
        }
    }
}
