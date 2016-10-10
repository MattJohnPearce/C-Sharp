using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MyBikes_Project
{
    /// <summary>
    /// Name: Matthew Pearce
    /// StudentID: 131600732
    /// Date: 25 March 2016
    /// AT2-Project: My Bike Collection
    /// Version 1.00
    /// 
    /// This program allows user to add, update or delete motobikes to and from a list.The list can then be saved,
    /// either from a save button or on exit, to an XML file named 'bikes.xml'. A user guide is provided in the help 
    /// menu. When a user clicks on an item in the list all fields are then displayed into their appropriate textboxes
    /// </summary>
    public partial class frmMyBikes : Form
    {
        /// <summary>
        /// Initialize forms components
        /// </summary>
        public frmMyBikes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates a new ListArray to store bikes based on the class 'Bikes'
        /// </summary>
        List<Bikes> myBikes = new List<Bikes>();

        /// <summary>
        /// Public variables declared and intialized
        /// </summary>
        bool waterMarkOn = true;
        bool alreadySaved = false;
        bool exitBikes = false;
        bool cancelExit = false;

        /// <summary>
        /// Creates class bikes with each field for bike information and a compare method that sorts Bikes by 'model' field.
        /// </summary>
        public class Bikes : IComparable<Bikes>
        {
            /// <summary>
            /// References the make or manufacturer of the bike
            /// </summary>
            [XmlElement("make")]
            public string make
            {
                get;
                set;
            }
            /// <summary>
            /// Model of the bike (there can be only one)
            /// </summary>
            [XmlElement("model")]
            public string model
            {
                get;
                set;
            }
            /// <summary>
            /// Engine size of the bike will automatcially display the symbol 'cc'
            /// </summary>
            [XmlElement("size")]
            public string size
            {
                get;
                set;
            }
            /// <summary>
            /// The user can not type anymore than 4 numbers for this field
            /// </summary>
            [XmlElement("year")]
            public string year
            {
                get;
                set;
            }
            /// <summary>
            /// The cost of the bike will display a '$' sign in front of user input
            /// </summary>
            [XmlElement("cost")]
            public string cost
            {
                get;
                set;
            }

            /// <summary>
            /// Used to sort the bikes by their Model name
            /// </summary>
            /// <param name="other"></param>
            /// <returns></returns>
            public int CompareTo(Bikes other)
            {
                return this.model.CompareTo(other.model);
            }
        }//End of class Bikes

        /// <summary>
        /// As the form loads it looks for an XML File data and displays data via ListView, tooltips and satusbar.
        /// IF 'bikes.xml' does not exist it is created, ELSE the data from the xml file is loaded into the ListArray.
        /// ListArray is then saved to a temporary xml and data is displayed into the listview. Tooltips for textboxes 
        /// labels and buttons are loaded. Finally a status message is displayed telling the user how many items are
        ///  in the ListArray.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMyBikes_Load(object sender, EventArgs e)
        {
            if (!File.Exists("bikes.xml"))
            {
                CreateXml();
            }
            else
            {
                myBikes = ReadXml<List<Bikes>>("bikes.xml");
            }

            TempSave();
            DisplayInfo();
            ToolTipSect();

            stsMessage.Text = "Welcome, you have " + myBikes.Count + " motorbikes in your collection";
        }//END of frmMyBikes_Load event

        /// <summary>
        /// When a user clicks on a bike that is listed in the ListView the details for that bike are displayed into their
        /// corresponding textboxes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvwBikeDetails_MouseClick(object sender, MouseEventArgs e)
        {
            int indx = lvwBikeDetails.FocusedItem.Index;
            tbMake.Text = myBikes[indx].make;
            tbModel.Text = myBikes[indx].model;
            tbSize.Text = myBikes[indx].size;
            tbYear.Text = myBikes[indx].year;
            tbCost.Text = myBikes[indx].cost;
        }//END of lvwBikeDetails_MouseClick    

        /// <summary>
        /// Clicking the Add button adds a bike to the list by calling AddBike() method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddBike();
        }//END of btnAdd

        /// <summary>
        /// Deletes a bike from the list by calling the DeleteBike() method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBike();
        }//END of btnDelete

        /// <summary>
        ///  Updates changes to any of the bike details the user has editied by calling the RunUpdate() method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            RunUpdate();
        }//END of btnUpdate

        /// <summary>
        /// Clicking the Save button calls the 'SaveList' method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveList();
        }//END of btnSave

        /// <summary>
        ///  Clicking the Clear button watermarks all the texboxes by calling ResetFields().
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetFields();
        }//End ob btnClear

        /// <summary>
        /// When the user clicks on the X in the corner of the application is clicked IF the 'OnExit' has not been called
        /// before then 'exitBikes' boolean value should be false and the 'OnExit' method is called which changes the 
        /// 'exitBikes' variable to TRUE, this code prevents 'OnExit' been called twice. IF 'OnExit' has been called but
        /// the application has not closed then user has cancelled the event making the 'cancelExit' varaible TRUE but this
        /// boolean variable needs to be reset to FALSE so the user is able to cancel the event again.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMyBikes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exitBikes == false)
            {
                OnExit();
            }
            if (cancelExit == true)
            {
                e.Cancel = true;
                cancelExit = false;
            }
        }//END of frmMyBikes_FormClosing

        /// <summary>
        /// Opens the user guide for the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuUserGuide_Click(object sender, EventArgs e)
        {
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = "My Bike User Guide.pdf";
            myProcess.Start();
        }//END of mnuUserGuide

        /// <summary>
        /// Clicking save in the file menu saves the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuSave_Click(object sender, EventArgs e)
        {
            SaveList();
        }//END of mnuSave

        /// <summary>
        /// mnuExit_Click is similar to closing the form but canceling in this instance only changes the varaible 'cancelExit'
        /// back to FALSE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuExit_Click(object sender, EventArgs e)
        {
            if (exitBikes == false)
            {
                OnExit();
            }
            if (cancelExit == true)
            {
                cancelExit = false;
            }
        }//END of mnuExit

        /// <summary>
        /// The tooltips were put into their own method to make the code in the frmMyBikes_Load shorter and easier
        /// to read
        /// </summary>
        private void ToolTipSect()
        {
            string theMake = "Who is the motorbike manufacturer";
            string theModel = "Enter the model of the motorbike";
            string theSize = "Put in the engine size of the motorbike";
            string theYear = "What year was motorbike manufactered";
            string theCost = "How much is the motorbike worth";

            toolTips.ShowAlways = true;
            toolTips.SetToolTip(btnClear, "Clears all details in the fields below");
            toolTips.SetToolTip(btnAdd, "Adds motorbike make, model ,etc from each field to the list");
            toolTips.SetToolTip(btnDelete, "Delete bike from list");
            toolTips.SetToolTip(btnUpdate, "Updates bikes information");
            toolTips.SetToolTip(btnSave, "Saves list to xml file");

            toolTips.SetToolTip(lblMake, theMake);
            toolTips.SetToolTip(tbMake, theMake);

            toolTips.SetToolTip(lblModel, theModel);
            toolTips.SetToolTip(tbModel, theModel);

            toolTips.SetToolTip(lblSize, theSize);
            toolTips.SetToolTip(tbSize, theSize);

            toolTips.SetToolTip(lblYear, theYear);
            toolTips.SetToolTip(tbYear, theYear);

            toolTips.SetToolTip(lblCost, theCost);
            toolTips.SetToolTip(tbCost, theCost);
        }//END of ToolTipSect

        /// <summary>
        /// Creates the Xml file that is used to store data from the ListArray by declaring a new instance of XmlWriter 
        /// and creates the 'bikes.xml' file it then ensures future data will be encoded so it can be read as an xml file.
        /// </summary>
        private void CreateXml()
        {
            using (XmlWriter writer = XmlWriter.Create("bikes.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Bikes>));
                serializer.Serialize(writer, myBikes);
                writer.Close();
            }
        }//END of CreateXml

        /// <summary>
        /// TRY to read Xml file where specified (fileName) using the StreamReader on file and  then deserializes or 
        /// unencodes xml data within file can be RETURNED into the  ArrayList and in turn the ListView, FINALLY if 
        /// either the file or nothing is found StreamReader is closed.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static T ReadXml<T>(string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                reader = new StreamReader(filePath);
                return (T)serializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }//END of ReadXml

        /// <summary>
        /// This method saves a temporary xml file ('temp.xml') which is used later to check if the user has made any
        /// changes to the ListArray since the last time it was saved to 'bikes.xml'.
        /// </summary>
        private void TempSave()
        {
            using (XmlWriter writer = XmlWriter.Create("temp.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Bikes>));
                serializer.Serialize(writer, myBikes);
                writer.Close();
            }
        }//END of TempSave

        /// <summary>
        /// Method to display each item from the ArrayList into the ListView.
        /// </summary>
        private void DisplayInfo()
        {
            lvwBikeDetails.Items.Clear();
            foreach (var bik in myBikes)
            {
                ListViewItem item = new ListViewItem(new string[]
                   {
                    bik.make,
                    bik.model,
                    bik.size,
                    bik.year,
                    bik.cost
                   });
                lvwBikeDetails.Items.Add(item);
            }
        }//END of DisplayInfo

        /// <summary>
        /// Resets the texboxes back to their default style by using a water marking method for each textbox.
        /// </summary>
        private void ResetFields()
        {
            waterMarkOn = false;
            MakeWM();
            ModelWM();
            SizeWM();
            YearWM();
            CostWM();
            waterMarkOn = true;
        }//END of ResetFields

        /// <summary>
        /// This method allows users to update details from the selected item in the ListView each text box to a new
        /// instance of the 'Bikes' class. Then the updated item is loaded back into the ListArray. For tbSize.Text
        /// and tbCost.Text IF do not have they already have symbols representing the data for their particular field
        /// then it is added. The fields are then resetted, the ListArray is sorted, items are redisplayed in the
        /// ListView, temporary xml file saved and a status message is displayed.
        /// </summary>
        public void UpdateBike()
        {
            Bikes updatedBikes = new Bikes();
            updatedBikes.make = tbMake.Text;
            updatedBikes.model = tbModel.Text.ToUpper();
            updatedBikes.size = tbSize.Text;
            updatedBikes.year = tbYear.Text;
            updatedBikes.cost = tbCost.Text;

            int indx = lvwBikeDetails.FocusedItem.Index;
            myBikes[indx].make = updatedBikes.make;
            myBikes[indx].model = updatedBikes.model;
            myBikes[indx].year = updatedBikes.year;

            if (tbSize.Text.EndsWith("cc"))
            {
                myBikes[indx].size = updatedBikes.size;
            }
            else
            {
                myBikes[indx].size = updatedBikes.size + "cc";
            }

            if (tbCost.Text.StartsWith("$"))
            {
                myBikes[indx].cost = updatedBikes.cost;
            }
            else
            {
                myBikes[indx].cost = "$" + updatedBikes.cost;
            }
            ResetFields();
            myBikes.Sort();
            DisplayInfo();
            TempSave();
            stsMessage.Text = "Record has been updated";
        }//END of UpdateBike

        /// <summary>
        /// Method checks IF the user has not selected an item from the ListView a error message is shown otherwise the
        /// selected item checks whether the data in 'model' field has been changed by comparing the item from 'myBikes'
        /// Array with the text from 'tbModel'. IF there is a difference the 'myBikes' Array is checked for duplicates 
        /// and IF there are none the 'UpdateBike' method is called, ELSE an error message is shown.
        /// </summary>
        private void RunUpdate()
        {
            if (lvwBikeDetails.SelectedItems.Count < 1)
            {
                MessageBox.Show("Select a bike model from the list", "Hold On!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int indx = lvwBikeDetails.FocusedItem.Index;
                string modelChange = myBikes[indx].model;
                bool duplicateModel = myBikes.Exists(x => x.model == tbModel.Text.ToUpper());
                if (modelChange != tbModel.Text)
                {
                    if (!duplicateModel)
                    {
                        UpdateBike();
                    }
                    else
                    {
                        MessageBox.Show("You already have " + tbModel.Text.ToUpper() + " model", "Hold On!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    UpdateBike();
                }
            }
        }//END of CheckUpdate

        /// <summary>
        /// Method to check if the 'bikes.xml' needs saving. Compares the differences between the 'temp.xml' and 
        /// 'bikes.xml'. IF there is or is not any  differences between them the 'alreadySaved' boolean value is 
        /// changed accordingly.
        /// </summary>
        private void CheckSave()
        {
            XDocument temp = XDocument.Load("temp.xml");

            XDocument savedFile = XDocument.Load("bikes.xml");

            if (XNode.DeepEquals(temp, savedFile))
            {
                alreadySaved = true;
            }
            else
            {
                alreadySaved = false;
            }
        }//END of CheckSave

        /// <summary>
        /// Method that calls CheckSave method and IF 'alreadySaved' is TRUE then a message is displayed informing the 
        /// user that saving is not necessary, ELSE the CreateXml method is called and a status message is displayed.
        /// </summary>
        private void SaveList()
        {
            CheckSave();
            if (alreadySaved == true)
            {
                MessageBox.Show("No changes made.", "Already Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                stsMessage.Text = "No changes made to your list";
            }
            else
            {
                CreateXml();
                stsMessage.Text = "Your motobike list has been saved!";
            }
        }//END of SaveList

        /// <summary>
        /// Method AddBike takes what the user has typed into the textboxes and puts the data into a new instance
        /// of the 'Bikes' class called 'newBike'. The button event also determines whether or not the user has typed any
        /// data into the textboxes. For 'tbMake' and 'tbModel' there has to be data inputted (apart from the watermark
        /// text). The other textboxes do not need data but IF none is entered the watermark text is removed. IF data is
        /// entered for 'tbSize and 'tbCost' symboys are added to the data. To prevent the user from adding models that are
        /// already in the list, 'myBikes' is checked for models with the same name and the result (either TRUE or FALSE) is
        /// put into the 'duplicateModel' boolean variable. IF not found all items that was addeded into the new class gets
        /// put into 'myBikes' Array, The fields are then resetted, the ListArray is sorted, items are displayed in the
        /// ListView, temporary xml file saved and a status message is displayed.
        /// </summary>
        private void AddBike()
        {
            bool hasInfo = true;

            Bikes newBike = new Bikes();

            newBike.make = tbMake.Text;
            newBike.model = tbModel.Text.ToUpper();

            if (tbSize.Text == "Optional")
            {
                tbSize.Text = "";
            }
            else if (tbSize.Text.EndsWith("cc"))
            {
                newBike.size = tbSize.Text;
            }
            else
            {
                newBike.size = tbSize.Text + "cc";
            }

            if (tbYear.Text == "Optional")
            {
                tbYear.Text = "";
            }
            else
            {
                newBike.year = tbYear.Text;
            }

            if (tbCost.Text == "Optional")
            {
                tbCost.Text = "";
            }
            else if (tbCost.Text.StartsWith("$"))
            {
                newBike.cost = tbCost.Text;
            }
            else
            {
                newBike.cost = "$" + tbCost.Text;
            }

            if (tbMake.Text == "" || tbMake.Text == "Compulsory")
            {
                MessageBox.Show("Please enter the make of the bike", "Hold On!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hasInfo = false;
                return;
            }

            if (tbModel.Text == "" || tbModel.Text == "Compulsory")
            {
                MessageBox.Show("Please enter the model of the bike", "Hold On!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                hasInfo = false;
                return;
            }

            bool duplicateModel = myBikes.Exists(x => x.model == tbModel.Text.ToUpper());

            if (hasInfo && !duplicateModel)
            {
                myBikes.Add(newBike);
                ResetFields();
                myBikes.Sort();
                DisplayInfo();
                TempSave();
                stsMessage.Text = "Record added, you now have " + myBikes.Count + " motorbikes in your collection";
            }
            else
            {
                MessageBox.Show("You already have " + tbModel.Text.ToUpper() + " model", "Hold On!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }//END of AddBike

        /// <summary>
        /// IF the user has not selected an item from the ListView a error message is shown otherwise a dialogbox apperars 
        /// asking to confirm the users actions, IF yes is selected that item is removed from 'myBikes' Array. Then the 
        /// ListView and 'temp.xml' file is updated and a status message is displayed
        /// </summary>
        private void DeleteBike()
        {
            if (lvwBikeDetails.SelectedItems.Count < 1)
            {
                MessageBox.Show("Select a bike model from the list", "Hold On!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int indx = lvwBikeDetails.FocusedItem.Index;
                myBikes.RemoveAt(indx);
                DisplayInfo();
                TempSave();
                stsMessage.Text = "Motorbike has been removed from list, you have " + myBikes.Count + " motorbikes in your collection";
            }
            ResetFields();
        }//END of DeleteBike

        /// <summary>
        /// This method is setup to allow the user to either save or not save their work before closing or not close the
        /// application at all. The CheckSave method is called to determine if the user has saved their work and IF not
        /// a dialog box ask them if they want to save. The 'exitBikes' boolean variable is used to prevent the dialog box 
        /// from repeating when activated. IF yes is selected from the user the SaveList method is called and then 
        /// application is closed, IF no the application is closed and IF cancel is selected the application does returns
        /// to frmMyBikes and changes the boolean 'cancelExit' is used in case the user wants to cancel exiting the
        /// application a second time, without out the dialog box will not disappear.IF the user has saved before exiting 
        /// a similar dialog box will appear without the save option.
        /// </summary>
        private void OnExit()
        {
            CheckSave();
            if (alreadySaved == false)
            {
                DialogResult onQuit = MessageBox.Show("Do you want to save before you exit?", "Save Before Exiting?",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                exitBikes = true;

                if (onQuit == DialogResult.Yes)
                {
                    SaveList();
                    Application.Exit();
                }
                else if (onQuit == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    cancelExit = true;
                    exitBikes = false;
                }
            }
            else
            {
                DialogResult onQuit = MessageBox.Show("Are you sure you want to exit?", "Exiting",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                exitBikes = true;

                if (onQuit == DialogResult.Yes)
                {

                    Application.Exit();
                }
                else
                {
                    cancelExit = true;
                    exitBikes = false;
                }
            }
        }//END of OnExit

        /// <summary>
        /// This method displays the default text as gray and italic unless its called upon while the user is typing 
        /// into a textbox.
        /// </summary>
        private void MakeWM()
        {
            if (waterMarkOn == true)
            {
                tbMake.Font = new Font(tbMake.Font, FontStyle.Regular);
                tbMake.ForeColor = Color.Black;
            }
            else
            {
                tbMake.Font = new Font(tbMake.Font, FontStyle.Italic);
                tbMake.Text = "Compulsory";
                tbMake.ForeColor = Color.Gray;
            }
        }//END of MakeWM()

        private void ModelWM()
        {
            if (waterMarkOn == true)
            {
                tbModel.Font = new Font(tbModel.Font, FontStyle.Regular);
                tbModel.ForeColor = Color.Black;
            }
            else
            {
                tbModel.Font = new Font(tbModel.Font, FontStyle.Italic);
                tbModel.Text = "Compulsory";
                tbModel.ForeColor = Color.Gray;
            }
        }//END of ModelWM()

        private void SizeWM()
        {
            if (waterMarkOn == true)
            {
                tbSize.Font = new Font(tbSize.Font, FontStyle.Regular);
                tbSize.ForeColor = Color.Black;
            }
            else
            {
                tbSize.Font = new Font(tbSize.Font, FontStyle.Italic);
                tbSize.Text = "Optional";
                tbSize.ForeColor = Color.Gray;
            }
        }//END of SizeWM()

        private void YearWM()
        {
            if (waterMarkOn == true)
            {
                tbYear.Font = new Font(tbYear.Font, FontStyle.Regular);
                tbYear.ForeColor = Color.Black;
            }
            else
            {
                tbYear.Font = new Font(tbYear.Font, FontStyle.Italic);
                tbYear.Text = "Optional";
                tbYear.ForeColor = Color.Gray;
            }
        }//END of YearWM()

        private void CostWM()
        {
            if (waterMarkOn == true)
            {
                tbCost.Font = new Font(tbCost.Font, FontStyle.Regular);
                tbCost.ForeColor = Color.Black;
            }
            else
            {
                tbCost.Font = new Font(tbCost.Font, FontStyle.Italic);
                tbCost.Text = "Optional";
                tbCost.ForeColor = Color.Gray;
            }
        }//END of CostWM()

        /// <summary>
        /// When the user types the default watermark text reverts back to standand black and normal font by calling
        /// the MakeWM() method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbMake_TextChanged(object sender, EventArgs e)
        {
            MakeWM();
        }//END of tbMake_TextChanged

        private void tbModel_TextChanged(object sender, EventArgs e)
        {
            ModelWM();
        }//END of tbModel_TextChanged

        private void tbSize_TextChanged(object sender, EventArgs e)
        {
            SizeWM();
        }//END of tbSize_TextChanged

        private void tbYear_TextChanged(object sender, EventArgs e)
        {
            YearWM();
        }//END of tbYear_TextChanged

        private void tbCost_TextChanged(object sender, EventArgs e)
        {
            CostWM();
        }//END of tbCost_TextChanged

        /// <summary>
        /// Selects all text currently in a text box which is used to clear the default watermark text as the user types
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbMake_Click(object sender, EventArgs e)
        {
            tbMake.SelectAll();
        }//END of tbMake_Click

        private void tbModel_Click(object sender, EventArgs e)
        {
            tbModel.SelectAll();
        }//END of tbModel_Click

        private void tbSize_Click(object sender, EventArgs e)
        {
            tbSize.SelectAll();
        }//END of tbSize_Click

        private void tbYear_Click(object sender, EventArgs e)
        {
            tbYear.SelectAll();
        }//END of tbYear_Click

        private void tbCost_Click(object sender, EventArgs e)
        {
            tbCost.SelectAll();
        }//END of  tbCost_Click

        /// <summary>
        /// This section blocks the user from typing in IF anything but numbers for tbSize, tbYear and tbCost, 
        /// apart from numbers the arrow keys and back space can be used
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }//END of tbSize_KeyPress

        private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }//END of tbYear_KeyPress

        private void tbCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }//END of tbCost_KeyPress
    }
}
