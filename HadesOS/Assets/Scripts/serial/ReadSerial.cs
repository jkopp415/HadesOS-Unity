using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using gui;
using UnityEngine;

namespace serial
{
	public class ReadSerial : MonoBehaviour
    {
        private DataPane dataPane;
        
        private static SerialPort _serialPort;
    
        private static char _charBuffer;
        private static StringBuilder _inputBuffer;
    
        private void Start()
        {
            dataPane = GetComponent<DataPane>();
            
            _serialPort = new SerialPort();
        }
        
        private void Update()
        {
            if (_serialPort.IsOpen)
            {
                try
                {
                    // Empty the input buffer
                    _inputBuffer = new StringBuilder();
    
                    // While the next byte is not a *, do nothing
                    // Between the time the next byte is a * and a #, add each byte to the input buffer
                    // When a # is read, stop adding to the input buffer and send the input to the ParseSerial method
                    while (_serialPort.ReadByte() != '*') {}
                    while ((_charBuffer = (char)_serialPort.ReadByte()) != '#')
                        _inputBuffer.Append(_charBuffer);
    
                    dataPane.ParseSerial(_inputBuffer.ToString());

                }
                catch (TimeoutException) {}
            }
        }
    
        private void OnApplicationQuit()
        {
            _serialPort.Close();
        }
        
        public static List<string> GetSerialPorts()
        {
            return SerialPort.GetPortNames().Where(port => 
                port.Contains("ACM") || 
                port.Contains("USB") ||
                port.Contains("COM")).ToList();
        }
    
        public static void OpenSerialPort(string portName)
        {
            // If the serial port is open, close it
            if (_serialPort.IsOpen)
                _serialPort.Close();
    
            // Open the selected serial port
            _serialPort = new SerialPort(portName, 115200);
            _serialPort.ReadTimeout = 1;
            _serialPort.Open();
        }
    
        public static string GetOpenedPortName()
        {
            return _serialPort.PortName;
        }
    }
}