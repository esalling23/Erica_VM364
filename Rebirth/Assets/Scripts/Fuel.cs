using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class Fuel : MonoBehaviour {

	public int currentfuel;
	public int maxfuel = 10;
	public Slider fuelslider;
	public Text fuelcount;

	void Awake () {
		currentfuel = 0;
		fuelslider.value = currentfuel;
		fuelcount.text = currentfuel.ToString() + " fuel";

//		Events.instance.AddListener<ClickResourceEvent>
//		(OnClickResourceEvent);
	}

	public void Fueling(int num) {
		currentfuel += num;
		fuelslider.value = currentfuel;
		fuelcount.text = currentfuel.ToString ();
	}

//	void OnClickResourceEvent(ClickResourceEvent e) {
//		if (e.resource is GrassBehavior) {
//			Fueling (-2);
//		}
//		if (e.resource is OilBehavior) {
//			Fueling (2);
//		}
//		if (e.resource is TrashBehavior) {
//			Fueling (2);
//		}
//		if (e.resource is BigTrashBehavior) {
//			Fueling (-2);
//		}
//	}

}
