using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class CameraViewControl : MonoBehaviour {

	private GameObject controller;
	private GameObject mapTiles;

	public GameObject player;
	public GameObject playerIndicator;
	public GameObject mapCamera;
	private Vector3 mapCamPos = new Vector3 ();
	private Vector3 mapCamMove = new Vector3();
	private bool camMoving = false;

	public GameObject povCamera;
	public GameObject land;

	public GameObject povUI;
	public GameObject mapUI;

	public GameObject[] tiles;

	public List<GameObject> trashList = new List<GameObject>();
	public List<GameObject> reedList = new List<GameObject>();
	public List<GameObject> mangroveList = new List<GameObject>();

	public BoxCollider[] reedCollider;
	public BoxCollider trashCollider;
	public BoxCollider[] mangroveCollider;

	public bool onlyMap = true;
	public bool povMode = false;

	// Use this for initialization
	void Start () {
		mapCamPos = mapCamera.transform.position;
		controller = GameObject.Find ("GameMaster");
		tiles = GameObject.FindGameObjectsWithTag ("Tile");
		playerIndicator = GameObject.Find ("PlayerIndicator");
		playerIndicator.GetComponent<Renderer> ().enabled = false;
		player = GameObject.Find ("First Person Controller");
		mapTiles = GameObject.Find ("MapContainer");
		povMode = false;
		playerIndicator.GetComponent<Renderer> ().enabled = false;
		ModeSetup ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.M)) {
			ModeChange ();
			ModeSetup ();
			Debug.Log ("Mode Changed");
		}

		if (povMode != true) {
			MoveCamera ();
		}
	

	}

	public void MoveCamera () {
		mapCamMove = mapCamera.transform.position;
		if (Input.GetAxis ("Horizontal") > 0 && camMoving == false) {
			camMoving = true;
			if (mapCamMove.x < mapCamPos.x + 90f) {
				mapCamMove.x++;
				mapCamera.transform.position = mapCamMove;
				Debug.Log ("Moving Camera");
				camMoving = false;
			} else {
				mapCamMove.x = mapCamPos.x + 90f;
				camMoving = false;
			}

		}
		if (Input.GetAxis ("Horizontal") < 0 && camMoving == false) {
			camMoving = true;
			if (mapCamMove.x > mapCamPos.x - 90f) {
				mapCamMove.x--;
				mapCamera.transform.position = mapCamMove;
				Debug.Log ("Moving Camera");
				camMoving = false;
			} else {
				mapCamMove.x = mapCamPos.x - 90f;
				camMoving = false;
			}
		}
		if (Input.GetAxis ("Vertical") > 0  && camMoving == false) {
			camMoving = true;
			if (mapCamMove.z < mapCamPos.z + 50f) {
				mapCamMove.z++;
				mapCamera.transform.position = mapCamMove;
				Debug.Log ("Moving Camera");
				camMoving = false;
			} else {
				mapCamMove.z = mapCamPos.z + 50f;
				camMoving = false;
			}
		}
		if (Input.GetAxis ("Vertical") < 0 && camMoving == false) {
			camMoving = true;
			if (mapCamMove.z > mapCamPos.z - 50f) {
				mapCamMove.z--;
				mapCamera.transform.position = mapCamMove;
				Debug.Log ("Moving Camera");
				camMoving = false;
			} else {
				mapCamMove.z = mapCamPos.z - 50f;
				camMoving = false;
			}
		}
		if (onlyMap == false) {

			if (Input.GetAxis ("Mouse ScrollWheel") < 0) { // back
				mapCamera.GetComponent<Camera> ().orthographicSize = 60;
				//			Camera.main.orthographicSize = Mathf.Max (Camera.main.orthographicSize - 1, 30);

			}

			if (Input.GetAxis ("Mouse ScrollWheel") > 0) { // forward
				mapCamera.GetComponent<Camera> ().orthographicSize = 30;
				//			Camera.main.orthographicSize = Mathf.Min(Camera.main.orthographicSize - 1, 60);
			}
		}
	}

	public void ChooseTile () {
		ModeChange ();

		if (onlyMap == true) {
			MapsModeSetup ();
		} else {
			ModeSetup ();
		}
	}

	public void ModeChange () {
		povMode = !povMode;
		foreach (GameObject tile in tiles) {
			tile.GetComponent<TileSelect> ().TileReference ();
//			Debug.Log ("checking tiles");
		}
	}

	public void MapsOnly () {
		onlyMap = !onlyMap;
		Debug.Log (onlyMap);
	}

	public void MapsModeSetup() {
		if (povMode == true) {
			this.GetComponent<DayNightCycle> ().timeMultiplier = 0f;
			playerIndicator.GetComponent<Renderer> ().enabled = false;
			povUI.SetActive (true);
			mapUI.SetActive (false);
			mapTiles.SetActive (false);

			mapCamera.GetComponent<Camera> ().orthographicSize = 10;
			mapCamera.transform.position = new Vector3(controller.GetComponent<GameStats> ().tileCurrent.x, 100f, controller.GetComponent<GameStats>().tileCurrent.z);

			Cursor.visible = true;

			Debug.Log ("Map Tile Mode Enabled");

		} else {
			this.GetComponent<DayNightCycle> ().timeMultiplier = 0f;
			this.GetComponent<GameStats>().hints.SetActive (true);
			this.GetComponent<GameStats>().hintText.text = "Choose a tile";
			playerIndicator.GetComponent<Renderer> ().enabled = true;
			povUI.SetActive (false);
			mapUI.SetActive (true);
			mapTiles.SetActive (true);

			povCamera.SetActive (false);
			mapCamera.SetActive (true);

			//set back to original size and position
			mapCamera.GetComponent<Camera> ().orthographicSize = 60;
			mapCamera.transform.position = new Vector3 (30f, 100f, 15f);

			Cursor.lockState = CursorLockMode.Confined;
			Cursor.visible = true;

			Debug.Log ("Map Full Mode Enabled");
		}

		this.GetComponent<DayNightCycle> ().timeMultiplier = 0f;

		player.GetComponent<MouseLook> ().enabled = false;
		player.GetComponent<CharacterMotorC> ().enabled = false;
		player.GetComponent<FPSInputControllerC> ().enabled = false;

		trashList = new List<GameObject>(GameObject.FindGameObjectsWithTag("Trash"));
		//Debug.Log (trashList.Count + " " + levelSetup.GetComponent<LevelSetUp> ().trashSpotList.Count);
		reedList = new List<GameObject>(GameObject.FindGameObjectsWithTag("Invasive"));
		//Debug.Log (reedList.Count + " " + levelSetup.GetComponent<LevelSetUp> ().reedSpotList.Count);
		mangroveList = new List<GameObject>(GameObject.FindGameObjectsWithTag("Mangrove"));

		foreach (GameObject reed in reedList) {
			reedCollider = reed.GetComponentsInChildren<BoxCollider> ();
			foreach (BoxCollider collider in reedCollider) {
				collider.enabled = false;
			}
		}
		foreach (GameObject trash in trashList) {
			trash.GetComponent<BoxCollider>().enabled = false;
		}
		foreach (GameObject mangrove in mangroveList) {
			mangroveCollider = mangrove.GetComponentsInChildren<BoxCollider> ();
			foreach (BoxCollider collider in mangroveCollider) {
				collider.enabled = false;
			}
		}

	}

	public void ModeSetup () {
		if (povMode == true) {
			controller.GetComponent<DayNightCycle> ().timeMultiplier = 0f;
			trashList = new List<GameObject>(GameObject.FindGameObjectsWithTag("Trash"));
			//Debug.Log (trashList.Count + " " + levelSetup.GetComponent<LevelSetUp> ().trashSpotList.Count);
			reedList = new List<GameObject>(GameObject.FindGameObjectsWithTag("Invasive"));
			//Debug.Log (reedList.Count + " " + levelSetup.GetComponent<LevelSetUp> ().reedSpotList.Count);
			mangroveList = new List<GameObject>(GameObject.FindGameObjectsWithTag("Mangrove"));

			foreach (GameObject reed in reedList) {
				reedCollider = reed.GetComponentsInChildren<BoxCollider> ();
				foreach (BoxCollider collider in reedCollider) {
					collider.enabled = true;
				}
			}
			foreach (GameObject trash in trashList) {
				trash.GetComponent<BoxCollider>().enabled = true;
			}
			foreach (GameObject mangrove in mangroveList) {
				mangroveCollider = mangrove.GetComponentsInChildren<BoxCollider> ();
				foreach (BoxCollider collider in mangroveCollider) {
					collider.enabled = true;
				}
			}
			playerIndicator.GetComponent<Renderer> ().enabled = false;
			povUI.SetActive (true);
			mapUI.SetActive (false);
			mapTiles.SetActive (false);

			povCamera.SetActive (true);
			mapCamera.SetActive (false);

			player.GetComponent<MouseLook> ().enabled = true;
			player.GetComponent<CharacterMotorC> ().enabled = true;
			player.GetComponent<FPSInputControllerC> ().enabled = true;

			Cursor.lockState = CursorLockMode.Confined;
			Cursor.visible = true;


			Debug.Log ("POV Mode Enabled");

		} else {
			this.GetComponent<GameStats>().hints.SetActive (true);
			this.GetComponent<GameStats>().hintText.text = "Choose a tile";
			trashList = new List<GameObject>(GameObject.FindGameObjectsWithTag("Trash"));
			//Debug.Log (trashList.Count + " " + levelSetup.GetComponent<LevelSetUp> ().trashSpotList.Count);
			reedList = new List<GameObject>(GameObject.FindGameObjectsWithTag("Invasive"));
			//Debug.Log (reedList.Count + " " + levelSetup.GetComponent<LevelSetUp> ().reedSpotList.Count);
			mangroveList = new List<GameObject>(GameObject.FindGameObjectsWithTag("Mangrove"));

			foreach (GameObject reed in reedList) {
				reedCollider = reed.GetComponentsInChildren<BoxCollider> ();
				foreach (BoxCollider collider in reedCollider) {
					collider.enabled = false;
				}
			}
			foreach (GameObject trash in trashList) {
				trash.GetComponent<BoxCollider>().enabled = false;
			}
			foreach (GameObject mangrove in mangroveList) {
				mangroveCollider = mangrove.GetComponentsInChildren<BoxCollider> ();
				foreach (BoxCollider collider in mangroveCollider) {
					collider.enabled = false;
				}
			}

			playerIndicator.GetComponent<Renderer> ().enabled = true;
			povUI.SetActive (false);
			mapUI.SetActive (true);
			mapTiles.SetActive (true);

			povCamera.SetActive (false);
			mapCamera.SetActive (true);

			player.GetComponent<MouseLook> ().enabled = false;
			player.GetComponent<CharacterMotorC> ().enabled = false;
			player.GetComponent<FPSInputControllerC> ().enabled = false;

			Cursor.lockState = CursorLockMode.Confined;
			Cursor.visible = true;

			Debug.Log ("MAP Mode Enabled");
		}
	}
}
