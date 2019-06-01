using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
	public UnityEvent OnInteract;
	public GameObject DisplayObject;

	private void Start()
	{
		Display(false);
	}

	public virtual void Interact()
	{
		OnInteract.Invoke();
	}

	public virtual void Display(bool active)
	{
		DisplayObject.SetActive(active);
	}
}
