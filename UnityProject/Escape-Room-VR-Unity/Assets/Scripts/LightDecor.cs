using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDecor : MonoBehaviour {


    public GameObject actual;
    public GameObject shatter;
    public GameObject card;

    public bool isDestructable = true;

    public GameObject wallCanvasText;

	// Use this for initialization
	void Start () {
        card.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision collision)
    {
        if (isDestructable)
        {
            Valve.VR.InteractionSystem.Throwable _object = collision.transform.GetComponent<Valve.VR.InteractionSystem.Throwable>();

            if (_object)
            {
                // set this object to deactive
                actual.SetActive(false);

                // set shattered version to active
                shatter.SetActive(true);

                // set card to active
                //card.SetActive(true);

                // play sound
                GetComponent<AudioSource>().Play();

                if (wallCanvasText)
                {
                    wallCanvasText.GetComponent<Animator>().SetTrigger("triggerOnOff");

                    GameObject.Find("PuzzleManager").GetComponent<PuzzleManager>().OnPuzzleThreeSolved();
                }
            }
        }
    }
}
