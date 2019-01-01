using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static int GetPassCodes()
	{
		if(currentPuzzleLevel == PuzzleLevel.One)
		{
			return PASS_CODE_01;
		}
		return -1;
	}
}
