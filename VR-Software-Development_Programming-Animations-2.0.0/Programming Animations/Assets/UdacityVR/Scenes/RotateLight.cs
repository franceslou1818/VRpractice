using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLight : MonoBehaviour {

//************  programming animations-animator

	public GameObject directionalLight;
	public Animator sunRotationAnimation;

	float startTime = 0f;
	bool isPressed = false;
	string whoRocks = "Udacity Rocks!";

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Quaternion startRotation = Quaternion.Euler (50f, 30f, 0f);
		Quaternion endRotation = startRotation * Quaternion.Euler (0f, 180f, 0f);

		if (isPressed == true) {
			directionalLight.transform.rotation = Quaternion.Slerp (startRotation, endRotation, startTime / 10f);
			startTime += Time.deltaTime;
		}
		// Replaces 'GvrViewer.Instance.OnTrigger += ActivateRotation;'
		// Typically would be placed at the top of the Update() method, but
		// placed here for the script to better match up with the video
		if (Input.GetMouseButtonDown (0)) {
			ActivateRotation ();
		}
	}

	public void ActivateRotation () {
		isPressed = true;
		sunRotationAnimation.SetBool ("ChangeColor", true);
	}

/**************  programming animations- scripting slerp
	public GameObject directionalLight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// for sun to rotate by looking at shadow

		//Quaternions	 used to represent rotations
		// euler = Returns a rotation that rotates z degrees around the z axis, x degrees around the x axis, and y degrees around the y axis.
		// if we multiple two quaternions together, we are able to add their rotations
		// we're adding 180 degrees in the y directon to our start rotation
		Quaternion startRotation = Quaternion.Euler(50f, 30f, 0f);
		Quaternion endRotation = startRotation * Quaternion.Euler(0f, 180f, 0f);
		//use slerp instead of the rotate method. need time parameter that slerp requires
		// for slerp, or lerp, time param is the value between 0 and 1
			// which dicatates how close the interpolated value should be to the start or end roatation

		// sun will rotate until night then stop
		// after time.time > 1, slerp outputs the end rotation
		// Time.time = time since we hit the play button. can be scaled. dividing makes it fast. multiplying makes it slower
		directionalLight.transform.rotation = Quaternion.Slerp(startRotation, endRotation, Time.time/10f);

		//-------------------------------
		// instead of slerp
		//deltatime = time between frames
		//directionalLight.transform.Rotate (0f, Time.deltaTime, 0f); 
	}
***********************/

}
