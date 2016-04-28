using UnityEngine;
using System.Collections;

public class DNASpotBehavior : MonoBehaviour {

	public GameObject accessSpotPlacement;
	private float exploreWidth;
	private float exploreLength;


	// Use this for initialization
	void Start () {
		exploreLength = accessSpotPlacement.GetComponent<DNASpotPlacement> ().exploreLength;
		exploreWidth = accessSpotPlacement.GetComponent<DNASpotPlacement> ().exploreWidth;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

//	void OnTriggerStay (Collider collider) {
//		if (collider.gameObject.tag == "DNASpot" || collider.gameObject.tag == "Soil" || collider.gameObject.tag == "Sand" || collider.gameObject.tag == "Oil") {
//			this.transform.position = new Vector3 (Random.Range (-exploreWidth, exploreWidth), -4, Random.Range (-exploreLength, exploreLength));
//		}
//	}

}
