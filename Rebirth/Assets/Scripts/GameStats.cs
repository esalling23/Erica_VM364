using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameStats : MonoBehaviour {

	private GameObject controller;

	private List<GameObject> trashList = new List<GameObject>();
	private List<GameObject> reedList = new List<GameObject>();
	private List<GameObject> mangroveList = new List<GameObject>();
	private List<GameObject> algaeList = new List <GameObject> ();
//	private GameObject[] tiles;

	public GameObject menu;
	public GameObject gameOverMenu;
	public GameObject gameWonMenu;
	public Text finalScores;

	public GameObject hints;
	public Text hintText;

	public Text tileData;
	public GameObject info;
	public GameObject button;

	private String timeText;
	public Text timeDisplay;
	private float time;
	public Text dayText;
	public Text scoreDisplay;
	private float score = 0;

	public GameObject seedling;
	public bool hasSeedling = false;
	private GameObject indicator;
	public Color has;
	public Color hasNot;

	public Vector3 tileCurrent;

	// Use this for initialization
	void Start () {
		menu.SetActive (true);
		info.SetActive (false);
		controller = GameObject.Find ("GameMaster");
//		tiles = controller.GetComponent<CameraViewControl> ().tiles;

		SeedlingIndicate ();

		hints.SetActive (true);
		hintText.text = "Click a tile to begin...";
	}
	
	// Update is called once per frame
	void Update () {
		DisplayTime ();
		CheckStats ();
	}
		
	public void GameEnd () {
//		menu.SetActive (true);
		gameOverMenu.SetActive (true);
		finalScores.text = "Lasted " + this.GetComponent<DayNightCycle> ().dayCount.ToString () + " days\nFinal score: " + score.ToString ();
	}

	public void GameWon() {
		gameWonMenu.SetActive (true);
		finalScores.text = "Rehabilitated the mangrove habitat after " + this.GetComponent<DayNightCycle> ().dayCount.ToString () + " days\nFinal score: " + score.ToString ();

	}

	public void Restart () {
		SceneManager.LoadScene ("Primary");
	}

	public void Quit () {
		Application.Quit ();
	}

	public void CheckStats () {
		SeedlingIndicate ();
		ScoreCount ();
	}

	public void DisplayTime () {
		timeText = (Mathf.Round (24 * this.GetComponent<DayNightCycle> ().currentTimeOfDay)).ToString () + ":00";
		timeDisplay.text = timeText;
		dayText.text = "Day " + this.GetComponent<DayNightCycle> ().dayCount.ToString();
//		Debug.Log ((Mathf.Round(24 * controller.GetComponent<DayNightCycle>().currentTimeOfDay)).ToString());
	}

	public void ScoreCount () {
//		trashList.Clear ();
//		reedList.Clear ();
//		mangroveList.Clear ();
//		algaeList.Clear ();
		score = 0;
		trashList = new List<GameObject>(GameObject.FindGameObjectsWithTag("Trash"));
		reedList = new List<GameObject>(GameObject.FindGameObjectsWithTag("Invasive"));
		mangroveList = new List<GameObject>(GameObject.FindGameObjectsWithTag("Mangrove"));
		algaeList = new List<GameObject>(GameObject.FindGameObjectsWithTag("Algae"));

		score = (algaeList.Count*2) + (mangroveList.Count*4) + (-(reedList.Count)*2) + (-(trashList.Count));

		if (mangroveList.Count == 0 && hasSeedling == false) {
			GameEnd ();
		}
		if (trashList.Count == 0 && reedList.Count == 0) {
			GameWon ();
		}
//		Debug.Log ((algaeList.Count * 2).ToString() + " plus " + (mangroveList.Count * 4).ToString() + " plus " + (-(reedList.Count) * 2).ToString() + " plus " + (-(trashList.Count)).ToString());
//		foreach (GameObject trash in trashList) {
//			score -= 1;
//			Debug.Log (score.ToString());
//		}
//
//		foreach (GameObject reed in reedList) {
//			score -= 2;
//			Debug.Log (score.ToString());
//		}
//		foreach (GameObject mangrove in mangroveList) {
//			score += 4;
//			Debug.Log (score.ToString());
//		}
//		foreach (GameObject algae in algaeList) {
//			score += 2;
//			Debug.Log (score.ToString());
//		}
		scoreDisplay.text = score.ToString ();
	}

	public void SeedlingIndicate() {
		if (hasSeedling == true) {
			seedling.GetComponent<Image> ().color = has;
		} else {
			seedling.GetComponent<Image> ().color = hasNot;
		}
	}
}
