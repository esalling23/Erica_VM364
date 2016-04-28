using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class ClickLandEvent : GameEvent {
	public IResource clickLand;

	public ClickLandEvent(IResource clickLand) {
		this.clickLand = clickLand;
	}
}
