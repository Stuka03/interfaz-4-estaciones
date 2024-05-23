/*
 * Created by VS 2022.
 * User: EGAE
 * Date: 21/02/2024
 * Time: 04:05 P.M.
 */
using System.IO;
using System.Xml.Linq;
using System;
using System.Windows.Forms;
using Models;
using System.Drawing;

namespace InterfaceOneStation
{
    public partial class MainForm : Form
    {
        //INSTANCIA CUTTING SYSTEM
        private CuttingSystem SistemaCorte;
        //VARIABLES SISTEMA DE LUBRICACION
        private bool LubricationSystemEnable;
        private int LubricationInterval;
        public int LubricationActive;
        private int seconds;
        private int minuts;
        private int hours;
        private string filePath;
        private bool BanderaBoxLS;
        XDocument xmlDocument;
        //VARIABLES MONITOREO BW Y SENSOR DE PRESION
        private bool BanderaBoxBW;
        private bool BanderaBoxPS;
        private DialogResult r;
        public MainForm()
        {
            //APP SETUP
            InitializeComponent();
            //CONFIG FILE SETUP
            InicializeAppConfigFile();
            //PHOENIX COM SETUP
            IniciaConexionPhoenix();
            //LUBRICATION CONTROL SYSTEM
            //UpdateValues();
            //CheckLubricationSystem();
            BanderaBoxLS = false;
            seconds = 0;
            minuts = 0;
            hours = 0;
            //MONITOREO
            timer1.Interval = 500;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            BanderaBoxBW = false;
            BanderaBoxPS = false;
            //TIMER INTERVAL
            timer2.Interval = 1000;
            timer2.Enabled = false;
            timer2.Tick += new EventHandler(timer2_Tick);
            //TIMER LUBRICATION
            timer3.Interval = 1000;
            timer3.Enabled = false;
            timer3.Tick += new EventHandler(timer3_Tick);
            //LS SYSTEM START
            UpdateValues();
            CheckLubricationSystem();
            BanderaBoxLS = false;
        }
        #region METODOS STANDAR SOC-PHOENIX
        public void IniciaConexionPhoenix()
        {
            try
            {   //INICIAR CONEXION
                SistemaCorte = CuttingSystem.Instance;
                do
                {
                    SistemaCorte.GetAssignedIO();
                } while (SistemaCorte.Inputs.Count <= 0 &&
                SistemaCorte.Outputs.Count <= 0);
                //SINCRONIZAR
                SistemaCorte.SetSyncTimerTick(0.5);
                SistemaCorte.StartSync();
                SistemaCorte.Synchronize();
            }
            catch (Exception ex)
            {
                CustomMessageBox customMessageBox = new CustomMessageBox("Falló conexion con Phoenix!", Color.Red);
                customMessageBox.ShowDialog();
            }
        }
        public void InicializeAppConfigFile()
        {
            filePath = "AppConfig.xml";
            if (File.Exists(filePath))
            {
                // Load the existing XML file
                xmlDocument = XDocument.Load(filePath);
            }
            else
            {
                // Create a new XML file
                xmlDocument = new XDocument(new XElement("Root"));
            }
        }
        private void TurnCncFunctionTrue(InputFunction f)
        {
            try
            {   //INICIAR CONEXION
                SistemaCorte.Inputs[f].SetState(true);
            }
            catch (Exception ex)
            {
                CncVariableEx(ex.Message, f);
            }
        }
        private void TurnCncFunctionFalse(InputFunction f)
        {
            try
            {
                SistemaCorte.Inputs[f].SetState(false);
            }
            catch (Exception ex)
            {
                CncVariableEx(ex.Message, f);
            }
        }
        private bool CheckCncFunctionState(InputFunction f)
        {
            try
            {
                return SistemaCorte.Inputs[f].State;
            }
            catch (Exception ex)
            {
                CncVariableEx(ex.Message, f);
                return false;
            }
        }
        private bool CheckCncOutputState(OutputFunction f)
        {
            try
            {
                return SistemaCorte.Outputs[f].State;
            }
            catch (Exception ex)
            {
                CncVariableExOut(ex.Message, f);
                return false;
            }
        }
        private void CncVariableEx(string ex, InputFunction f)
        {
            CustomMessageBox customMessageBox = new CustomMessageBox((ex) + "\nDar de alta la funcion: " + f.ToString(), Color.Red);
            customMessageBox.ShowDialog();
        }
        private void CncVariableExOut(string ex, OutputFunction f)
        {
            CustomMessageBox customMessageBox = new CustomMessageBox((ex) + "\nDar de alta la funcion: " + f.ToString(), Color.Red);
            customMessageBox.ShowDialog();
        }
        #endregion
        #region //PARK & CLAMPS CONTROLS
        //TORCH 1 CONTROLS
        private void pictureBoxClamp1_Click(object sender, EventArgs e)
        {
            pictureBoxUnclamp1.Visible = true;
            pictureBoxClamp1.Visible = false;
            labelMaster1Clamp.Text = "Unclamped";
            TurnCncFunctionTrue(InputFunction.Aux_Function_Select_2);
        }
        private void pictureBoxUnclamp1_Click(object sender, EventArgs e)
        {
            torch1Clamped();
        }
        //TORCH 2 CONTROLS
        private void pictureBoxAncla_Click(object sender, EventArgs e)
        {
            torch2Free();

        }
        private void pictureBoxMove_Click(object sender, EventArgs e)
        {
            pictureBoxAncla1.Visible = true;
            pictureBoxMove1.Visible = false;
            labelMaster1.Text = "Parked";
            TurnCncFunctionTrue(InputFunction.Aux_Function_Select_6);
        }
        //TORCH 3 CONTROLS
        private void pictureBoxAncla2_Click(object sender, EventArgs e)
        {
            torch3Free();

        }
        private void pictureBoxMove2_Click(object sender, EventArgs e)
        {
            TurnCncFunctionTrue(InputFunction.Aux_Function_Select_7);
            pictureBoxAncla2.Visible = true;
            pictureBoxMove2.Visible = false;
            labelMaster2.Text = "Parked";
        }
        //TORCH 4 CONTROLS
        private void pictureBoxClamp2_Click(object sender, EventArgs e)
        {
            pictureBoxClamp2.Visible = false;
            pictureBoxUnclamp2.Visible = true;
            labelMaster2Clamp.Text = "Unclamped";
            TurnCncFunctionTrue(InputFunction.Aux_Function_Select_3);
        }
        private void pictureBoxUnclamp2_Click(object sender, EventArgs e)
        {
            torch4Clamped();
        }
        #endregion
        #region //PARK & CLAMPS METHODS
        private void torch1Clamped()
        {
            pictureBoxUnclamp1.Visible = false;
            pictureBoxClamp1.Visible = true;
            labelMaster1Clamp.Text = "Clamped";
            TurnCncFunctionFalse(InputFunction.Aux_Function_Select_2);
        }
        private void torch2Free()
        {
            pictureBoxAncla1.Visible = false;
            pictureBoxMove1.Visible = true;
            labelMaster1.Text = "Free";
            TurnCncFunctionFalse(InputFunction.Aux_Function_Select_6);

        }

        private void torch3Free()
        {
            TurnCncFunctionFalse(InputFunction.Aux_Function_Select_7);
            pictureBoxAncla2.Visible = false;
            pictureBoxMove2.Visible = true;
            labelMaster2.Text = "Free";
        }

        private void torch4Clamped()
        {
            pictureBoxClamp2.Visible = true;
            pictureBoxUnclamp2.Visible = false;
            labelMaster2Clamp.Text = "Clamped";
            TurnCncFunctionFalse(InputFunction.Aux_Function_Select_3);
        }
        #endregion
        #region //LUBRICATION CONTROLS        
        private void DisableControls()
        {
            checkBoxEnableLubrication.Enabled = false;
            comboBoxLubricationInterval.Enabled = false;
            comboBoxLubricationActive.Enabled = false;
            buttonSave.Enabled = false;
            buttonLSTest.Enabled = false;
            checkBoxEnableLubrication.Enabled = false;
        }
        private void EnableButtons()
        {
            checkBoxEnableLubrication.Enabled = true;
            comboBoxLubricationInterval.Enabled = true;
            comboBoxLubricationActive.Enabled = true;
            buttonSave.Enabled = true;
            buttonLSTest.Enabled = true;
            checkBoxEnableLubrication.Enabled = true;
        }
        private void buttonEnter_Click_1(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "1396")
            {
                EnableButtons();
            }
        }
        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                //validacion de datos
                //intervalo
                if (comboBoxLubricationInterval.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a valid item from the Interval list.");
                    comboBoxLubricationInterval.SelectedIndex = 0; // Set the index to a default value or any other appropriate action.
                }
                //ciclo activo
                else if (comboBoxLubricationActive.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a valid item from the Timer list.");
                    comboBoxLubricationActive.SelectedIndex = 0; // Set the index to a default value or any other appropriate action.
                }
                else
                {
                    xmlDocument.Root.Element("LubricationEnabled")?.Remove(); // Remove existing value, if any
                    xmlDocument.Root.Element("IntervalTime")?.Remove(); // Remove existing value, if any
                    xmlDocument.Root.Element("ActivationTime")?.Remove(); // Remove existing value, if any
                    xmlDocument.Root.Add(new XElement("LubricationEnabled", checkBoxEnableLubrication.Checked));
                    xmlDocument.Root.Add(new XElement("IntervalTime", comboBoxLubricationInterval.SelectedIndex));
                    xmlDocument.Root.Add(new XElement("ActivationTime", comboBoxLubricationActive.SelectedIndex));
                    xmlDocument.Save(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo guardar configuracion, intente manualmente");
            }
            //ACTUALIZA VALORES, DESHABILITA CONTROLES Y REINICIA EL SISTEMA DE LUBRICACION CON LOS NUEVOS VALORES
            UpdateValues();
            DisableControls();
            CheckLubricationSystem();
        }
        //BOTON TEST MODE
        private void buttonLSTest_Click(object sender, EventArgs e)
        {
            if (buttonLSTest.BackColor != Color.Lime)
            {
                timer2.Enabled = false;
                seconds = 0;
                minuts = 0;
                hours = 0;
                TurnCncFunctionFalse(InputFunction.Aux_Function_Select_1);
                radioButtonLSAactive.Checked = false;
                timer3.Enabled = false;
                BanderaBoxLS = false;
                UpdateValues();
                CheckLubricationSystem();
                buttonLSTest.BackColor = Color.Lime;
            }
            else
            {
                buttonLSTest.BackColor = SystemColors.InactiveBorder;
            }
        }
        #endregion
        #region //EVENTOS LUBRICACION
        //#1 REVISA SI ESTÁ EL BIT ENABLE ACTIVADO Y ARRANCA TIMER INTERVALO
        private void CheckLubricationSystem()
        {
            if (LubricationSystemEnable == true)
            {
                timer2.Enabled = true;
            }
            else
            {
                timer2.Enabled = false;
            }
        }

        //#2 TIMER INTERVALO, CUENTA TIEMPO DE INTERVALO Y LUEGO INICIALIZA TIMER DE LUBRICACION
        private void timer2_Tick(object sender, EventArgs e)
        {
            //CONTADOR INTERVALO
            seconds = seconds + 1;
            if (seconds == 60)
            {
                minuts = minuts + 1;
                seconds = 0;
                if (minuts == 60)
                {
                    hours = hours + 1;
                    minuts = 0;
                }
            }
            labelTime.Text = hours.ToString() + ":" + minuts.ToString() + ":" + seconds.ToString();

            //SI SE LLEGA AL TIEMPO DE INTERVALO O EL BOTON TEST ESTA ACTIVADO Y YA SE CUMPLIO ELTIEMPO DE CICLO
            if ((hours >= LubricationInterval) || (seconds >= LubricationActive && buttonLSTest.BackColor == Color.Lime))
            {
                timer2.Enabled = false;
                seconds = 0;
                minuts = 0;
                hours = 0;
                timer3.Enabled = true;
            }
        }

        //#3 TIMER LUBRICACION, ACTIVA SEÑALES DE LUBRICACION Y CUENTA TIEMPO DE ACTIVACION
        private void timer3_Tick(object sender, EventArgs e)
        {
            //ENCIENDE BOMBA SOLO SI ESTA DADA DE ALTA LA FUNCION
            if (BanderaBoxLS == false)
            {
                TurnCncFunctionTrue(InputFunction.Aux_Function_Select_1);
                BanderaBoxLS = true;
            }
            //ENCIENDE BOMBA
            radioButtonLSAactive.Checked = true;
            //CUENTA LOS SEGUNDOS
            seconds = seconds + 1;
            labelTime.Text = seconds.ToString();
            //TERMINA LA LUBRICACION AL TRANSCURRIR EL TIEMPO DEFINIDO
                if (seconds >= LubricationActive)
                {
                    EndTimerLubrication();
                }
        }

        //#4 CIERRE DE CICLO DE LUBRICACION, ACTUALIZA LOS VALORES DE LA CONFIGURACION Y REINICIA EL CICLO
        private void EndTimerLubrication()
        {
            //APAGA BOMBA
            TurnCncFunctionFalse(InputFunction.Aux_Function_Select_1);
            radioButtonLSAactive.Checked = false;
            timer3.Enabled = false;
            seconds = 0;
            minuts = 0;
            hours = 0;
            BanderaBoxLS = false;
            UpdateValues();
            CheckLubricationSystem();
        }
        private void UpdateValues()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    // Retrieve the value from the XML document
                    XElement myValueElement1 = xmlDocument.Root.Element("LubricationEnabled");
                    XElement myValueElement2 = xmlDocument.Root.Element("IntervalTime");
                    XElement myValueElement3 = xmlDocument.Root.Element("ActivationTime"); ;
                    // updates enable value
                    if (bool.TryParse(myValueElement1.Value, out LubricationSystemEnable))
                    {
                        checkBoxEnableLubrication.Checked = LubricationSystemEnable;
                    }
                    else
                    {
                        checkBoxEnableLubrication.Checked = false;
                    }
                    // updates interval
                    if (myValueElement2 != null)
                    {
                        int interval;
                        interval = Convert.ToInt16(myValueElement2.Value);
                        LubricationInterval = interval + 1;
                        comboBoxLubricationInterval.SelectedIndex = interval;
                    }
                    else
                    {
                        LubricationSystemEnable = false;
                    }
                    //updates activation time
                    if (myValueElement3 != null)
                    {
                        int activation;
                        activation = Convert.ToInt16(myValueElement3.Value);
                        LubricationActive = (activation + 1) * 5;
                        comboBoxLubricationActive.SelectedIndex = activation;
                    }
                    else
                    {
                        LubricationSystemEnable = false;
                    }
                }
                else
                {
                    LubricationSystemEnable = false;
                }
            }
            catch (Exception ex)
            {
                LubricationSystemEnable = false;
                MessageBox.Show(ex.Message, "No se actualizaron valores, SISTEMA DESACTIVADO");
            }
        }
        #endregion
        #region MONITOREO BW & SENSOR DE PRESION
        private void timer1_Tick(object sender, EventArgs e)
        {
            //MONITOREO BW
            if (CheckCncFunctionState(InputFunction.Torch_Collision))
            {
                if (BanderaBoxBW == false)
                {
                    BanderaBoxBW = true;
                    CustomMessageBox customMessageBox = new CustomMessageBox("Torch Collision, Revisa estado del Breakaway!", Color.Red);
                    customMessageBox.ShowDialog();
                    //Check the result after the form is closed
                    if (customMessageBox.CustomDialogResult == DialogResult.OK)
                    {
                        BanderaBoxBW = false;
                    }
                }
            }

            //MONITOREO SENSOR DE PRESION
            if (CheckCncFunctionState(InputFunction.Aux_Function_Select_8))
            {
                if (BanderaBoxPS == false)
                {
                    BanderaBoxPS = true;
                    TurnCncFunctionTrue(InputFunction.Fast_Stop);
                    CustomMessageBox customMessageBox = new CustomMessageBox("Low Air Pressure\nFast Stop Activado\n¡Revisa estado del Suministro!", Color.Red);
                    customMessageBox.ShowDialog();
                    //Check the result after the form is closed
                    if (customMessageBox.CustomDialogResult == DialogResult.OK)
                    {
                        BanderaBoxPS = false;
                    }
                }
            }
            else { TurnCncFunctionFalse(InputFunction.Fast_Stop); }

            //MONITOREO PROGRAM RUNNING
            if (CheckCncOutputState(OutputFunction.Program_Running))
            {
                torch1Clamped();
                torch2Free();
                torch3Free();
                torch4Clamped();

                groupBox1.Enabled = false;

            }

            else if (!CheckCncFunctionState(InputFunction.Aux_Function_Select_9))
            {

                groupBox1.Enabled = true;

            }

        }
        #endregion

        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "1396")
            {
                EnableButtons();
            }
        }
    }
}