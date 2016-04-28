using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class TrashBehavior : MonoBehaviour, IResource {

//	public GameObject roots;
//	public GameObject hoverRoots;

	private GameObject control;

	private int lastDayNum;
	private int dayNum;

	private GameObject[] tileList;
	private TileSelect tileReference;

	private Vector3 trashPosition;
	private Vector3 trashRight;
	private Vector3 trashLeft;
	private Vector3 trashUp;
	private Vector3 trashDown;
	private Vector3 moveSpot;
	private List<Vector3> destroySpots = new List<Vector3>();
	private List<Vector3> openSpots = new List<Vector3>();

	void Start () {
		control = GameObject.Find("GameMaster");
		dayNum = control.GetComponent<DayNightCycle> ().dayCount;
		lastDayNum = control.GetComponent<DayNightCycle> ().dayCount;
		tileList = GameObject.FindGameObjectsWithTag ("Tile");

	}
	
	// Update is called once per frame
	void Update () {
//		dayNum = control.GetComponent<DayNightCycle> ().dayCount;
//
//			if (lastDayNum != dayNum)
//			{
//			Debug.Log ("day " + lastDayNum + " changed to day " + dayNum);
//				OnDayChange();
//				lastDayNum = dayNum;
//			}
	}

	public void OnDayChange () {
		
		trashPosition = new Vector3 (Mathf.Round (this.transform.position.x), 0, Mathf.Round (this.transform.position.z));
		trashRight = trashPosition + new Vector3 (10, 0, 0);
		//		Debug.Log (personRight + " person, " + playerPosition + " player");
		trashLeft = trashPosition + new Vector3 (-10, 0, 0);
		//		Debug.Log (personLeft + " person, " + playerPosition + " player");
		trashUp = trashPosition + new Vector3 (0, 0, 10);
		//		Debug.Log (personUp + " person, " + playerPosition + " player");
		trashDown = trashPosition + new Vector3 (0, 0, -10);
		//		Debug.Log (personDown + " person, " + playerPosition + " player");

//		Debug.Log ("the day changed.");
//		Debug.Log ("trash at position " + trash.transform.position.x + "x, " + trash.transform.position.z + "y");
		destroySpots.Clear();
//		destroySpots.Add (trashPosition);
		destroySpots.Add (trashUp);
		destroySpots.Add (trashDown);
		destroySpots.Add (trashRight);
		destroySpots.Add (trashLeft);

		openSpots.Clear ();

		foreach (GameObject tile in tileList) {
			tileReference = tile.GetComponent<TileSelect> ();
			tileReference.TileReference ();
			foreach (Vector3 position in destroySpots) {
				if (Mathf.Approximately(tileReference.tilePosition.x, position.x) && Mathf.Approximately(tileReference.tilePosition.z, position.z)) {
					//					Debug.Log ("found tile");
					if (tileReference.trashPresent != true || tileReference.mangrovePresent != true) {
//						Debug.Log (position + "is open");
						openSpots.Add (position);
					}
//					if (tileReference.mangrovePresent != true) {
//						Debug.Log (position + "removed");
//						destroySpots.Remove (position);
//					}

				}
			}
		}

		int spotIndex = Mathf.FloorToInt (Random.value * (float)openSpots.Count);
//		Debug.Log (spotIndex + " out of " + openSpots.Count);
		moveSpot = openSpots [spotIndex];
		this.transform.position = moveSpot;
//		Debug.Log ("trash moved to " + moveSpot);

	}

	public void Behavior () {
//		Debug.Log (control.GetComponent<DayNightCycle> ().currentTimeOfDay);
		control.GetComponent<TimeControl> ().TimeChange(0.2f);
		control.GetComponent<Fuel> ().BioMatter (8);
//		Debug.Log (control.GetComponent<DayNightCycle> ().currentTimeOfDay);
		Destroy (this.gameObject);
		Debug.Log ("destroyed trash");

	} 

//	public void OnMouseEnter () {
//		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//		RaycastHit hit;
//		if (Physics.Raycast (ray, out hit, 4f)) {
//			Debug.DrawLine (ray.origin, hit.point);
//			if (hit.collider) {
//				//Events.instance.Raise (new HoverResourceEvent (this));
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
//				Debug.Log ("clicked trash!");
//				//Behavior();
//			}
//		}
//	}
}
