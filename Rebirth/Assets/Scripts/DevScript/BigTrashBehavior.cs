using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class BigTrashBehavior : MonoBehaviour, IResource, IPointerDownHandler {

    public GameObject hover;
    public Color color;
    public Color highlight;


	void Start()
	{
	}
	
	void Update()
	{
	}

    public void Behavior()
    {
       gameObject.SetActive(false);

    }

    public void OnMouseEnter()
    {
		hover.SetActive (true);
        //Debug.Log("Highlight Trash!");
		Events.instance.Raise (new HoverResourceEvent (this));
		iTween.ColorTo(gameObject, iTween.Hash(
            "color", highlight,
            "time", .1f

            ));
    }

    public void OnMouseExit()
    {
		hover.SetActive (false);
        //Debug.Log("Unhighlight Trash!");
        iTween.ColorTo(gameObject, iTween.Hash(
            "color", color,
            "time", .1f
            ));
    }

    public void OnPointerDown(PointerEventData e)
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 5f))
        {
            Debug.DrawLine(ray.origin, hit.point);
            if (hit.collider)
            {
                Events.instance.Raise(new ClickResourceEvent(this));
                Debug.Log("yes big trash!");
				Behavior ();
            }
        }
    }
}
