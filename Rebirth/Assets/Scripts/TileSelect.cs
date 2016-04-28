using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class TileSelect : MonoBehaviour, IPointerDownHandler, IResource {

	public IResource resource;
	private Fuel fuel;
	private GameObject control;

	private GameObject player;
	private GameObject playerBounds;

	private Text tileData;
	private string dataText;
	public List<String> dataList = new List<String>();

	public Vector3 tilePosition;
	public Vector3 playerPosition;
	public Color tileHighlight;
	public Color tileColor;

	private List<GameObject> trashList = new List<GameObject>();
	private List<GameObject> reedList = new List<GameObject>();
	private List<GameObject> mangroveList = new List<GameObject>();
	public bool reedPresent = false;
	public bool trashPresent = false;
	public bool mangrovePresent = false;
	public bool algaePresent = false;

	// Use this for initialization
	void Start () {
		
		player = GameObject.Find ("First Person Controller");
		playerBounds = GameObject.Find ("TileBounds");
		control = GameObject.Find ("GameMaster");
		fuel = control.GetComponent<Fuel> ();
		tileData = control.GetComponent<GameStats>().tileData;
		trashList = new List<GameObject>(GameObject.FindGameObjectsWithTag("Trash"));
		reedList = new List<GameObject>(GameObject.FindGameObjectsWithTag("Invasive"));
		mangroveList = new List<GameObject>(GameObject.FindGameObjectsWithTag("Mangrove"));
//		reedOption = GameObject.Find (
//		mapCamera = Camera.Find ("MapCamera");
		iTween.ColorTo(gameObject, iTween.Hash(
			"color", tileColor,
			"time", .1f

		));
		tilePosition = this.transform.position;
		TileReference ();

	}

	void Awake () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//TileReference ();
	}

	public void RyleesFunction() {

	}

	public void TileReference () {

		tilePosition = this.transform.position;
		dataList = new List<string> ();
		trashList.Clear ();
		trashList.AddRange (GameObject.FindGameObjectsWithTag ("Trash"));
		reedList.Clear ();
		reedList.AddRange (GameObject.FindGameObjectsWithTag ("Invasive"));
		mangroveList.Clear ();
		mangroveList.AddRange (GameObject.FindGameObjectsWithTag ("Mangrove"));
		reedPresent = false;
		trashPresent = false;
		mangrovePresent = false;
		algaePresent = false;


		foreach (GameObject reed in reedList) {
	//			Debug.Log (tilePosition + " tile; " + reed.transform.position + " reed");
			if (Mathf.Round (tilePosition.x) == reed.transform.position.x && Mathf.Round (tilePosition.z) == reed.transform.position.z) {
//				Debug.Log ("THERE IS A REED ON ME");
				dataList.Add ("an invasive reed species");
				reedPresent = true;
			}
		}

		foreach (GameObject trash in trashList) {
	//			Debug.Log (tilePosition + " tile; " + trash.transform.position + " trash");
			if (Mathf.Round (tilePosition.x) == trash.transform.position.x && Mathf.Round (tilePosition.z) == trash.transform.position.z) {
//				Debug.Log ("THERE IS A TRASH ON ME");
				dataList.Add ("trash");

				trashPresent = true;
			} 
		}

		foreach (GameObject mangrove in mangroveList) {
	//			Debug.Log (tilePosition + " tile; " + mangrove.transform.position + " mangrove");
			if ((Mathf.Round (tilePosition.x)) == mangrove.transform.position.x && (Mathf.Round (tilePosition.z)) == mangrove.transform.position.z) {
//				Debug.Log ("THERE IS A MANGROVE ON ME");

				dataList.Add ("a mangrove");
				mangrovePresent = true;
				if (mangrove.GetComponent<MangroveBehavior> ().algaeCount > 0) {
					dataList.Add (mangrove.GetComponent<MangroveBehavior> ().algaeCount.ToString() + " algae");
					algaePresent = true;
				}

			}
		}

		if (dataList.Count == 0) {
			dataList.Add ("nothing");
		}
	}

	public void TileOptions () {
//		Debug.Log (string.Join ("; ", dataList.ToArray ()));

		control.GetComponent<GameStats> ().tileCurrent = new Vector3 (playerPosition.x, 0, playerPosition.z);
		control.GetComponent<OptionsBehavior> ().options.SetActive (true);
		control.GetComponent<GameStats> ().button.GetComponent<Button>().interactable = true;
		if (trashPresent == true) {
			if (fuel.currentfuel >= 2) {
//				Debug.Log ("Trash Option; " + fuel.currentfuel);
				control.GetComponent<OptionsBehavior>().trashOption.SetActive (true);
	//			Debug.Log ("position should be " + playerPosition);
	//			Debug.Log ("position is " + control.GetComponent<CurrentTile>().tileCurrent);
			}
		} else {
			control.GetComponent<OptionsBehavior>().trashOption.SetActive (false);

		}
		if (reedPresent == true) {
			if (fuel.currentfuel >= 2) {
//			Debug.Log ("Reed Option; "  + fuel.currentfuel);
			control.GetComponent<OptionsBehavior>().reedOption.SetActive (true);
//			Debug.Log ("position should be " + playerPosition);
//			Debug.Log ("position is " + control.GetComponent<CurrentTile>().tileCurrent);
			}
		} else {
			control.GetComponent<OptionsBehavior>().reedOption.SetActive (false);
		}
		if (mangrovePresent == true) {
			control.GetComponent<OptionsBehavior> ().mangrovePlantOption.SetActive (false);
			if (fuel.currentfuel >= 3) {
//				Debug.Log ("Mangrove Clip Option; " + fuel.currentfuel);
//				Debug.Log (control.GetComponent<GameStats> ().hasSeedling);
				if (control.GetComponent<GameStats> ().hasSeedling == false) {
					control.GetComponent<OptionsBehavior> ().mangroveClipOption.SetActive (true);
					control.GetComponent<OptionsBehavior> ().mangrovePlantOption.SetActive (false);
				} else {
					control.GetComponent<OptionsBehavior> ().mangroveClipOption.SetActive (false);
					control.GetComponent<OptionsBehavior> ().mangrovePlantOption.SetActive (true);
				}
			} else {
				control.GetComponent<OptionsBehavior> ().mangroveClipOption.SetActive (false);
			}

			if (algaePresent == true) {
				control.GetComponent<OptionsBehavior> ().algaeOption.SetActive (true);
			} 
		} else {
			control.GetComponent<OptionsBehavior> ().algaeOption.SetActive (false);
			control.GetComponent<OptionsBehavior>().mangroveClipOption.SetActive (false);
			if (trashPresent == false && reedPresent == false && fuel.currentfuel >= 4) {
				if (control.GetComponent<GameStats> ().hasSeedling == true) {
//					Debug.Log ("Mangrove Plant Option; " + fuel.currentfuel);
					control.GetComponent<OptionsBehavior> ().mangrovePlantOption.SetActive (true);
				}
			} else {
				control.GetComponent<OptionsBehavior>().mangrovePlantOption.SetActive (false);
			}
		}
		if (fuel.currentfuel < 2 && algaePresent == false) {
			control.GetComponent<GameStats> ().button.GetComponent<Button>().interactable = false;
		}
		if (mangrovePresent == false && algaePresent == false && reedPresent == false && trashPresent == false && control.GetComponent<GameStats> ().hasSeedling == false) {
			control.GetComponent<GameStats> ().button.GetComponent<Button>().interactable = false;
		} 
	}

	public void Behavior () {
		control.GetComponent<GameStats>().hints.SetActive (false);
		playerPosition = new Vector3(tilePosition.x, 5, tilePosition.z);
		player.transform.position = playerPosition;
		playerBounds.transform.position = new Vector3(playerPosition.x, 0, playerPosition.z);
		control.GetComponent<CameraViewControl>().playerIndicator.GetComponent<Renderer> ().enabled = true;
		Debug.Log (player.transform.position);
//		Debug.Log ("placing player");

		TileReference ();

		TileOptions ();

		control.GetComponent<GameStats> ().info.SetActive (true);
		dataText = "This tile contains " + string.Join (" and ", dataList.ToArray ()) + ".";
		tileData.text = dataText;

		tilePosition = this.transform.position;
		control.GetComponent<GameStats> ().tileCurrent = tilePosition;

		control.GetComponent<OptionsBehavior> ().options.SetActive (true);
	}
				
	public void OnMouseEnter () {
		
		tilePosition = this.transform.position;
		//Debug.Log (tilePosition);
		iTween.ColorTo(gameObject, iTween.Hash(
			"color", tileHighlight,
			"time", .01f

		));
		TileReference ();

	}

	public void OnMouseExit () {
//		this.transform.position.y += 10;
		iTween.ColorTo(gameObject, iTween.Hash(
			"color", tileColor,
			"time", .01f

		));
	}

	public void OnPointerDown(PointerEventData e)
	{
//		Ray ray = mapCamera.ScreenPointToRay(Input.mousePosition);
//		RaycastHit hit;
//		if (Physics.Raycast (ray, out hit, 4f)) {
//			Debug.DrawLine (ray.origin, hit.point);
//			if (hit.collider) {
				//tilePosition = this.transform.position;

				//Events.instance.Raise (new ClickLandEvent (this));
				Debug.Log ("clicked tile!");
				Behavior();
//			}
//		}
	}
}
