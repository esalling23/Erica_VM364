using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class OptionsBehavior : MonoBehaviour {

	private GameObject control;
	private GameObject grove;

	public float Qchance = 30;
	public bool randomQ = false;

	public bool choseReed;
	public bool choseTrash;
	public bool choseClipM;
	public bool chosePlantM;
	public bool choseAlgae;

	public GameObject options;
	public GameObject reedOption;
	public GameObject trashOption;
	public GameObject mangrovePlantOption;
	public GameObject mangroveClipOption;
	public GameObject algaeOption;

	private Vector3 reedPosition = new Vector3 ();
	private Vector3 trashPosition = new Vector3 ();
	private Vector3 mangrovePosition = new Vector3 ();

	private List<GameObject> reedList = new List<GameObject> ();
	private List<GameObject> trashList = new List<GameObject> ();
	private List<GameObject> mangroveList = new List<GameObject> ();

	void Start () {
		control = GameObject.Find("GameMaster");
		options.SetActive (false);
		grove = control.GetComponent<LevelSetUp> ().mangrove;
	}
	
	// Update is called once per frame
	void Update () {


	}

	public void RandomQuestion () {
		float percentage = Random.Range(0,100);
		if(percentage < Qchance) {
			Debug.Log ("time for random question!");
			randomQ = true;
		}
	}

	public void OptionQuestion () {
//		RandomQuestion ();
//		if (randomQ == true) {
//			control.GetComponent<GenerateQuestion> ().GenQ ();
//		} else {
			if (choseReed == true) {
//				Debug.Log ("reeding");
				control.GetComponent<Fuel>().Fueling(-1);
				ReedBehavior ();
			}
			if (choseTrash == true) {
				control.GetComponent<Fuel>().Fueling(-2);
//				Debug.Log ("trashing");
				TrashBehavior ();

			}
			if (chosePlantM == true) {
				control.GetComponent<Fuel>().Fueling(-4);
				MangrovePlantBehavior ();
			}
			if (choseClipM == true) {
				
				control.GetComponent<Fuel>().Fueling(-3);
				MangroveClipBehavior ();
			}
			if (choseAlgae == true) {
				AlgaeBehavior ();
			}
		foreach (GameObject tile in this.GetComponent<CameraViewControl>().tiles) {
			tile.GetComponent<TileSelect> ().TileReference();
			tile.GetComponent<TileSelect> ().TileOptions();
			options.SetActive (false);
		}
		this.GetComponent<GameStats> ().info.SetActive (false);
//		}

		if (this.GetComponent<CameraViewControl> ().onlyMap == true) {
			this.GetComponent<CameraViewControl> ().player.transform.position = new Vector3 (0f, 10f, 0f);
			this.GetComponent<CameraViewControl>().mapCamera.GetComponent<Camera>().orthographicSize = 60;
			this.GetComponent<CameraViewControl>().mapCamera.transform.position = new Vector3 (30f, 100f, 15f);
		}
	}



	public void ReedChoice () {
		choseReed = true;
		choseTrash = false;
		chosePlantM = false;
		choseClipM = false;
		choseAlgae = false;
	}

	public void ReedBehavior () {
		reedList.Clear ();
		reedList.AddRange (GameObject.FindGameObjectsWithTag ("Invasive"));
		reedPosition = control.GetComponent<GameStats>().tileCurrent;
		Debug.Log (reedList.Count);
		Debug.Log (reedPosition);
		foreach (GameObject reed in reedList) {
			if (reed.transform.position.x == reedPosition.x && reed.transform.position.z == reedPosition.z) {
//				Debug.Log ("digging up THIS reed at " + reed.transform.position);
				reed.GetComponentInChildren<InvasiveReedBehavior> ().Behavior ();
			}
		}
	} 

	public void TrashChoice() {
		choseReed = false;
		choseTrash = true;
		chosePlantM = false;
		choseClipM = false;
		choseAlgae = false;
	}

	public void TrashBehavior () {
		trashList.Clear ();
		trashList.AddRange (GameObject.FindGameObjectsWithTag ("Trash"));
		trashPosition = control.GetComponent<GameStats>().tileCurrent;
		Debug.Log (trashList.Count);
		Debug.Log (trashPosition);
		foreach (GameObject trash in trashList) {
			if (trash.transform.position.x == trashPosition.x && trash.transform.position.z == trashPosition.z) {
//				Debug.Log ("cleaning up THIS trash");
				trash.GetComponent<TrashBehavior> ().Behavior ();
			}

		}
	}

	public void ClipMChoice() {
		choseReed = false;
		choseTrash = false;
		chosePlantM = false;
		choseClipM = true;
		choseAlgae = false;
	}

	public void MangroveClipBehavior () {
		Debug.Log ("you clipped mangrove");
		control.GetComponent<TimeControl> ().TimeChange (0.1f);
		control.GetComponent<GameStats> ().hasSeedling = true;
	}

	public void PlantMChoice() {
		choseReed = false;
		choseTrash = false;
		chosePlantM = true;
		choseClipM = false;
		choseAlgae = false;
	}

	public void MangrovePlantBehavior () {
		Debug.Log ("you planted mangrove");
		control.GetComponent<TimeControl> ().TimeChange (0.2f);
		control.GetComponent<GameStats> ().hasSeedling = false;
		Instantiate (grove, control.GetComponent<GameStats> ().tileCurrent, Quaternion.identity);
	}

	public void AlgaeChoice () {
		choseReed = false;
		choseTrash = false;
		chosePlantM = false;
		choseClipM = false;
		choseAlgae = true;
	}
	public void AlgaeBehavior () {
		mangroveList.Clear ();
		mangroveList.AddRange (GameObject.FindGameObjectsWithTag ("Mangrove"));
		mangrovePosition = control.GetComponent<GameStats>().tileCurrent;
		Debug.Log (mangroveList.Count);
		Debug.Log (mangrovePosition);
		foreach (GameObject mangrove in mangroveList) {
			if (mangrove.transform.position.x == mangrovePosition.x && mangrove.transform.position.z == mangrovePosition.z) {
				//				Debug.Log ("cleaning up THIS trash");
				mangrove.GetComponent<MangroveBehavior> ().Behavior();
			}
		}
	}


}
