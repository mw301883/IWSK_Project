namespace IWSK_Project
{
    using System;
    using System.Diagnostics;
    using System.IO.Ports;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        private string dataToSend = "";
        private string terminator = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateComPortList();
            UpdateBaudRateList();
            UpdateFormatList();
            UpdateFlowControlList();
        }

        private void UpdateComPortList()
        {
            comboBox1.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        private void UpdateBaudRateList()
        {
            comboBox4.Items.Clear();
            int[] baudRates = { 300, 1200, 2400, 4800, 9600, 19200, 38400, 57600, 115200 };
            foreach (int rate in baudRates)
            {
                comboBox4.Items.Add(rate);
            }
            if (comboBox4.Items.Count > 0)
            {
                comboBox4.SelectedIndex = 0;
            }
        }

        private void UpdateFormatList()
        {
            comboBox2.Items.Clear();
            string[] formats = { "7E1", "7O1", "7N1", "7E2", "7O2", "7N2", "8E1", "8O1", "8N1", "8E2", "8O2", "8N2" };
            comboBox2.Items.AddRange(formats);
            if (comboBox2.Items.Count > 0)
            {
                comboBox2.SelectedIndex = 0;
            }
        }

        private void UpdateFlowControlList()
        {
            comboBox3.Items.Clear();
            string[] flowControls = { "Brak kontroli przep³ywu", "Sprzêtowa (DTR/DSR)", "Sprzêtowa (RTS/CTS)", "Programowa (XON/XOFF)" };
            comboBox3.Items.AddRange(flowControls);
            if (comboBox3.Items.Count > 0)
            {
                comboBox3.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedPort = comboBox1.SelectedItem.ToString();
                int selectedBaudRate = int.Parse(comboBox4.SelectedItem.ToString());
                string selectedFormat = comboBox2.SelectedItem.ToString();
                string selectedFlowControl = comboBox3.SelectedItem.ToString();

                serialPort = new SerialPort(selectedPort, selectedBaudRate);

                // Ustawienie formatu znaku
                switch (selectedFormat[0])
                {
                    case '7':
                        serialPort.DataBits = 7;
                        break;
                    case '8':
                        serialPort.DataBits = 8;
                        break;
                }

                switch (selectedFormat[1])
                {
                    case 'E':
                        serialPort.Parity = Parity.Even;
                        break;
                    case 'O':
                        serialPort.Parity = Parity.Odd;
                        break;
                    case 'N':
                        serialPort.Parity = Parity.None;
                        break;
                }

                switch (selectedFormat[2])
                {
                    case '1':
                        serialPort.StopBits = StopBits.One;
                        break;
                    case '2':
                        serialPort.StopBits = StopBits.Two;
                        break;
                }

                // Ustawienie kontroli przep³ywu
                switch (selectedFlowControl)
                {
                    case "Brak kontroli przep³ywu":
                        serialPort.Handshake = Handshake.None;
                        break;
                    case "Sprzêtowa (DTR/DSR)":
                        serialPort.Handshake = Handshake.RequestToSendXOnXOff;
                        break;
                    case "Sprzêtowa (RTS/CTS)":
                        serialPort.Handshake = Handshake.RequestToSend;
                        break;
                    case "Programowa (XON/XOFF)":
                        serialPort.Handshake = Handshake.XOnXOff;
                        break;
                }

                serialPort.Open();
                LogToConsole("Po³¹czono z portem: " + selectedPort);
            }
            catch (Exception ex)
            {
                LogToConsole("B³¹d: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.Close();
                    LogToConsole("Roz³¹czono z portem COM");
                }
                else
                {
                    LogToConsole("Port COM nie jest otwarty.");
                }
            }
            catch (Exception ex)
            {
                LogToConsole("B³¹d przy roz³¹czaniu z portem COM: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    string message = textBox2.Text;
                    if (message.Length == 0)
                    {
                        message = " ";
                    }
                    message = GetSubstringUntilTerminator(message);
                    serialPort.Write(message);
                    LogToConsole("Wys³ano dane: " + message);
                }
                else
                {
                    LogToConsole("Port COM nie jest otwarty.");
                }
            }
            catch (Exception ex)
            {
                LogToConsole("B³¹d przy wysy³aniu danych: " + ex.Message);
            }
        }

        private string GetSubstringUntilTerminator(string message)
        {
            if(terminator.Length == 0)
            {
                return message;
            }
            int index = message.IndexOf(terminator);
            if (index != -1)
            {
                return message.Substring(0, index);
            }
            else
            {
                return message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort != null && serialPort.IsOpen)
                {
                    // Inicjujemy Stopwatch
                    Stopwatch stopwatch = Stopwatch.StartNew();

                    serialPort.Write("ping");
                    LogToConsole("Wys³ano: ping");

                    string response = serialPort.ReadLine();
                    LogToConsole("Odebrano: " + response);

                    // Zatrzymujemy Stopwatch po otrzymaniu odpowiedzi
                    stopwatch.Stop();

                    if (response.Trim().ToLower() == "pong")
                    {
                        MessageBox.Show("Odebrano: pong");

                        // Wypisz czas wykonania
                        LogToConsole("Czas wykonania: " + stopwatch.ElapsedMilliseconds + " ms");
                    }
                    else
                    {
                        MessageBox.Show("Nieoczekiwana odpowiedŸ: " + response);
                    }
                }
                else
                {
                    LogToConsole("Port COM nie jest otwarty.");
                }
            }
            catch (TimeoutException)
            {
                LogToConsole("Timeout podczas oczekiwania na odpowiedŸ.");
            }
            catch (Exception ex)
            {
                LogToConsole("B³¹d przy wysy³aniu komendy ping: " + ex.Message);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            terminator = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataToSend = textBox2.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogToConsole(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(LogToConsole), new object[] { message });
            }
            else
            {
                string logMessage = $"{DateTime.Now}: {message}";
                richTextBox1.AppendText(logMessage + Environment.NewLine);
                richTextBox1.ScrollToCaret();
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort.ReadLine();
                LogToConsole("Odebrano: " + data);

                if (data.Trim().ToLower() == "ping")
                {
                    serialPort.Write("pong");
                    LogToConsole("Wys³ano: pong");
                }
            }
            catch (Exception ex)
            {
                LogToConsole("B³¹d podczas odbierania danych: " + ex.Message);
            }
        }
    }
}
