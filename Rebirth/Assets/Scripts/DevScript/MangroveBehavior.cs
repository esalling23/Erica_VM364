using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class MangroveBehavior : MonoBehaviour, IResource, IPointerDownHandler {

	public GameObject accessGM;
	public GameObject accessFuel;

	public Color color;
	public Color highlight;
	public float speed;


	private BoxCollider collider;

	public GameObject hover;

	public GameObject Roots;
	public GameObject Top;
	public GameObject Shrimp;

	private bool clicked = false;

	// Use this for initialization
	void Start () {
		iTween.ColorTo (gameObject, iTween.Hash (
			"color", color
			));

		collider = this.GetComponent<BoxCollider>();

	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnMouseEnter()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 2f)) {
			Debug.DrawLine (ray.origin, hit.point);
			if (hit.collider) {
				if (clicked == false) {
					iTween.ColorTo (gameObject, iTween.Hash (
						"color", highlight, 
						"time", .1f
						
					));
					hover.SetActive (true);
					Events.instance.Raise (new HoverResourceEvent (this));
				}
			}
		}
	}

	public void OnMouseExit()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 2f)) {
			Debug.DrawLine (ray.origin, hit.point);
			if (hit.collider) {
				if (clicked == false) {

					iTween.ColorTo (gameObject, iTween.Hash (
						"color", color, 
						"time", .1f
						
					));
					hover.SetActive (false);
				}
			}
		}
		//Events.instance.Raise (new HoverResourceEvent (this));
	}

	public void OnPointerDown(PointerEventData e)
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 2f)) {
			Debug.DrawLine (ray.origin, hit.point);
			if (hit.collider) {
				if (accessFuel.GetComponent<Fuel>().currentfuel >= 8) {
					Events.instance.Raise (new ClickResourceEvent (this));
					Debug.Log ("yes mangrow!");
//					if (accessGM.GetComponent<GameMaster>().mangroveRemaining == 0 && accessGM.GetComponent<GameMaster>().currentfuel >= 8) {
//						Shrimp.SetActive(true);
//					} else {
						Shrimp.SetActive(true);
						Behavior();
						clicked = true;
					//}
				}
			}
		}
		
		
	}
	
	public void Behavior ()
	{
		Debug.Log("Mangrove Growing!");
		iTween.MoveBy(Top,iTween.Hash(
			"y"   , 2.0,
			"time", 4.0f
			));
		iTween.MoveBy(Roots,iTween.Hash(
			"y"   , .8,
			"time", 2.0f
			));
		collider.enabled = false;

	}
}
