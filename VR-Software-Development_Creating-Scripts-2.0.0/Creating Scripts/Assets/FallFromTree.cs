using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallFromTree : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
		// = if we're running at 60 frames per second, then this gets called around every 16milliseconds
		// this speed depends on software and hardware
	void Update () {
		// transform = shortcut to access the transform component of whatever game object the script is attached to
			// ^ changing the position of the transform component

		// Translate = tells unity that we want to move an object in 3d space
			// move 0 units in the x axis, -2.5 units in the y axis and 0 units in the z axis

		// f tells unity we are typing a number with a decimal point to specify what kind of number we are using = floating point

		// time.deltatime = smooths out the animation over time
			// since we don't know how many update calls, we use this
			//gives framerate-independent
			//contains amount of time it took to render previous frame


		// Space.World = move coconut in world space rather than in local space

			// ^ = even if we rotate the coconut, it always falls towards the ground

		if (transform.position.y > 0.6f) {
			//print ("test: " + transform.position.y); // print to see on console
			transform.Translate (0, -2.5f * Time.deltaTime, 0, Space.World);
		}

		// try this instead of if statement above
		//transform.position = new Vector3(0, 5 + Mathf.Sin(Time.time * 5.0f), 0);
	}
}
