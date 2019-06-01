using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogBloc
{
	[TextArea]
	public string text;
	public UnityEngine.Events.UnityEvent OnWrite;
}

[System.Serializable]
public class DialogBranch
{
	[Tooltip("Just for dev purposes, never used in the actual game")]
	public string name;
	public DialogBloc[] blocks;
}

public class Dialog : Interactable
{
	[Tooltip("Define if the text should be displayed all at once or little by little(characters speaking)")]
	public bool speech;
	public int state = 0;
	public DialogBranch[] texts;

	public override void Interact()
	{
		base.Interact();
		DialogManager.Instance.Init(this);
	}

	public void SetState(int newState){
		state = newState;
	}
}
