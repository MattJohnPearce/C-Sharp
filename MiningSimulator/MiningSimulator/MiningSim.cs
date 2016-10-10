/* Student Name: Matthew Pearce
 * StudentID: 131600732
 * Date: 19/06/2016
 * 
 * Project: AT2 Mining Simulator
 * 
 * This program monitors trucks as they travel back and forth between loading and the crusher.
 * 
 * The program will load a series of truck instances from Trucks.bin file;
 *  - Each truck will have a unique 3 digit integer ID and have a capacity of 200 tonnes
 *  
 * The truck instances will be loaded into the ListView on startup and will be saved back into
 * the Trucks.bin file when the form is closed.
 * 
 * When a truck instance is selected in the main listbox all the details are loaded into the 
 * textboxes and radio options
 * 
 * When a truck instance is double clicked in the main listbox it is added to the first queue and 
 * only trucks with a status = zero can be added to the queue.
 * 
 * When a queue listbox is clicked the first truck in the queue is moved to the next queue.
 * 
 * Once a truck object moves from the crusher queue to the transit to loading queue the total load 
 * value is incremented
 * 
 * The truck can be tagged for servicing at any time but will only be put into servicing when it is
 * not carrying a load. To exit a truck out of servicing double click on the truck.
 * 
 * To put the trucks status as inactive select the truck and click the inactive button, if the truck 
 * is full it will cyclye through the queues until its is emptied 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MiningSimulator
{
    /// <summary>
    /// The main form of the Mining Simulator program
    /// </summary>
    public partial class frmMinSim : Form
    {   
        /// <summary>
        /// Methods that are called whenthe program is started
        /// </summary>
        public frmMinSim()
        {
            InitializeComponent();
            InitializeTrucks();
            InitializeQueue();
            LoadFile();
        }

        /// <summary>
        /// Bool field varaible used while trucks are being pulled from the Binary
        /// file.
        /// </summary>
        bool fLoad = false;

        /// <summary>
        /// Integers to determine the max length for the arrays
        /// </summary>
        const int trkMAX = 20;
        const int queMAX = 4;

        /// <summary>
        /// Creating an Array to store Trucks
        /// </summary>
        Trucks[] truck = new Trucks[trkMAX];

        /// <summary>
        /// Initializing the Trucks Arrray by adding 20 trucks with unique identifier
        /// </summary>
        private void InitializeTrucks()
        {
            for (int i = 0; i < trkMAX; i++)
            {
                truck[i] = new Trucks();
                truck[i].gsTruckID = i + 100;
            }
            DisplayInfo();
        }

        /// <summary>
        /// Create an Array for Queues
        /// </summary>
        Queue<Trucks>[] allQ = new Queue<Trucks>[queMAX];

        /// <summary>
        /// Filling the Queue Array
        /// </summary>
        private void InitializeQueue()
        {
            for (int i = 0; i < queMAX; i++)
            {
                allQ[i] = new Queue<Trucks>();
            }
        }

        /// <summary>
        /// Method that displays all the trucks from the Array into the List View
        /// </summary>
        public void DisplayInfo()
        {
            lvAllTrucks.Items.Clear();
            // 
            for (int i = 0; i < trkMAX; i++)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                        truck[i].gsTruckID.ToString(),
                        truck[i].gsStatus.ToString()
            });
                lvAllTrucks.Items.Add(item);
            }
        }

        /// <summary>
        /// Displays the details of the specific truck instance by calling the Trucks 
        /// class and putting the data into the appropiate text boxes and selects the
        /// corresponding radiobutton
        /// </summary>
        /// <param name="trk"></param>
        private void UpdateDetails(Trucks trk)
        {
            tbTruckID.Text = trk.gsTruckID.ToString();
            tbLoadCapacity.Text = trk.gCapacity.ToString();
            tbTotal.Text = trk.gsTotal.ToString();
            switch (trk.gsStatus)
            {
                case 1:
                    rbTranLoad.Select();
                    break;
                case 2:
                    rbLoading.Select();
                    break;
                case 3:
                    rbTransCrush.Select();
                    break;
                case 4:
                    rbCrusher.Select();
                    break;
                case 5:
                    rbService.Select();
                    break;
                default:
                    rbInactive.Select();
                    break;
            }
        }

        /// <summary>
        /// Moves text from one listbox to another depending on the trucks status
        /// </summary>
        /// <param name="trk"></param>
        private void UpdateQue(Trucks trk)  
        {
            switch (trk.gsStatus)
            {
                case 1:
                    lbCrushQue.Items.Remove(trk.gsTruckID + "\t" + (trk.gsStatus + 3));
                    lbTransLoad.Items.Add(trk.gsTruckID + "\t" + trk.gsStatus);
                    break;
                case 2:
                    lbTransLoad.Items.Remove(trk.gsTruckID + "\t" + (trk.gsStatus - 1));
                    lbLoadQue.Items.Add(trk.gsTruckID + "\t" + trk.gsStatus);
                    break;
                case 3:
                    lbLoadQue.Items.Remove(trk.gsTruckID + "\t" + (trk.gsStatus - 1));
                    lbTransCrush.Items.Add(trk.gsTruckID + "\t" + trk.gsStatus);
                    break;
                case 4:
                    lbTransCrush.Items.Remove(trk.gsTruckID + "\t" + (trk.gsStatus - 1));
                    lbCrushQue.Items.Add(trk.gsTruckID + "\t" + (trk.gsStatus));
                    break;
                default:
                    lbTransLoad.Items.Remove(trk.gsTruckID + "\t" + (trk.gsStatus + 1));
                    lbCrushQue.Items.Remove(trk.gsTruckID + "\t" + (trk.gsStatus + 4));
                    break;
            }
        }

        /// <summary>
        /// Puts trucks into the Service Listbox from the Queue 1 and 4, and removes 
        /// any other text associated with the specific truck, also resets the Queue 
        /// pointer.
        /// </summary>
        /// <param name="trk"></param>
        private void ServiceUpdate(Trucks trk)
        {
            lbInService.Items.Remove(trk.gsTruckID + "\tTo Be Serviced");
            lbInService.Items.Add(trk.gsTruckID + "\tServicing");
            lbCrushQue.Items.Remove(trk.gsTruckID + "\t" + (trk.gsStatus - 1));
            lbTransLoad.Items.Remove(trk.gsTruckID + "\t" + (trk.gsStatus - 4));
            trk.gsQuePtr = 0;
        }

        /// <summary>
        /// Checks if the class objects loadded from the binary file are going to 
        /// be serviced.Then checks what the Trucks status is to determine which 
        /// Queue it will go in or if the truck needs to be serviced. When put into
        /// the third queue the truck increments its load.
        /// </summary>
        /// <param name="trk"></param>
        private void TransQue(Trucks trk)
        {
            if (trk.ToService && fLoad == true)
            {
                lbInService.Items.Add(trk.gsTruckID + "\tTo Be Serviced");
            }

            switch (trk.gsStatus)
            {
                case 1:
                    allQ[0].Enqueue(trk);
                    ListQue(trk, 0);
                    break;
                case 2:
                    allQ[1].Enqueue(trk);
                    ListQue(trk, 1);
                    break;
                case 3:
                    allQ[2].Enqueue(trk);
                    ListQue(trk, 2);
                    break;
                case 4:
                    allQ[3].Enqueue(trk);
                    ListQue(trk, 3);
                    break;
                case 5:
                    ServiceUpdate(trk);
                    break;
                default:
                    break;
            }
            UpdateQue(trk);
            DisplayInfo();
            UpdateDetails(trk);
        }

        /// <summary>
        /// Deque a truck object from the Que associated with the input parameter
        /// </summary>
        /// <param name="i"></param>
        public void DeQue(int i)
        {
            try
            {
                UpdateListQue(i + 1);
                Trucks nextTruck = allQ[i].Dequeue();
                nextTruck.StsUpdate();
                TransQue(nextTruck);
            }
            catch (InvalidOperationException InvEx)
            {
                MessageBox.Show(InvEx.Message + " Add a truck to the Queue", "Error");
            }
        }

        /// <summary>
        /// Gets the specified truck and gives it a unique number derived from the 
        /// Queue itsin so it can be put back into the Queue when loaded from binary 
        /// file
        /// </summary>
        /// <param name="trk"></param>
        /// <param name="i"></param>
        private void ListQue(Trucks trk, int i)
        {
            trk.gsQuePtr = (double)allQ[i].Count() / 100 + (i + 1);
        }

        /// <summary>
        /// Updates the queue pointer for each truck in the specified queue
        /// </summary>
        /// <param name="x"></param>
        private void UpdateListQue(int x)
        {
            for (int i = 0; i < trkMAX; i++)
            {
                if ((int)truck[i].gsQuePtr == x)
                {
                    truck[i].QuePointerUpdate();
                }
            }
        }

        /// <summary>
        /// Creates a binary file and writes the trucks ID, status, total, if its 
        /// going to be serviced and where in the Queue it belongs
        /// </summary>
        private void SaveFile()
        {
            BinaryWriter bWriter;
            try
            {
                bWriter = new BinaryWriter(new FileStream("Trucks.bin", FileMode.Create));
            }
            catch (Exception fe)
            {
                MessageBox.Show(fe.Message + "\n Cannot create to file.");
                return;
            }

            foreach (Trucks trkDts in truck)
            {
                try
                {
                    bWriter.Write(trkDts.gsTruckID);
                    bWriter.Write(trkDts.gsStatus);
                    bWriter.Write(trkDts.gsTotal);
                    bWriter.Write(trkDts.ToService);
                    bWriter.Write(trkDts.gsQuePtr);
                    bWriter.Write(trkDts.ToInactive);
                }
                catch (IOException ioe)
                {
                    MessageBox.Show(ioe.Message + "Error writing to Trucks.bin", "Error");
                    return;
                }
            }
            bWriter.Close();
        }

        /// <summary>
        /// Opens binary file a puts data from the file into the Trucks Array. It is 
        /// then sorted by the gsQuePtr field so that each truck gets put back into 
        /// the Queue in the correct order. The Array is then reorderd back and 
        /// displayed from truck 100 - 119
        /// </summary>
        private void LoadFile()
        {
            BinaryReader bReader;
            try
            {
                bReader = new BinaryReader(new FileStream("Trucks.bin", FileMode.Open));
            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show(fnfe.Message + "\n Cannot find file for reading", "Error");
                return;
            }
            try
            {              
                    for (int i = 0; i <= 19; i++)
                    {
                        truck[i] = new Trucks();
                        truck[i].gsTruckID = bReader.ReadInt32();
                        truck[i].gsStatus = bReader.ReadInt32();
                        truck[i].gsTotal = bReader.ReadInt32();
                        truck[i].ToService = bReader.ReadBoolean();
                        truck[i].gsQuePtr = bReader.ReadDouble();
                        truck[i].ToInactive = bReader.ReadBoolean();
                    }              
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "\n Cannot load data from file", "Error");
            }
            bReader.Close();

            fLoad = true;

            Array.Sort(truck, delegate(Trucks x, Trucks y) { return x.gsQuePtr.CompareTo(y.gsQuePtr); });


            foreach (Trucks oldTruck in truck)
            {
                TransQue(oldTruck);
            }
            Array.Sort(truck, delegate(Trucks x, Trucks y) { return x.gsTruckID.CompareTo(y.gsTruckID); });
            DisplayInfo();
            fLoad = false;
        }

        /// <summary>
        /// Adds a truck to the service listbox or tags the truck to be serviced after
        /// dumping its next load
        /// </summary>
        private void AddToService()
        {
            try
            {
                int indx = lvAllTrucks.FocusedItem.Index;
                if (truck[indx].gsStatus == 0)
                {
                    truck[indx].gsStatus = 5;
                    lbInService.Items.Add(truck[indx].gsTruckID + "\tServicing");
                }
                else if (truck[indx].ToService)
                {
                    truck[indx].ToService = false;
                    lbInService.Items.Remove(truck[indx].gsTruckID + "\tTo Be Serviced");
                }
                else
                {
                    truck[indx].ToService = true;
                    lbInService.Items.Add(truck[indx].gsTruckID + "\tTo Be Serviced");
                }
                DisplayInfo();
                UpdateDetails(truck[indx]);
            }
            catch (NullReferenceException nrex)
            {
                MessageBox.Show("Please select a truck to service\n" + nrex.Message, "Error");
            }
        }

        /// <summary>
        /// Removes the selected truch from the Service Listbox
        /// </summary>
        private void RemoveFromService()
        {
            try
            {
                string wrd = lbInService.SelectedItem.ToString().Remove(3);
                int newidx = Int32.Parse(wrd) - 100;
                if (truck[newidx].gsStatus < 5)
                {
                    truck[newidx].ToService = false;
                    lbInService.Items.Remove(truck[newidx].gsTruckID + "\tTo Be Serviced");
                    return;
                }
                truck[newidx].ToService = false;
                truck[newidx].StsUpdate();
                truck[newidx].ToInactive = false;
                lbInService.Items.Remove(truck[newidx].gsTruckID + "\tServicing");
                DisplayInfo();
                UpdateDetails(truck[newidx]);
            }
            catch (NullReferenceException nrex)
            {
                MessageBox.Show("Please select a truck to remove from service\n" + nrex.Message, "Error");
            }
        }

        /// <summary>
        /// Removes the selected truc from the workforce when its load has been 
        /// emptied
        /// </summary>
        private void MoveToInactive()
        {

            try
            {
                int indx = lvAllTrucks.FocusedItem.Index;
                if (truck[indx].gsStatus != 0)
                {
                    truck[indx].ToInactive = true;
                    DisplayInfo();
                    UpdateDetails(truck[indx]);
                }
                else {
                    MessageBox.Show("Truck is already inactive!","Error");
                }
            }
            catch (NullReferenceException nrex)
            {
                MessageBox.Show("Please select a truck to service\n" + nrex.Message, "Error");
            }
        }

        /// <summary>
        /// Displays the selected trucks' details into the appropiate textboxes and
        /// radio buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvAllTrucks_MouseClick(object sender, MouseEventArgs e)
        {
            int indx = lvAllTrucks.FocusedItem.Index;
            UpdateDetails(truck[indx]);
        }

        /// <summary>
        /// Puts the selected truck into the the first Queue if is not already in one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvAllTrucks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int indx = lvAllTrucks.FocusedItem.Index;
            if (truck[indx].gsStatus == 0)
            {
                truck[indx].StsUpdate();
                TransQue(truck[indx]);
            }
            else
            {
                MessageBox.Show("This truck is busy", "Busy",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Adds truck to Service Listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnService_Click(object sender, EventArgs e)
        {
            AddToService();
        }

        /// <summary>
        /// Puts truck into next Queue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbInService_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RemoveFromService();
        }

        /// <summary>
        /// Removes truck from workforce
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInactive_Click(object sender, EventArgs e)
        {
            MoveToInactive();
        }

        /// <summary>
        /// Puts truck into next Queue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbTransLoad_MouseClick(object sender, MouseEventArgs e)
        {
            DeQue(0);
        }

        /// <summary>
        /// Puts truck into next Queue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbLoadQue_MouseClick(object sender, MouseEventArgs e)
        {
            DeQue(1);
        }

        /// <summary>
        /// Puts truck into next Queue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbTransCrush_MouseClick(object sender, MouseEventArgs e)
        {
            DeQue(2);
        }

        /// <summary>
        /// Puts truck into next Queue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbCrushQue_MouseClick(object sender, MouseEventArgs e)
        {
            DeQue(3);
        }

        /// <summary>
        /// Saves the Truck Array when the program is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMinSim_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFile();
        }

        /// <summary>
        /// Exits and saves the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
            Application.Exit();
        }

        /// <summary>
        /// Opens the user guide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void userGuideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();
            try
            {
                myProcess.StartInfo.FileName = "Mining Simulator User Guide.pdf";
                myProcess.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("File not found" + ex.Message, "Error");
            }
        }       
    }
}


