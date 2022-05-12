using System;
using TMPro;
using UnityEngine;

namespace gui
{
	public class BNODataPane : MonoBehaviour
	{
		public GameObject eulerX;
		TMP_Text eulerXText;
        
		public GameObject eulerY;
		TMP_Text eulerYText;
        
		public GameObject eulerZ;
		TMP_Text eulerZText;

		public GameObject linAccelX;
		TMP_Text linAccelXText;
		
		public GameObject linAccelY;
		TMP_Text linAccelYText;
		
		public GameObject linAccelZ;
		TMP_Text linAccelZText;

		public GameObject angVelX;
		TMP_Text angVelXText;
		
		public GameObject angVelY;
		TMP_Text angVelYText;
		
		public GameObject angVelZ;
		TMP_Text angVelZText;
		
		void Start()
		{
			eulerXText = DataPane.getTextField(eulerX);
			eulerYText = DataPane.getTextField(eulerY);
			eulerZText = DataPane.getTextField(eulerZ);
			linAccelXText = DataPane.getTextField(linAccelX);
			linAccelYText = DataPane.getTextField(linAccelY);
			linAccelZText = DataPane.getTextField(linAccelZ);
			angVelXText = DataPane.getTextField(angVelX);
			angVelYText = DataPane.getTextField(angVelY);
			angVelZText = DataPane.getTextField(angVelZ);
		}

		public float GetEulerX()
		{
			if (float.TryParse(eulerXText.text, out float ret))
				return ret;
			return 0;
		}
		public float GetEulerY()
		{
			if (float.TryParse(eulerYText.text, out float ret))
				return ret;
			return 0;
		}
		public float GetEulerZ()
		{
			if (float.TryParse(eulerZText.text, out float ret))
				return ret;
			return 0;
		}
		
		public void SetEulerX(string value) { eulerXText.text = value; }
		public void SetEulerY(string value) { eulerYText.text = value; }
		public void SetEulerZ(string value) { eulerZText.text = value; }
		public void SetLinAccelX(string value) { linAccelXText.text = value; }
		public void SetLinAccelY(string value) { linAccelYText.text = value; }
		public void SetLinAccelZ(string value) { linAccelZText.text = value; }
		public void SetAngVelX(string value) { angVelXText.text = value; }
		public void SetAngVelY(string value) { angVelYText.text = value; }
		public void SetAngVelZ(string value) { angVelZText.text = value; }
	}
}