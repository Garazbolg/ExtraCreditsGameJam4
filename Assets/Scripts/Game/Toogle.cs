using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class BoolUnityEvent : UnityEvent<bool>
{ }

public class Toogle : Interactable
{
	public bool active = false;

	public BoolUnityEvent ToogleEvents;
	public GameObject AlternativeDisplayObject;

	public override void Interact()
	{
		active = !active;
		Display(true);
		base.Interact();
		ToogleEvents.Invoke(active);
	}

	public override void Display(bool activea)
	{
		AlternativeDisplayObject.SetActive(active && activea);
		DisplayObject.SetActive(!active && activea);
	}
}
