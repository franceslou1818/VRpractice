using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMaker : MonoBehaviour {

	// public ensures that reference shows up in editor. able to drag n drop objects
	// GameObject = data type. what kind of reference we want
	// objectToCreate = name of reference. anything we want
	public GameObject objectToCreate;

	// Use this for initialization
	void Start () {
		// make object here
		// a new cube will appear in the position of (2,4,6)
		// creating a copy the object you dragged into that slot and placing a copy into the position
		// calling the instantiate method on the object class
		// 1st param = clone the object that was the one you picked in the editor
		// 2nd param = new position. Vector3 for vector space
		// 3rd param = how to rotate a new object.
			// quaternion.identity = no rotations at all.
		Object.Instantiate(objectToCreate, new Vector3(2,4,6), Quaternion.identity);
		
	}
	 
	// Update is called once per frame
	void Update () {
		
	}
}
