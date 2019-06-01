using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
	public GameObject DialogPanel;
	public TMPro.TextMeshProUGUI textArea;
	public GameObject moreTextWidget;

	public static DialogManager Instance;
	private int currentIndex = 0;

	public Data.PlayerInputData inputData;

	public float speechSpeed = 20; // Letters per seconds

    // Start is called before the first frame update
    void Start()
    {
		Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void Init(Dialog dialog){

		StartCoroutine(DisplayBranch(dialog.texts[dialog.state],dialog.speech));
	}

	private IEnumerator DisplayBranch(DialogBranch dialogBranch, bool speech){
		DialogPanel.SetActive(true);
		inputData.enabled = false;
		for(int i = 0; i< dialogBranch.blocks.Length;i++){
			textArea.text = "";
			moreTextWidget.SetActive(false);
			if (speech) {
				dialogBranch.blocks[i].OnWrite.Invoke();
				for (int n = 1; n <= dialogBranch.blocks[i].text.Length; n++){
					textArea.text = dialogBranch.blocks[i].text.Substring(0, n);
					yield return new WaitForSecondsRealtime(1/speechSpeed);
					if ( n > 5 && Input.anyKey)
						n = dialogBranch.blocks[i].text.Length-1;
				}
			}
			else
			{
				textArea.text = dialogBranch.blocks[i].text;
				dialogBranch.blocks[i].OnWrite.Invoke();
			}
			yield return null;
			moreTextWidget.SetActive(true);
			while(!Input.anyKeyDown){
				yield return null;
			}
		}
		DialogPanel.SetActive(false);
		inputData.enabled = true;

		yield return null;
	}
}
