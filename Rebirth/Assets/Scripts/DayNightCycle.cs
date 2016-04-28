using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;


public class DayNightCycle : MonoBehaviour {

	// The directional light which we manipulate as our sun.
	public Light sun;
	private GameObject moon;
	//public Light underwaterSun;
	public int dayCount = 1;
//	public int year = 2893;

	private Coroutine mangroveChange;
	private Coroutine reedChange;
	private Coroutine trashChange;

	private List<GameObject> mangroves = new List<GameObject> ();
	private List<GameObject> trash = new List<GameObject> ();
	private List<GameObject> reeds = new List<GameObject> ();
//	private List<GameObject> mangroves = new List<GameObject> ();

	private GameObject view;

	// The number of real-world seconds in one full game day.
	// Set this to 86400 for a 24-hour realtime day.
	public float secondsInFullDay = 120f;

	// The value we use to calculate the current time of day.
	// Goes from 0 (midnight) through 0.25 (sunrise), 0.5 (midday), 0.75 (sunset) to 1 (midnight).
	// We define ourself what value the sunrise sunrise should be etc., but I thought these 
	// values fit well. And now much of the script are hardcoded to these values.
	[Range(0,1)]
	public float currentTimeOfDay = 0;

	// A multiplier other scripts can use to speed up and slow down the passing of time.

	public float timeMultiplier = 1f;

	// Get the initial intensity of the sun so we remember it.
	float sunInitialIntensity;
	void Start() {
		view = GameObject.Find ("GameMaster");
		sunInitialIntensity = sun.intensity;
		moon = GameObject.Find ("Moon");
	}

	void Update() {

		if (Input.GetKeyDown (KeyCode.T)) {
			Debug.Log ("time multiplier is at " + timeMultiplier);
		}

//		if (view.GetComponent<CameraViewControl> ().povMode == true) {
			// Updates the sun's rotation and intensity according to the current time of day.
			UpdateSun ();

			// This makes currentTimeOfDay go from 0 to 1 in the number of seconds we've specified.
			currentTimeOfDay += (Time.deltaTime / secondsInFullDay) * timeMultiplier;

			// If currentTimeOfDay is 1 (midnight) set it to 0 again so we start a new day.
			if (currentTimeOfDay >= 1) {
				currentTimeOfDay = 0;
				dayCount++;
				this.GetComponent<GameStats> ().hintText.text = "Day changed!";
				DayChanged ();
			}
//			if (dayCount >= 365) {
//				year++;
//				dayCount = 1;
//			}

			if (Input.GetKeyDown (KeyCode.T)) {
				dayCount++;
				DayChanged ();
				Debug.Log ("day " + dayCount);
				Debug.Log ("time is " + currentTimeOfDay);
			}

//		} else {
//			UpdateSun ();

//			if (Input.GetKeyDown (KeyCode.T)) {
//				dayCount++;
//				DayChanged ();
//				Debug.Log ("day " + dayCount);
//				Debug.Log ("time is " + currentTimeOfDay);
//			}
//		}
	}

	public void DayChanged() {
		if (mangroveChange == null) {
			mangroveChange = StartCoroutine (MangroveChange (0.1f));
		}

		reeds.Clear ();
		trash.Clear ();
		reeds.AddRange(GameObject.FindGameObjectsWithTag("Invasive"));
		trash.AddRange(GameObject.FindGameObjectsWithTag("Trash"));


		foreach (GameObject reed in reeds) {
			reed.GetComponentInChildren<InvasiveReedBehavior> ().OnDayChange ();
		}
		foreach (GameObject t in trash) {
//			Debug.Log ("moving trash");
			t.GetComponent<TrashBehavior> ().OnDayChange ();
		}
	}

	public IEnumerator MangroveChange(float wait) {
		mangroves.Clear ();
		mangroves.AddRange(GameObject.FindGameObjectsWithTag("Mangrove"));
		foreach (GameObject mangrove in mangroves) {
			mangrove.GetComponent<MangroveBehavior> ().OnDayChange ();
			yield return new WaitForSeconds (wait);
		}
		yield return null;
		mangroveChange = null;
	}

	void UpdateSun() {
		// Rotate the sun 360 degrees around the x-axis according to the current time of day.
		// We subtract 90 degrees from this to make the sun rise at 0.25 instead of 0.
		// I just found that easier to work with.
		// The y-axis determines where on the horizon the sun will rise and set.
		// The z-axis does nothing.
		sun.transform.localRotation = Quaternion.Euler((currentTimeOfDay * 360f) - 90, 90, 0);

		// The following determines the sun's intensity according to current time of day.
		// You'll notice I have hardcoded a bunch of values here. They were just the values
		// I felt worked best. This can obviously be made to be user configurable.
		// Also with some more clever code you can have different lengths for the day and
		// night as well.

		// The sun is full intensity during the day.
		float intensityMultiplier = 1;
		// Set intensity to 0 during the night night.
		if (currentTimeOfDay <= 0.23f || currentTimeOfDay >= 0.75f) {
			
//			if (Input.GetKeyDown (KeyCode.T)) {
				//Debug.Log ("its night time");
//			}
			intensityMultiplier = 0;
			moon.SetActive (true);

		}
//		else if (currentTimeOfDay <= 0.32f || currentTimeOfDay >= 0.24f) {
//			intensityMultiplier = .5f;
//		}
//		else if (currentTimeOfDay <= 0.74f || currentTimeOfDay >= 0.64f) {
//			intensityMultiplier = .5f;
//		}
		// Fade in the sun when it rises.
		else if (currentTimeOfDay <= 0.25f) {
			moon.SetActive (false);
			// 0.02 is the amount of time between sunrise and the time we start fading out
			// the intensity (0.25 - 0.23). By dividing 1 by that value we we get get 50.
			// This tells us that we have to fade in the intensity 50 times faster than the
			// time is passing to be able to go from 0 to 1 intensity in the same amount of
			// time as the currentTimeOfDay variable goes from 0.23 to 0.25. That way we get
			// a perfect fade.
			intensityMultiplier = Mathf.Clamp01((currentTimeOfDay - 0.23f) * (1 / 0.02f));

//			Debug.Log ("run rising");
		}
		// And fade it out when it sets.
		else if (currentTimeOfDay >= 0.73f) {
			intensityMultiplier = Mathf.Clamp01(1 - ((currentTimeOfDay - 0.73f) * (1 / 0.02f)));
//			Debug.Log ("sun setting");
		}

		// Multiply the intensity of the sun according to the time of day.
		sun.intensity = sunInitialIntensity * intensityMultiplier;
	}
}