using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class OilBehavior : MonoBehaviour, IResource, IPointerDownHandler {

	public GameObject accessGM;
	public GameObject accessFuel;

	public Color color;
	public Color clean;
	public Color highlight;

	//private  behavior;
	public GameObject hover;

	bool clicked = false;

	void Start () {
		iTween.ColorTo(gameObject, iTween.Hash(
			"color", color
			));
		//behavior = this.GetComponent("OilBehavior");
	}

	public void Behavior () {
		if (clicked == false) {
			Debug.Log ("Oil Cleaned Up!");
			//play animation
			iTween.ColorTo (gameObject, iTween.Hash (
				"color", clean, 
				"time", 0.5f
			));
			iTween.MoveBy(gameObject,iTween.Hash(
				"y"   , -.2,
				"time", 1f
				));
		}
	}

    public void OnMouseEnter()
    {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 2f)) {
			Debug.DrawLine (ray.origin, hit.point);
			if (hit.collider) {
				if (clicked == false) {
					Debug.Log ("Highlight Oil!");
					hover.SetActive (true);
					Events.instance.Raise (new HoverResourceEvent (this));
					iTween.ColorTo (gameObject, iTween.Hash (
		            "color", highlight,
		            "time", .01f

					));
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
					Debug.Log ("Unhighlight Oil!");
					hover.SetActive (false);
					iTween.ColorTo (gameObject, iTween.Hash (
		            "color", color,
		            "time", .01f
					));
				}
			}
		}
    }

    public void OnPointerDown(PointerEventData e)
	{
		if (clicked == false) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit, 2f)) {
				Debug.DrawLine (ray.origin, hit.point);
				if (hit.collider) {
					if (accessFuel.GetComponent<Fuel>().currentfuel <= 9) { 
						Events.instance.Raise (new ClickResourceEvent (this));
						Debug.Log ("yes oil!");
						Behavior ();
						clicked = true;
					}
				}
			}
		}
	}
}
