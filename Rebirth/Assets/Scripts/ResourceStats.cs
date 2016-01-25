using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class ResourceStats: MonoBehaviour {

	public GameObject accessGM;

//	public GameObject hover;
//	public Text resourceStat;
	public Text resourceName;
//	public Text resourceType;



//	public GameObject OilInfo;
//	public GameObject TrashInfo;
//	public GameObject GrassInfo;
//	public GameObject FernInfo;
//	public GameObject PalmInfo;
//	public GameObject PineInfo;
//	public GameObject MangroveInfo;


	// Use this for initialization
	void Awake () {
		//hover.SetActive(false);
		Events.instance.AddListener<HoverResourceEvent>
			(OnHoverResourceEvent);
	}

	void OnHoverResourceEvent(HoverResourceEvent e) {
		if (e.hoverResource is SandBehavior) {
			Debug.Log ("hovering land");
			resourceName.text = "sand detected";

		}
		if (e.hoverResource is OilBehavior) {
			Debug.Log ("hovering");
			resourceName.text = "oil detected";
//			resourceType.text = "POLLUTION";
//			resourceStat.text = "CLEAN_UP_REWARDS\n + 2 FUEL";

		}
		if (e.hoverResource is InvasiveReedBehavior) {
			Debug.Log ("hovering invasive");
			resourceName.text = "invasive reed species detected";
		}
//		if (e.hoverResource is MangroveBehavior) {
//			Debug.Log ("hovering");
//			if (accessGM.GetComponent<GameMaster>().mangroveRemaining == 0) {
//				resourceName.text = "SHRIMP_HABITAT:";
//				resourceType.text = "ANIMAL_SPECIES";
//				resourceStat.text = "REHAB_COSTS\n - 8 FUEL";
//			} else {
//				resourceName.text = "MANGROVE: ";
//				resourceType.text = "PLANT_SPECIES";
//				resourceStat.text = "REHAB_COSTS\n - 6 FUEL";
//			}
//		}
//        if (e.hoverResource is TrashBehavior)
//        {
//			Debug.Log ("hovering");
//			resourceName.text = "TRASH: ";
//			resourceType.text = "POLLUTION";
//			resourceStat.text = "CLEAN_UP_REWARDS\n + 2 FUEL";
//
//
//		}
//		if (e.hoverResource is BigTrashBehavior)
//		{
//			Debug.Log ("hovering");
//			resourceName.text = "TRASH: ";
//			resourceType.text = "POLLUTION";
//			resourceStat.text = "CLEAN_UP_REWARDS\n + 4 FUEL";
//			
//			
//		}
//        if (e.hoverResource is PalmBehavior)
//        {
//			Debug.Log ("hovering");
//			resourceName.text = "PALM: ";
//			resourceType.text = "PLANT_SPECIES";
//			resourceStat.text = "REHAB_COSTS\n + 4 FUEL";
//		}
		if (e.hoverResource is InvasiveSpecies) 
		{
			Debug.Log ("hovering invasive reed");
		}
       
    }
}
