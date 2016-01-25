using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class PalmBehavior : MonoBehaviour, IResource, IPointerDownHandler {

	public GameObject accessGM;
	public GameObject accessFuel;

    public GameObject hover;
    public Color highlight;
    public Color color;

	private Animator anim;

	private BoxCollider collider;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		collider = this.GetComponent<BoxCollider>();
    }
	
	// Update is called once per frame
	void Update () {
	}

    public void Behavior()
    {
        Debug.Log("Palm Growing!");
        //play animation
		anim.SetTrigger ("Palming");
		collider.enabled = false;
    }


    public void OnMouseEnter()
    {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 2f)) {
			Debug.DrawLine (ray.origin, hit.point);
			if (hit.collider) {
				//Debug.Log("Highlight Palm!");
				hover.SetActive (true);
				Events.instance.Raise (new HoverResourceEvent (this));
				iTween.ColorTo (gameObject, iTween.Hash (
		            "color", highlight,
		            "time", .1f
				));
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
				hover.SetActive (false);
				// Debug.Log("Unhighlight Palm!");
				iTween.ColorTo (gameObject, iTween.Hash (
		            "color", color,
		            "time", .1f
				));
			}
		}
    }

    public void OnPointerDown(PointerEventData e)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 3f))
        {
            Debug.DrawLine(ray.origin, hit.point);
            if (hit.collider)
            {
				if (accessFuel.GetComponent<Fuel>().currentfuel >= 2) { 
	                Events.instance.Raise(new ClickResourceEvent(this));
					Behavior();
				}
            }
        }


    }

}
