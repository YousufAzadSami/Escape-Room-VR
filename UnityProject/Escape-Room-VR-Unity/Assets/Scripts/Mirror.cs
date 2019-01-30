using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Mirror : MonoBehaviour {

    public GameObject normalMirror;
    public GameObject shatterMirror;
    public GameObject card;

    public GameObject wallTextCanvas;

    // Use this for initialization
    void Start () {
        shatterMirror.SetActive(false);
        card.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        Valve.VR.InteractionSystem.Throwable _object = collision.transform.GetComponent<Valve.VR.InteractionSystem.Throwable>();

        if (_object)
        {
            // set th
            normalMirror.SetActive(false);
            shatterMirror.SetActive(true);

            // card.SetActive(true);
            wallTextCanvas.GetComponent<Animator>().SetTrigger("triggerOnOff");

            // Puzzle Manager
            PuzzleManager.OnPuzzleTwoSolved();
        }

    }
}
