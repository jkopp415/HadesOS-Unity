using serial;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace gui
{
	public class SerialConfigPane : MonoBehaviour
	{
		public GameObject selectPort;
		private Button selectPortButton;

		public GameObject openedPort;
		private TMP_Text openedPortText;

		public GameObject portList;
		private TMP_Dropdown portListDrop;
    
		public GameObject refreshPort;
		private Button refreshPortButton;

		void Start()
		{
			selectPortButton = selectPort.transform.Find("Button").GetComponent<Button>();
			openedPortText = openedPort.GetComponent<TMP_Text>();
			portListDrop = portList.transform.Find("Dropdown").GetComponent<TMP_Dropdown>();
			refreshPortButton = refreshPort.transform.Find("Button").GetComponent<Button>();
			
			refreshPortButton.onClick.AddListener(RefreshPortList);
			selectPortButton.onClick.AddListener(SelectPort);
			RefreshPortList();
		}
		
		private void SelectPort()
		{
			ReadSerial.OpenSerialPort(portListDrop.options[portListDrop.value].text);
			openedPortText.text = ReadSerial.GetOpenedPortName();
		}
        
		private void RefreshPortList()
		{
			portListDrop.ClearOptions();
			portListDrop.AddOptions(ReadSerial.GetSerialPorts());
		}
	}
}