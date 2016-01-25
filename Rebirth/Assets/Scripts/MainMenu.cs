using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public GameObject pause;

	public void LoadLevel (int level) {
		pause.SetActive (true);
		Application.LoadLevel (level);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
