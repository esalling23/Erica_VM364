using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class InvasiveReedBehavior : MonoBehaviour, IResource {

	public GameObject newReed;
	private Vector3 reedPosition;
	private Vector3 reedUp;
	private Vector3 reedDown;
	private Vector3 reedRight;
	private Vector3 reedLeft;
	private List<Vector3> destroySpots = new List<Vector3>();

	private GameObject[] tileList;
	private TileSelect tileReference;
//	private Vector3 marshPosition = new Vector3();
//	private Vector3 otherReed = new Vector3();
//	private Vector3 mangrovePosition = new Vector3();
	public List<GameObject> reedList = new List<GameObject>();
	public List<GameObject> mangroveList = new List<GameObject>();

	private GameObject control;
	private int lastDayNum;
	private int dayNum;



//	DayNightCycle controller;
	// Use this for initialization
	void Start () {
		control = GameObject.Find ("GameMaster");
//		dayNum = control.GetComponent<DayNightCycle> ().dayCount;
		lastDayNum = control.GetComponent<DayNightCycle> ().dayCount;
//		reedPosition = this.transform.position;
		tileList = GameObject.FindGameObjectsWithTag ("Tile");
	}
	
	// Update is called once per frame
	void Update () {
		
//		if (lastDayNum != dayNum)
//		{
//			Debug.Log ("day " + lastDayNum + " changed to day " + dayNum);
//			Debug.Log ("calling day change now.....");
//			OnDayChange();
//			lastDayNum = dayNum;
//		}
	}

	public void OnDayChange () {
//		Debug.Log ("yesterday was " + lastDayNum + ", today is " + dayNum);

		mangroveList.Clear ();
		reedList.Clear ();
		mangroveList.AddRange (GameObject.FindGameObjectsWithTag ("Mangrove"));
		reedList.AddRange(GameObject.FindGameObjectsWithTag ("Invasive"));

		reedPosition = new Vector3 (Mathf.Round (this.transform.position.x), 0, Mathf.Round (this.transform.position.z));
		reedRight = reedPosition + new Vector3 (10, 0, 0);
		reedLeft = reedPosition + new Vector3 (-10, 0, 0);
		reedUp = reedPosition + new Vector3 (0, 0, 10);
		reedDown = reedPosition + new Vector3 (0, 0, -10);

		destroySpots.Clear();
//		destroySpots.Add (reedPosition);
		destroySpots.Add (reedUp);
		destroySpots.Add (reedDown);
		destroySpots.Add (reedRight);
		destroySpots.Add (reedLeft);

		foreach (GameObject tile in tileList) {
			tileReference = tile.GetComponent<TileSelect> ();
			tileReference.TileReference();
			foreach (Vector3 position in destroySpots) {
				if (Mathf.Approximately(tileReference.tilePosition.x, position.x) && Mathf.Approximately(tileReference.tilePosition.z, position.z)) {
//					Debug.Log ("found tile");
					if (tileReference.reedPresent != true && tileReference.mangrovePresent != true){
//						Debug.Log ("time to spread");
						Instantiate (newReed, position, Quaternion.identity);

					}

				}
//				Debug.Log (marshPosition + " marsh spot position");
//				if (Mathf.Approximately(position.x, marshPosition.x) && Mathf.Approximately(position.z, marshPosition.y)) {
//					Debug.Log ("reed growth POTENTIAL");
//					foreach (GameObject reed in reedList) {
//						otherReed = reed.transform.position;
//						if (position.x != otherReed.x && position.z != otherReed.z) {
//							Debug.Log ("reed growth???");
//
//
//						}
//					}
//				} 
			}

//			foreach (GameObject mangrove in mangroveList) {
//				mangrovePosition = mangrove.transform.position;
//				if (position.x != mangrovePosition.x && position.z != mangrovePosition.z) {
//					Debug.Log ("reed growth");
//					Instantiate (reed, position, Quaternion.identity);
//				} 
//			}
		}
	}

	public void Behavior () {
//		Debug.Log (control.GetComponent<DayNightCycle> ().currentTimeOfDay);
		control.GetComponent<TimeControl> ().TimeChange(0.1f);
		control.GetComponent<Fuel> ().BioMatter (10);
//		Debug.Log (control.GetComponent<DayNightCycle> ().currentTimeOfDay);
		Destroy (this.transform.parent.gameObject);
		Debug.Log ("destroyed reed");
	} 


//	public void OnMouseEnter () {
//		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//		RaycastHit hit;
//		if (Physics.Raycast (ray, out hit, 4f)) {
//			Debug.DrawLine (ray.origin, hit.point);
//			if (hit.collider) {
//				Events.instance.Raise (new HoverResourceEvent (this));
//				//hoverRoots.SetActive (true);
//			}
//		}
//	}

//	public void OnMouseExit () {
//		hoverRoots.SetActive (false);
//	}

//	public void OnPointerDown(PointerEventData e)
//	{
//		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//		RaycastHit hit;
//		if (Physics.Raycast (ray, out hit, 4f)) {
//			Debug.DrawLine (ray.origin, hit.point);
//			if (hit.collider) {
//				//Events.instance.Raise (new ClickResourceEvent (this));
//				Debug.Log ("clicked roots of reed!");
//				Behavior();
//			}
//		}
//	}
}
