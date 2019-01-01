using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChandelierLIght : MonoBehaviour {

	// public Color[] lightColors = {Color.red, Color.green, Color.blue, Color.white};
	List<Color> lightColors = new List<Color>();
	public int currentColorIndex;

	// Use this for initialization
	void Start () {
		// sets up light colors
		lightColors.Add(Color.red);
		lightColors.Add(Color.green);
		lightColors.Add(Color.blue);
		lightColors.Add(GetComponent<Light>().color);

		currentColorIndex = -1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeLight()
	{
		// Debug.Log("Current Index: " + currentColorIndex);

		Light light = GetComponent<Light>();
		currentColorIndex++;

		// Debug.Log("Current Index: " + currentColorIndex);

		if(currentColorIndex == lightColors.Count)
		{
			currentColorIndex = 0;
		}
		light.color = lightColors[currentColorIndex];
	}
}
