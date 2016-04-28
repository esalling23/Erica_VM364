using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class AlgaeBehavior : MonoBehaviour, IResource {
	
	private GameObject control;

	void Start () {
		control = GameObject.Find("GameMaster");

	}
	
	// Update is called once per frame
	void Update () {
//		
	}

	public void Behavior () {
		Debug.Log ("destroyed algae");
		Destroy (this.gameObject);

	} 

}
