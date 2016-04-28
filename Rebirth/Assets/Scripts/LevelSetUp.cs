using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class LevelSetUp : MonoBehaviour {

	public GameObject invasiveReedSpecies;
	public GameObject trash;
	public GameObject mangrove;
	public Transform tile;
//	private GameObject tilePlace;
	private GameObject tileManager;

	private GameObject reedSpot;
	private GameObject trashSpot;
	private GameObject mangroveSpot;
	private GameObject newMangrove;
	private GameObject newTrash;
	private GameObject newReed;

	private bool reedPresent = false;
	private bool trashPresent = false;

	public List<GameObject> marshList = new List<GameObject>();
	public List<GameObject> reedSpotList = new List<GameObject> ();
	public List<GameObject> trashSpotList = new List<GameObject> ();
	public List<GameObject> mangroveList = new List<GameObject> ();

	public int marshListLength;
	public int mangroveListLength;

	// Use this for initialization
	void Start () {
		tileManager = GameObject.Find ("MapContainer");
		marshList.AddRange(GameObject.FindGameObjectsWithTag ("marsh"));
		marshListLength = marshList.Count;
		foreach (GameObject marshSpot in marshList) {
			Vector3 tilePosition = new Vector3(marshSpot.transform.position.x, 1, marshSpot.transform.position.z);
			GameObject tilePlace = (GameObject) Instantiate (tile, tilePosition, Quaternion.identity);
			tilePlace.transform.parent = tileManager.transform;
//			Debug.Log (tileManager.transform.position);
		}
		Debug.Log (marshListLength.ToString () + "marsh cubes");
		for (int i = 0; i < 6; i++) {
			ReedPlacement ();
//			Debug.Log ("placing reed");
		}
		marshList.Clear ();
		marshList.AddRange(GameObject.FindGameObjectsWithTag ("marsh"));

		for (int j = 0; j < 8; j++) {
			TrashPlacement ();
//			Debug.Log ("placing trash");
		}

		marshList.Clear ();
		marshList.AddRange(GameObject.FindGameObjectsWithTag ("marsh"));
		marshListLength = marshList.Count;

		trashSpotList.Clear();
		trashSpotList.AddRange (GameObject.FindGameObjectsWithTag ("Trash"));

		reedSpotList.Clear();
		reedSpotList.AddRange (GameObject.FindGameObjectsWithTag ("Invasive"));

		while (mangroveListLength < 3) {
			mangroveListLength = mangroveList.Count;
			MangrovePlacement ();
//			Debug.Log ("placing mangrove");
			mangroveListLength = mangroveList.Count;
//			Debug.Log (mangroveListLength + " is the number of mangroves");

		}
		this.GetComponent<GameStats> ().CheckStats ();
//		Instructions ();

	}
	
	// Update is called once per frame
	void Update () {
		marshListLength = marshList.Count;
		mangroveListLength = mangroveList.Count;

		if (Input.GetKeyDown (KeyCode.Q)) {
			Debug.Log (marshListLength.ToString () + "marsh cubes");
		}
	}


	public void ReedPlacement () {
		marshListLength = marshList.Count;

		int marshIndex = Mathf.FloorToInt (Random.value * (float)marshListLength);
//		Debug.Log (marshIndex.ToString () + " is the marsh-reed index");

		reedSpot = marshList [marshIndex];
		marshList.RemoveAt (marshIndex);
		reedSpotList.Add (reedSpot);
		marshListLength = marshList.Count;

		Vector3 position = new Vector3(reedSpot.transform.position.x, 0, reedSpot.transform.position.z);
		newReed = Instantiate (invasiveReedSpecies, position, Quaternion.identity) as GameObject;
	
	}
	public void TrashPlacement () {
		marshListLength = marshList.Count;

		int marshIndex = Mathf.FloorToInt (Random.value * (float)marshListLength);
//		Debug.Log (marshIndex.ToString () + " is the marsh-trash index");

		trashSpot = marshList [marshIndex];
		marshList.RemoveAt (marshIndex);
		trashSpotList.Add (trashSpot);
		marshListLength = marshList.Count;

		Vector3 position = new Vector3(trashSpot.transform.position.x, 0, trashSpot.transform.position.z);
		newTrash = Instantiate (trash, position, Quaternion.identity) as GameObject;

	}
	public void MangrovePlacement () {
		trashPresent = false;
		reedPresent = false;

		int marshIndex = Mathf.FloorToInt (Random.value * (float)marshListLength);
		Debug.Log (marshIndex.ToString () + " is the marsh-mangrove index");

		mangroveSpot = marshList [marshIndex];

		foreach (GameObject trash in trashSpotList) {
			if (mangroveSpot.transform.position.x == trash.transform.position.x && mangroveSpot.transform.position.z == trash.transform.position.z) {
				trashPresent = true;
			}
		}
		foreach (GameObject reed in reedSpotList) {
			if (mangroveSpot.transform.position.x == reed.transform.position.x && mangroveSpot.transform.position.z == reed.transform.position.z) {
				reedPresent = true;
			}
		}

		if (trashPresent == false && reedPresent == false) {
			marshList.RemoveAt (marshIndex);
			mangroveList.Add (mangroveSpot);
			marshListLength = marshList.Count;

//			Debug.Log (mangroveList.Count + " is the number of mangroves");

			Vector3 position = new Vector3 (mangroveSpot.transform.position.x, 0, mangroveSpot.transform.position.z);
			newMangrove = Instantiate (mangrove, position, Quaternion.identity) as GameObject;
			newMangrove.GetComponent<MangroveBehavior> ().AlgaeSpawn ();
		}


	}
 
}
