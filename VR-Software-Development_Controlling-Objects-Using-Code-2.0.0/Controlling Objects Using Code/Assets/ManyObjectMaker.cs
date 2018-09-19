using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManyObjectMaker : MonoBehaviour {

	public GameObject objectToCreate;

	// Use this for initialization
	void Start () {
		for (int i = 0; i<50; i++) {
			//Object.Instantiate(objectToCreate, new Vector3(i,4,6), Quaternion.identity);


			//the same as above but storing it in a var to let us change it
			GameObject newSeagull = (GameObject)Object.Instantiate(objectToCreate, new Vector3(i,0,0), Quaternion.identity);
			// seagull prefab in assets has hierarchy and if we expand that hierarchy, that would be the renderer
			// this will find the first renderer on the new seagull
			// this case first renderer is named seagull under seagullmodel
			Renderer objectRenderer = newSeagull.GetComponentInChildren<Renderer>();
			// it will find that material (one of the components) and change the color
				// random = random shades of white
			//objectRenderer.material.color = Color.white * Random.value;
			objectRenderer.material.color = Random.ColorHSV(); // try this instead

		}

	}

	// Update is called once per frame
	void Update () {

	}
}
