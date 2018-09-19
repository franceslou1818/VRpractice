using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManyObjectMaker : MonoBehaviour {

	public GameObject objectToCreate;

	// Use this for initialization
	void Start () {
		for (int i = 0; i<1000; i++) {
			Object.Instantiate(objectToCreate, new Vector3(i,4,6), Quaternion.identity);	
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
