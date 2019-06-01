using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractor : MonoBehaviour
{
	private Interactable currentInteract;
	public Data.PlayerInputData input;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(input.GetButtonDown(Data.PlayerInputData.InputButton.Action1) && currentInteract)
		{
			currentInteract.Interact();
		}
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Interactable i;
		if(i = collision.GetComponent<Interactable>())
		{
			if (currentInteract)
				currentInteract.Display(false);
			currentInteract = i;
			currentInteract.Display(true);
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (collision.GetComponent<Interactable>() == currentInteract)
		{
			currentInteract.Display(false);
			currentInteract = null;
		}
	}
}
