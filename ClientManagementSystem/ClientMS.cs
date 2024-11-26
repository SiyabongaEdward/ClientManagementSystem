using ClientManagementSystem.Models;
using ClientManagementSystem.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ClientManagementSystem
{
    public partial class ClientMS : Form
    {
        enum transactionType
        {
            New,
            Update
        }
        transactionType transType = transactionType.New;

        List<ServiceReference1.Client> clients = new List<ServiceReference1.Client>();

        public ClientMS()
        {
            InitializeComponent();
            getClients();
        }

        public void bindControls() 
        {
            dgvClients.DataSource = null;
            dgvClients.DataSource = clients;
           
        }

        public void getClients() 
        {
            clients.Clear();
            ServiceReference1.Service1Client serviceRef = new ServiceReference1.Service1Client();
            //List<ServiceReference1.Client> ClientList = new List<ServiceReference1.Client>();
            clients = serviceRef.GetClients();
            bindControls();
        }

        public ServiceReference1.Address getAddress(int ClientID)
        {
            ServiceReference1.Service1Client serviceRef = new ServiceReference1.Service1Client();
            return serviceRef.GetClientAddress(ClientID);
        }

        public ServiceReference1.Contact getContact(int ClientID)
        {
            ServiceReference1.Service1Client serviceRef = new ServiceReference1.Service1Client();
            return serviceRef.GetContact(ClientID);
        }

        public bool ValidateForm() 
        {
            bool isValid = true;
            string message = string.Empty;

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                message += $"First name is required{Environment.NewLine}";
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                message += $"Last name is required{Environment.NewLine}";
                isValid = false;
            }

            if (!isValid)
            {
                MessageBox.Show(message, "Data Invalid",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
            }
            return isValid;
        
        }

        public void ExportClientsToCsv(string filePath)
        {
            var directory = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("ClientID,FirstName,LastName,Gender,Ethnicity,MaritalStatus,CellNumber,WorkNumber,Residentialddress,Workddress,Postalddress");

                foreach (var client in clients)
                {
                    ServiceReference1.Address address = getAddress(client.ClientID);
                    ServiceReference1.Contact contact = getContact(client.ClientID);

                    writer.WriteLine($"{client.ClientID},{client.FirstName},{client.LastName},{client.Gender},{client.Ethnicity},{client.MaritalStatus},{contact.CellNumber},{contact.WorkNumber},{address.Residentialddress},{address.Workddress},{address.Postalddress}");
                }
            }
        }


        public void ClearControls() 
        {
            txtClientID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            cboGender.SelectedIndex = -1;
            cboEthnicity.SelectedIndex = -1;
            cboMaritalStatus.SelectedIndex = -1;
            txtResAddress.Text = "";
            txtWorkAddress.Text = "";
            txtPostalAddress.Text = "";
            txtCellNo.Text = "";
            txtWorkTel.Text = "";

            transType = transactionType.New;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm())
                    return;
                ServiceReference1.Service1Client serviceRef = new ServiceReference1.Service1Client();
                if (transType == transactionType.New) 
                {

                    ServiceReference1.Client client = new ServiceReference1.Client
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Gender = cboGender.Text,
                        Ethnicity = cboEthnicity.Text,
                        MaritalStatus = cboMaritalStatus.Text
                    };

                    int ClientID = serviceRef.AddClient(client);

                    ServiceReference1.Address address = new ServiceReference1.Address
                    {
                        ClientID = ClientID,
                        Residentialddress = txtResAddress.Text,
                        Workddress = txtWorkAddress.Text,
                        Postalddress = txtPostalAddress.Text
                    };

                    serviceRef.AddAddress(address);

                    ServiceReference1.Contact contact = new ServiceReference1.Contact
                    {
                        ClientID = ClientID,
                        CellNumber = txtCellNo.Text,
                        WorkNumber = txtWorkTel.Text
                    };
                    serviceRef.AddContact(contact);

                }
                else
                {
                    int ClientID = int.Parse(txtClientID.Text);
                    ServiceReference1.Client client = new ServiceReference1.Client
                    {
                        ClientID = ClientID,
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Gender = cboGender.Text,
                        Ethnicity = cboEthnicity.Text,
                        MaritalStatus = cboMaritalStatus.Text
                    };
                    serviceRef.UpdateClient(client);


                    ServiceReference1.Address address = new ServiceReference1.Address
                    {
                        ClientID = ClientID,
                        Residentialddress = txtResAddress.Text,
                        Workddress = txtWorkAddress.Text,
                        Postalddress = txtPostalAddress.Text
                    };

                    serviceRef.UpdateAddress(address);

                    ServiceReference1.Contact contact = new ServiceReference1.Contact
                    {
                        ClientID = ClientID,
                        CellNumber = txtCellNo.Text,
                        WorkNumber = txtWorkTel.Text
                    };
                    serviceRef.UpdateContact(contact);
                }

                MessageBox.Show("DataRecord Saved", "",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);

                getClients();
                ClearControls();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvClients.CurrentRow.Selected = true;
            int ClientID = (int)dgvClients.Rows[e.RowIndex].Cells["ClientID"].Value;

            ServiceReference1.Address address = getAddress(ClientID);
            ServiceReference1.Contact contact = getContact(ClientID);

            txtClientID.Text = ClientID.ToString();
            txtFirstName.Text = dgvClients.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
            txtLastName.Text = dgvClients.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
            cboGender.Text = dgvClients.Rows[e.RowIndex].Cells["Gender"].Value.ToString(); ;
            cboEthnicity.Text = dgvClients.Rows[e.RowIndex].Cells["Ethnicity"].Value.ToString(); ;
            cboMaritalStatus.Text = dgvClients.Rows[e.RowIndex].Cells["MaritalStatus"].Value.ToString(); ;
            txtResAddress.Text = address.Residentialddress;
            txtWorkAddress.Text = address.Workddress;
            txtPostalAddress.Text = address.Postalddress;
            txtCellNo.Text = contact.CellNumber;
            txtWorkTel.Text = contact.WorkNumber;

            transType = transactionType.Update;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            ExportClientsToCsv("ClientTextFile.txt");
            MessageBox.Show("Records Succesfully Exported to File", "",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }
    }
}
