using TMPro;
using UnityEngine;

namespace gui
{
	public class BNOCalPane : MonoBehaviour
	{
		public GameObject gyroCal;
		TMP_Text gyroCalText;

		public GameObject accelCal;
		TMP_Text accelCalText;

		public GameObject magCal;
		TMP_Text magCalText;
		
		void Start()
		{
			gyroCalText = gyroCal.transform.Find("FieldText").GetComponent<TMP_Text>();
			accelCalText = accelCal.transform.Find("FieldText").GetComponent<TMP_Text>();
			magCalText = magCal.transform.Find("FieldText").GetComponent<TMP_Text>();
		}
		
		public void SetBnoGyroCal(string calStatus)
		{
			gyroCalText.text = calStatus;
			gyroCalText.color = calStatus.Equals("0") ? Color.red : Color.green;
		}
		
		public void SetBnoAccelCal(string calStatus)
		{
			accelCalText.text = calStatus;
			accelCalText.color = calStatus.Equals("0") ? Color.red : Color.green;
		}
		
		public void SetBnoMagCal(string calStatus)
		{
			magCalText.text = calStatus;
			magCalText.color = calStatus.Equals("0") ? Color.red : Color.green;
		}
	}
}