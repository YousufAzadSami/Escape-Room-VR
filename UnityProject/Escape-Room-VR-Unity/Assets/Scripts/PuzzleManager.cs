using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour {

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
		currentPuzzleLevel = PuzzleLevel.One;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
