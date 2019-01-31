using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numpad : MonoBehaviour {

    public int number;
    private PuzzleManager puzzleManager;

	// Use this for initialization
	void Start () {
        puzzleManager = GameObject.Find("PuzzleManager").GetComponent<PuzzleManager>();

        if (!puzzleManager)
        {
            Debug.Log("PuzzleManager not found");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void NumberButtonPressed()
    {
        Debug.Log("Button pressed : " + number);
        puzzleManager.CheckNumberCode(number);
    }
}
