using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumpadScale : MonoBehaviour {

    private Vector3 targetBig;
    private Vector3 targetOriginal;

    private Vector3 target;

    private Animator anim;

    // Use this for initialization
    void Start () {
        targetBig = new Vector3(1, 1, 1);
        targetOriginal = transform.localScale;

        target = targetOriginal;

        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //if ((transform.localScale.x - target.x) > .01f)
        //{
        //    transform.localScale = Vector3.Lerp(transform.localScale, target, 5.0f);
        //}
    }

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("OnTriggerEnter");
        //Debug.Log("Object Name: " + other.transform.name);
        //if (other.CompareTag("Hand"))
        //{
        //    //transform.localScale = Vector3.Lerp(targetBig, transform.localScale, 2.0f);
        //    //target = targetBig;
        //    Debug.Log("Inside");
        //    anim.SetBool("big", true);
        //}
    }

    void OnTriggerExit(Collider other)
    {
        ////Debug.Log("OnTriggerEnter");
        ////Debug.Log("Object Name: " + other.transform.name);
        //if (other.CompareTag("Hand"))
        //{
        //    //transform.localScale = Vector3.Lerp(targetOriginal, transform.localScale, 2.0f);
        //    //target = targetOriginal;
        //    Debug.Log("Outside");
        //    anim.SetBool("big", false);
        //}
    }
}
