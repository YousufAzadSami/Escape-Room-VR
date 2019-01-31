using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PuzzleManager : MonoBehaviour {

	public static PuzzleManager instance;

	public static int PASS_CODE_01 = 123;
	public static int PASS_CODE_02 = 456;
	public static int PASS_CODE_03 = 789;

    public List<int> correctCode;
    public List<int> givenCode;

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

        setupCorrectCode();

        Debug.Log("Puzzle Manager GameObject name : " + transform.name);
    }

    private void setupCorrectCode()
    {
        // so the correct code is 123
        correctCode.Add(1);
        correctCode.Add(2);
        correctCode.Add(3);
        //for (int i = 0; i < correctCode.Count; i++)
        //{
        //    Debug.Log(correctCode[i]);
        //}
        //Debug.Log(correctCode.Count);
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

    public void OnPuzzleOneSolved()
    {
        Debug.Log("PuzzleOneSolved()");

        GameObject pointLight00 = GameObject.Find("Point Light (0)");
        if (pointLight00)
        {
            pointLight00.GetComponent<Light>().color = Color.green;
        }

        // play audio 
        GetComponent<AudioSource>().Play();


        currentPuzzleLevel = PuzzleLevel.Two;
    }

    public void OnPuzzleTwoSolved()
    {
        GameObject pointLight01 = GameObject.Find("Point Light (1)");
        if (pointLight01)
        {
            pointLight01.GetComponent<Light>().color = Color.green;
        }

        // play audio 
        GetComponent<AudioSource>().Play();

        currentPuzzleLevel = PuzzleLevel.Three;
    }

    public void OnPuzzleThreeSolved()
    {
        GameObject pointLight01 = GameObject.Find("Point Light (2)");
        if (pointLight01)
        {
            pointLight01.GetComponent<Light>().color = Color.green;
        }

        // play audio 
        GetComponent<AudioSource>().Play();

        currentPuzzleLevel = PuzzleLevel.Four;
    }

    public void CheckNumberCode(int inNumber)
    {
        givenCode.Add(inNumber);

        if (correctCode.SequenceEqual(givenCode))
        {
            Debug.Log("Puzzle Solved");
        }

        if (givenCode.Count == 3)
        {
            givenCode.Clear();
        }
    }
}
