using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class MangroveBehavior : MonoBehaviour, IResource {

	private GameObject control;
	private AlgaeBehavior[] algaeBehave;
//	public bool clipped = false;

	private int reedAttack = 0;
	private int trashAttack = 0;
	public int algaeCount = 0;
	private Vector3 algaePos1;
	private Vector3 algaePos2;
	private Vector3 algaePos3;

	private Vector3 mangrovePosition;
	private Vector3 mangroveRight;
	private Vector3 mangroveLeft;
	private Vector3 mangroveUp;
	private Vector3 mangroveDown;	
	private List<Vector3> destroySpots = new List<Vector3>();
	private List<GameObject> reedList = new List<GameObject>();
	private List<GameObject> trashList = new List<GameObject>();
	private List<GameObject> thisAlgaeList = new List <GameObject> ();

	public GameObject[] difAlgae;
	private GameObject algaeSpawn;
	private GameObject theAlgae;
	private Vector3 algaePosition = new Vector3();

	void Start () {
		control = GameObject.Find("GameMaster");
		algaeCount = thisAlgaeList.Count;
		Debug.Log(algaeCount);

	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnDayChange () {
		reedList.Clear ();
		trashList.Clear ();
		reedList.AddRange(GameObject.FindGameObjectsWithTag ("Invasive"));
		trashList.AddRange(GameObject.FindGameObjectsWithTag ("Trash"));

		mangrovePosition = new Vector3 (Mathf.Round (this.transform.position.x), 0, Mathf.Round (this.transform.position.z));
		mangroveRight = mangrovePosition + new Vector3 (10, 0, 0);
		//		Debug.Log (personRight + " person, " + playerPosition + " player");
		mangroveLeft = mangrovePosition + new Vector3 (-10, 0, 0);
		//		Debug.Log (personLeft + " person, " + playerPosition + " player");
		mangroveUp = mangrovePosition + new Vector3 (0, 0, 10);
		//		Debug.Log (personUp + " person, " + playerPosition + " player");
		mangroveDown = mangrovePosition + new Vector3 (0, 0, -10);
		//		Debug.Log (personDown + " person, " + playerPosition + " player");

//		Debug.Log ("the day changed.");
//		Debug.Log ("trash at position " + trash.transform.position.x + "x, " + trash.transform.position.z + "y");
		destroySpots.Clear();
		destroySpots.Add (mangrovePosition);
		destroySpots.Add (mangroveUp);
		destroySpots.Add (mangroveDown);
		destroySpots.Add (mangroveRight);
		destroySpots.Add (mangroveLeft);


		foreach (Vector3 position in destroySpots) {
			Debug.Log (position);
			foreach (GameObject reed in reedList) {
				if (Mathf.Approximately(position.x, reed.transform.position.x) && Mathf.Approximately(position.z, reed.transform.position.z)) {
					reedAttack++;
//					Debug.Log ("attacked " + reedAttack);

				}
			}
			foreach (GameObject trash in trashList) {
				if (Mathf.Approximately(position.x, trash.transform.position.x) && Mathf.Approximately(position.z, trash.transform.position.z)) {
					trashAttack++;
//					Debug.Log ("attacked " + trashAttack);

				}
			}
		}
//		Debug.Log ("attacked " + reedAttack);

		if (reedAttack >= 4) {
			Debug.Log ("MANGROVE at " + this.transform.position + " DESTROYED");
			Destroy (this.gameObject);
		} else {
			algaeCount = thisAlgaeList.Count;
			if (algaeCount <= 3) {
				AlgaeSpawn ();
				Debug.Log ("algae spawning...");
			}
		}
	}

	public void AlgaeSpawn() {
		algaePos1 = new Vector3 (this.transform.position.x, 3.1f, this.transform.position.z - 3);
		algaePos2 = new Vector3 (this.transform.position.x + 3, 3.1f, this.transform.position.z + 6);
		algaePos3 = new Vector3 (this.transform.position.x - 3, 3.1f, this.transform.position.z + 3);
		algaeCount = thisAlgaeList.Count;
		Debug.Log (algaeCount);
//		int random = Mathf.FloorToInt (Random.value * (float)difAlgae.Length);

		Debug.Log (algaeCount + "algae here");
		if (algaeCount == 0) {
			algaePosition = algaePos1;
			algaeSpawn = difAlgae [0];
		}
		if (algaeCount == 1){
			algaePosition = algaePos2; 
			algaeSpawn = difAlgae [1];
		}
		if (algaeCount == 2){
			algaePosition = algaePos3; 
			algaeSpawn = difAlgae [2];
		}
		theAlgae = (GameObject)Instantiate (algaeSpawn, algaePosition, Quaternion.identity);
		theAlgae.transform.position = algaePosition;
		theAlgae.transform.parent = this.transform;
		thisAlgaeList.Add (theAlgae);
		algaeCount = thisAlgaeList.Count;
		Debug.Log (algaeCount);
	}

	public void Behavior () {
		algaeBehave = this.GetComponentsInChildren<AlgaeBehavior> ();
		Debug.Log (algaeBehave.Length);
		foreach (AlgaeBehavior behavior in algaeBehave) {
			control.GetComponent<Fuel> ().Fueling (3);
			behavior.Behavior ();
			thisAlgaeList.Clear ();
			algaeCount = thisAlgaeList.Count;
		}
		control.GetComponent<TimeControl> ().TimeChange (0.1f);

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
