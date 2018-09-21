using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectTreasure : MonoBehaviour {

	//public GameObject chest;
	public Animator openChest;

	//similar to update but proper when dealing with rigidbodies
	// we use this as raycasting uses physics
	void FixedUpdate() {

		//forward vector. direction the object is facing
		// in unity editor, it is represented by the blue arrow  on camera
		// camera since this will be attached to the camera
		Vector3 fwd = transform.TransformDirection (Vector3.forward);

		// this does the raycasting
		// param = position, forward vector, how far we want the ray to travel
		if (Physics.Raycast(transform.position, fwd, 5)) {
			// this will print if we see the chest. wont if look away
			print ("There is something in front of the object!");

			//sunRotationAnimation.StartPlayback ();
			//openChest.enabled = false; // Disable the Animator component

			//sunRotationAnimation.StopPlayback ();
			openChest.enabled = true; // Enable the Animator component

		}
	}
}
