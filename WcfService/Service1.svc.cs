using ClientManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        private readonly string connectionString = "Data Source=DESKTOP-SRHQQU4\\MYTESTSERVER;Initial Catalog=ClientWebService;user id=TestAdmin ;password=pa55word";
        public void AddAddress(Address address)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO [Addresses]([ClientID],[ResidentialAddress],[WorkAddress],[PostalAddress]) VALUES(@ClientID,@ResAddress,@WorkAddress,@PostalAddress)";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClientID", address.ClientID);
                command.Parameters.AddWithValue("@ResAddress", address.Residentialddress);
                command.Parameters.AddWithValue("@WorkAddress", address.Workddress);
                command.Parameters.AddWithValue("@PostalAddress", address.Postalddress);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public int AddClient(Client client)
        {
            int ID;
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Clients (FirstName, LastName, Gender, Ethnicity, MaritalStatus) VALUES (@FirstName,@LastName, @Gender, @Ethnicity,@MaritalStatus) ; SELECT SCOPE_IDENTITY();";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", client.FirstName);
                command.Parameters.AddWithValue("@LastName", client.LastName);
                command.Parameters.AddWithValue("@Gender", client.Gender);
                command.Parameters.AddWithValue("@Ethnicity", client.Ethnicity);
                command.Parameters.AddWithValue("@MaritalStatus", client.MaritalStatus);
                connection.Open();
                ID = Convert.ToInt32(command.ExecuteScalar());
            }
            return ID;
        }

        public void AddContact(Contact contact)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO [dbo].[Contacts]([ClientID],[CellNumber],[WorkNumber])VALUES(@ClientID,@CellNumber,@WorkNumber)";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClientID", contact.ClientID);
                command.Parameters.AddWithValue("@CellNumber", contact.CellNumber);
                command.Parameters.AddWithValue("@WorkNumber", contact.WorkNumber);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Address GetClientAddress(int ClientID)
        {
            Address ClientAddress = new Address();
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT [AddressID],[ClientID],[ResidentialAddress],[WorkAddress],[PostalAddress] FROM [ClientWebService].[dbo].[Addresses] WHERE ClientID = @ClientID";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClientID", ClientID);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ClientAddress = new Address
                        {
                            ClientID = (int)reader["ClientID"],
                            AddressID = (int)reader["AddressID"],
                            Residentialddress = reader["ResidentialAddress"].ToString(),
                            Workddress = reader["WorkAddress"].ToString(),
                            Postalddress = reader["PostalAddress"].ToString()
                        };
                    }
                }
            }
            return ClientAddress;
        }

        public List<Client> GetClients()
        {
            List<Client> clients = new List<Client>();
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Clients";
                var command = new SqlCommand(query, connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        clients.Add(new Client
                        {
                            ClientID = (int)reader["ClientID"],
                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            Ethnicity = reader["Ethnicity"].ToString(),
                            MaritalStatus = reader["MaritalStatus"].ToString()
                        });
                    }
                }
            }
            return clients;
        }

        public Contact GetContact(int ClientID)
        {
            Contact ClientContacts = new Contact();
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "SELECT [ContactID],[ClientID],[CellNumber],[WorkNumber] FROM Contacts WHERE ClientID = @ClientID";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClientID", ClientID);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ClientContacts = new Contact
                        {
                            ClientID = (int)reader["ClientID"],
                            ContactID = (int)reader["ClientID"],
                            CellNumber = reader["CellNumber"].ToString(),
                            WorkNumber = reader["WorkNumber"].ToString()
                        };
                    }
                }
            }

            return ClientContacts;
        }
        public void UpdateAddress(Address address)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE [dbo].[Addresses] SET [ResidentialAddress] = @ResAddress,[WorkAddress] = @WorkAddress,[PostalAddress] = @PostalAddress WHERE [ClientID] = @ClientID";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClientID", address.ClientID);
                command.Parameters.AddWithValue("@ResAddress", address.Residentialddress);
                command.Parameters.AddWithValue("@WorkAddress", address.Workddress);
                command.Parameters.AddWithValue("@PostalAddress", address.Postalddress);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateClient(Client client)
        {
            int ID;
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE [dbo].[Clients] SET [FirstName] = @FirstName,[LastName] = @LastName,[Gender] = @Gender,[Ethnicity] = @Ethnicity,[MaritalStatus] = @MaritalStatus WHERE ClientID = @ClientID";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClientID", client.ClientID);
                command.Parameters.AddWithValue("@FirstName", client.FirstName);
                command.Parameters.AddWithValue("@LastName", client.LastName);
                command.Parameters.AddWithValue("@Gender", client.Gender);
                command.Parameters.AddWithValue("@Ethnicity", client.Ethnicity);
                command.Parameters.AddWithValue("@MaritalStatus", client.MaritalStatus);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateContact(Contact contact)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE [dbo].[Contacts] SET [CellNumber] = @CellNumber,[WorkNumber] = @WorkNumber WHERE [ClientID] = @ClientID";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClientID", contact.ClientID);
                command.Parameters.AddWithValue("@CellNumber", contact.CellNumber);
                command.Parameters.AddWithValue("@WorkNumber", contact.WorkNumber);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }


        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

    }
}
