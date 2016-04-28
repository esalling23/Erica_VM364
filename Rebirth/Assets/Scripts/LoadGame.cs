using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class LoadGame : MonoBehaviour{
	
	public GameObject loadingScreen;


	public void LoadLevel (int level) {
		loadingScreen.SetActive (true);
		Application.LoadLevel (level);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
