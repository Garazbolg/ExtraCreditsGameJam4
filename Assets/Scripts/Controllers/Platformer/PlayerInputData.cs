using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data
{
	using Variables;

	[CreateAssetMenu(fileName ="New Player Input Preset",menuName ="Data/Player Input")]
	[System.Serializable]
	public class PlayerInputData : DataBase
	{
		public bool enabled = true;

		[System.Serializable]
		public enum InputButton{
			Jump = 0,
			Action1 = 1,
			Action2 = 2,
			Action3 = 3,
			Action4 = 4
			}
		public enum InputAxis{
			X  = 5,
			Y  = 6,
			X2 = 7,
			Y2 = 8
			}

		[Tooltip("Button Indexes :\nJump = 0\nAction1 = 1\nAction2 = 2\nAction3 = 3\nAction4 = 4\n\nAxis Indexes : \nX = 5\nY = 6\nX2 = 7\nY2 = 8")]
		public StringReference[] inputStrings;

		public bool GetButton(InputButton input){
			return enabled && Input.GetButton(inputStrings[(int)input]);
		}

		public bool GetButtonUp(InputButton input)
		{
			return enabled && Input.GetButtonUp(inputStrings[(int)input]);
		}

		public bool GetButtonDown(InputButton input)
		{
			return enabled && Input.GetButtonDown(inputStrings[(int)input]);
		}

		public float GetAxis(InputAxis input){
			return enabled ? Input.GetAxisRaw(inputStrings[(int)input]) : 0;
		}
	}
}
