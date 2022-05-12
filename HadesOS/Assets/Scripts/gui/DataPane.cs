using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

namespace gui
{
	public class DataPane : MonoBehaviour
	{
		// public SerialConfigPane serialConfigPane;
		public BNOCalPane bnoCalPane;
		public BNODataPane bnoDataPane;
		
		private static List<string> _inputArr;
		
		public void ParseSerial(string input)
		{
			_inputArr = input.Split(',').ToList();
        
			switch (_inputArr[0])
			{
				case "bno_cal_status":
				{
					bnoCalPane.SetBnoSysCal(_inputArr[1]);
					bnoCalPane.SetBnoGyroCal(_inputArr[2]);
					bnoCalPane.SetBnoAccelCal(_inputArr[3]);
					bnoCalPane.SetBnoMagCal(_inputArr[4]);
					break;
				}

				case "bno_euler":
				{
					bnoDataPane.SetEulerX(_inputArr[1]);
					bnoDataPane.SetEulerY(_inputArr[2]);
					bnoDataPane.SetEulerZ(_inputArr[3]);
					break;
				}

				case "bno_angVel":
				{
					bnoDataPane.SetAngVelX(_inputArr[1]);
					bnoDataPane.SetAngVelY(_inputArr[2]);
					bnoDataPane.SetAngVelZ(_inputArr[3]);
					break;
				}

				case "bno_linAccel":
				{
					bnoDataPane.SetLinAccelX(_inputArr[1]);
					bnoDataPane.SetLinAccelY(_inputArr[2]);
					bnoDataPane.SetLinAccelZ(_inputArr[3]);
					break;
				}
			}
		}

		public static TMP_Text getTextField(GameObject obj)
		{
			return obj.transform.Find("FieldText").GetComponent<TMP_Text>();
		}
	}
}