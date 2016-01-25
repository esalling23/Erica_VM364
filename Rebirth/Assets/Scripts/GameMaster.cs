using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class GameMaster : MonoBehaviour {

	public GameObject accessFuel;

	private bool unearthedRoots = false;
//	public GameObject roots;

	void Update () {
		
	}

	// Use this for initialization
	void Awake () {
		Events.instance.AddListener<ClickResourceEvent>
			(OnClickResourceEvent);
	}

	void OnClickResourceEvent(ClickResourceEvent e) {
		if (e.resource is InvasiveReedBehavior) {
//			roots.SetActive (enabled);
		}
		if (e.resource is GrassBehavior) {
			if (accessFuel.GetComponent<Fuel>().currentfuel >= 2) {
				
			} else {
				Debug.Log ("NO!");
				//play reject sound
				//reject message
			}
		}
		if (e.resource is OilBehavior) {
			if (accessFuel.GetComponent<Fuel>().currentfuel < accessFuel.GetComponent<Fuel>().maxfuel) {
				
			} else {
				Debug.Log ("NO!");

				//play reject sound
				//reject message
			}
		}
		if (e.resource is MangroveBehavior) {
			

		}
		if (e.resource is TrashBehavior)
		{
			
		}
		if (e.resource is BigTrashBehavior)
		{
			
		}
		if (e.resource is PalmBehavior)
		{
			
		}

	}     

}
