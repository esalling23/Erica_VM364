using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class GameMasterBackup: MonoBehaviour {

	public GameObject accessFuel;
//	public Slider healthslider;
//
//	public Text healthcount;
//	//public Text playerStats;
//	public GameObject Player;
//	public GameObject deadScreen;
//	
//	private int maxhealth = 100;
//	public int currenthealth;


	public GameObject grass;
	private bool grassAppear = false;
	public GameObject grassTwo;
	private bool grassTwoAppear = false;
	public GameObject grassThree;
	private bool grassThreeAppear = false;
	public GameObject palms;
	private bool palmsAppear = false;
	public GameObject palmsTwo;
	private bool palmsTwoAppear = false;
	public GameObject palmsThree;
	private bool palmsThreeAppear = false;
	public GameObject mangroves;
	private bool mangrovesAppear = false;

	public int trashStart = 12;
	public int trashRemaining;
	public int bigTrashStart = 9;
	public int bigTrashRemaining;
	public int oilStart = 35;
	public int oilRemaining;
	public int grassRemaining;
	public int grassStart = 16;
	public int mangroveStart = 8;
	public int mangroveRemaining;
	public int palmStart = 2;
	public int palmRemaining;
	
	//private float rate = 10;

	private int shrimpRemaining = 8;
	
//	private bool inWater = false;
//	private bool inDeepWater = false;
//	private bool heal = false;
//	private bool dead = false;

//	private IEnumerator healthLoss;	
//	private IEnumerator healthGain;

	//public float timeBetweenHealthUpdate = 10f;
	//float Timer;

	void Update () {
//		if (currenthealth <= 0) {
//			currenthealth = 0;
//		}
//		if (inWater == true) {
//			if (currenthealth == 0 && dead == false) {
//				Debug.Log ("gonna die");
//				Dead ();
//			} else {
//				Debug.Log("starting");
//				StartCoroutine (healthLoss);
//			}
//		} else {
//			StopCoroutine (healthLoss);
//		}
//		if (inDeepWater == true) {
//			if (currenthealth == 0 && dead == false) {
//				Debug.Log ("gonna die");
//				//dead = true;
//				Dead ();
//			} else {
//				Debug.Log("starting again");
//				StartCoroutine(healthLoss);
//			}
//
//		} else {
//			StopCoroutine (healthLoss);
//
//		}
//		if (heal == true) {
//			Debug.Log("starting heal");
//
//			StartCoroutine (healthGain);
//			//Health 
//		}  else {
//			StopCoroutine (healthGain);
//		}
//
		//Timer += Time.deltaTime;
	}

	// Use this for initialization
	void Awake () {

		trashRemaining = trashStart;
		oilRemaining = oilStart;
		grassRemaining = grassStart;
		palmRemaining = palmStart;
		mangroveRemaining = mangroveStart;
//		currenthealth = maxhealth;
//		healthslider.value = currenthealth;
//		healthcount.text = currenthealth.ToString();


//
//		healthLoss = HealthLoss();
//		healthGain = HealthGain ();

		Events.instance.AddListener<ClickResourceEvent>
			(OnClickResourceEvent);

	}

//	void OnTriggerEnter(Collider other) {
//		if (other.tag == "ShallowOcean") {
//			Debug.Log ("in ocean");
//			inWater = true;
//			//Health (-1);
//		}
//		if (other.tag == "DeepOcean") {
//			Debug.Log ("in deep ocean");
//			inDeepWater = true;
//			//Health (-2);
//		}
//		if (other.tag == "ground" && currenthealth < maxhealth) {
//			Debug.Log ("healing");
//			heal = true;
//			//Health (1);
//		}
//	}
//	
//	void OnTriggerExit(Collider other) {
//		if (other.tag == "ShallowOcean") {
//			inDeepWater = false;
//		}
//		if (other.tag == "DeepOcean") {
//			inWater = false;
//		}
//	}
//
//	IEnumerator HealthLoss () {
//			while (currenthealth > 0.0f) {
//			currenthealth += rate * Time.deltaTime;
//			healthslider.value = currenthealth;
//			healthcount.text = currenthealth.ToString();
//			Debug.Log (currenthealth);
//			yield return 0;
//		}
//		currenthealth = 0;
//		//return false;
//	}
//
//	IEnumerator HealthGain () {
//		while (currenthealth < maxhealth) {
//			currenthealth += rate * Time.deltaTime;
//			healthslider.value = currenthealth;
//			healthcount.text = currenthealth.ToString();
//			Debug.Log (currenthealth);
//			yield return 0;
//		}
//		currenthealth = maxhealth;
//	}
//
//
//	public void Dead() {
//		Debug.Log ("dead");
//		dead = true;
//		deadScreen.SetActive (true);
//		Player.GetComponent<CharacterMotorC> ().enabled = false;
//	}




	
	void OnClickResourceEvent(ClickResourceEvent e) {
		if (e.resource is GrassBehavior) {
			if (accessFuel.GetComponent<Fuel>().currentfuel >= 2) {
//				grassRemaining -= 1;
//				Debug.Log (accessFuel.GetComponent<Fuel>().currentfuel + " fuel and " + grassRemaining + " grass remaining");
//				if (grassRemaining == grassStart/2 && palmsAppear == false) {
//					Debug.Log ("palms appearing");
//					iTween.MoveBy(palms,iTween.Hash(
//						"y"   , .5,
//						"time", 1f
//						));
//					palmsAppear = true;
//					Debug.Log (palmsAppear);
//				}
//				if (grassRemaining == grassStart/3 && grassTwoAppear == false) {
//					Debug.Log ("grass2 appearing");
//					iTween.MoveBy(grassTwo,iTween.Hash(
//						"y"   , .15,
//						"time", 1f
//						));
//					grassRemaining = grassRemaining + grassStart;
//					grassTwoAppear = true;
//					Debug.Log (grassTwoAppear);
//				}
//				if (grassRemaining == 0 && grassThreeAppear == false) {
//					Debug.Log ("grass3 appearing");
//					iTween.MoveBy(grassThree,iTween.Hash(
//						"y"   , .15,
//						"time", 1f
//						));
//					grassRemaining = grassRemaining + grassStart;
//					grassThreeAppear = true;
//					Debug.Log (grassThreeAppear);
//				}
//				if (grassRemaining <= grassStart && palmsTwo == true && mangrovesAppear == false) {
//					Debug.Log ("mangroves appearing");
//					iTween.MoveBy(mangroves,iTween.Hash(
//						"y"   , .3,
//						"time", 1f
//						));
//					mangroveRemaining = mangroveStart;
//					mangrovesAppear = true;
//					Debug.Log (mangrovesAppear);
//				}
			} else {
				Debug.Log ("NO!");
				//play reject sound
				//reject message
			}
		}
		if (e.resource is OilBehavior) {
			if (accessFuel.GetComponent<Fuel>().currentfuel < accessFuel.GetComponent<Fuel>().maxfuel) {
				oilRemaining -= 1;
				accessFuel.GetComponent<Fuel>().Fueling (2);
				Debug.Log (accessFuel.GetComponent<Fuel>().currentfuel + " fuel and " + oilRemaining + " oil remaining");
				if (accessFuel.GetComponent<Fuel>().currentfuel >= 8 && grassAppear == false) {
					Debug.Log ("grass appearing");
					iTween.MoveBy(grass,iTween.Hash(
						"y"   , .15,
						"time", .5f
						));
					grassAppear = true;
					Debug.Log (grassAppear);

				}
			} else {
				Debug.Log ("NO!");

				//play reject sound
				//reject message
			}
		}
		if (e.resource is MangroveBehavior) {
			if (mangroveRemaining == 0 && accessFuel.GetComponent<Fuel>().currentfuel == 10) {
					shrimpRemaining -= 1;
					accessFuel.GetComponent<Fuel>().Fueling (-10);
				Debug.Log (accessFuel.GetComponent<Fuel>().currentfuel + " fuel and " + shrimpRemaining + " shrimp remaining");
				} else {
					if (mangroveRemaining >= 1) {
						mangroveRemaining -= 1;
						accessFuel.GetComponent<Fuel>().Fueling (-8);
					Debug.Log (accessFuel.GetComponent<Fuel>().currentfuel + " fuel and " + mangroveRemaining + " mangrove remaining");
					}
			}

		}
		if (e.resource is TrashBehavior)
		{
			if (accessFuel.GetComponent<Fuel>().currentfuel < accessFuel.GetComponent<Fuel>().maxfuel) {
				trashRemaining -= 1;
				accessFuel.GetComponent<Fuel>().Fueling (4);
				Debug.Log (accessFuel.GetComponent<Fuel>().currentfuel + " fuel and " + trashRemaining + " trash remaining");
				if (accessFuel.GetComponent<Fuel>().currentfuel >= 8 && grassAppear == false) {
					Debug.Log ("grass appearing");
					iTween.MoveBy(grass,iTween.Hash(
						"y"   , .1,
						"time", 1f
						));
					grassAppear = true;
					Debug.Log (grassAppear);
				}
			} else {
				Debug.Log ("NO!");

				//play reject sound
				//reject message
			}
		}
		if (e.resource is BigTrashBehavior)
		{
			if (accessFuel.GetComponent<Fuel>().currentfuel <= 4) {
				bigTrashRemaining -= 1;
				accessFuel.GetComponent<Fuel>().Fueling (6);
				Debug.Log (accessFuel.GetComponent<Fuel>().currentfuel + " fuel and " + bigTrashRemaining + " bigTrash remaining");
			} else {
				Debug.Log ("NO!");

				//play reject sound
				//reject message
			}
		}
		if (e.resource is PalmBehavior)
		{
			if (accessFuel.GetComponent<Fuel>().currentfuel >= 4) {
				palmRemaining -= 1;
				accessFuel.GetComponent<Fuel>().Fueling (-4);
				Debug.Log (accessFuel.GetComponent<Fuel>().currentfuel + " fuel and " + palmRemaining + " palms remaining");
				if (palmRemaining == palmStart/2 && palmsTwoAppear == false) {
					Debug.Log ("palms2 appearing");
					iTween.MoveBy(palmsTwo,iTween.Hash(
						"y"   , .2,
						"time", 1f
						));
					palmRemaining = palmRemaining + 5;
					palmsTwoAppear = true;
					Debug.Log (palmsTwoAppear);
				}
				if (palmRemaining == palmStart/2 && palmsThreeAppear == false) {
					Debug.Log ("palms3 appearing");
					iTween.MoveBy(palmsThree,iTween.Hash(
						"y"   , .3,
						"time", 1f
						));
					palmRemaining = palmRemaining + 4;
					palmsThreeAppear = true;
					Debug.Log (palmsThreeAppear);
				}
				if (grassRemaining <= grassStart && palmsTwoAppear == true && mangrovesAppear == false) {
					Debug.Log ("mangroves appearing");
					iTween.MoveBy(mangroves,iTween.Hash(
						"y"   , .3,
						"time", 1f
						));
					mangroveRemaining = mangroveRemaining + 4;
					mangrovesAppear = true;
					Debug.Log (mangrovesAppear);
				}
			} else {
				Debug.Log ("NO!");

				//play reject sound
				//reject message
			}
		}

	}     

}
