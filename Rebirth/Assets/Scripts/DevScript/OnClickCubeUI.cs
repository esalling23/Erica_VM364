using UnityEngine;
using System.Collections;

public class OnClickCubeUI : MonoBehaviour {

	public GameObject UIInfo;
	public GameObject UITools;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnMouseOver()
	{
		// If the left mouse button is pressed
		if (Input.GetMouseButtonDown(0))
		{
			// Display a message in the Console tab
			Debug.Log("Left click!");

			UIInfo.SetActive(true);
			// Destroy the parent of the face we clicked
			//Destroy(this.transform.parent.gameObject);
		}
		
		// If the right mouse button is pressed
		if (Input.GetMouseButtonDown(1))
		{
			// Display a message in the Console tab
			Debug.Log("Right click!");

			UITools.SetActive(true);

			// Call method from WorldGenerator class
			//WorldGenerator.CloneAndPlace(this.transform.parent.transform.position + delta, // N = C + delta
			                             //this.transform.parent.gameObject); // The parent GameObject 
		}
	}

}
