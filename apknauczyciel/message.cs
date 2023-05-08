﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tylka.dziennik_funkcje;

namespace Tylka.apknauczyciel
{
    public partial class message : UserControl
    {
        public message()
        {
            InitializeComponent();
        }
        private DataTable dtwiadomosci;
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private SqlConnection conn = new SqlConnection(@"Server=tcp:onlinegradebook.database.windows.net,1433;Initial Catalog=onlinegradebookproject;Persist Security Info=False;User ID=theedziu;Password=Kacper123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        private int currentPage = 1;
        private int pageSize = 5;
        private int maxPage;
        private List<Label> labels = new List<Label>();
        private List<Button> buttons = new List<Button>();
        private void DisplayMessages()
        {
            // ...
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = $"SELECT Wiadomosci.subject,Wiadomosci.text,Wiadomosci.time, CONCAT(CONCAT(users.name,' '),users.surname) AS sender_name FROM Wiadomosci JOIN users ON users.id=Wiadomosci.id_sender WHERE Wiadomosci.id_receiver = {UserData.user_id} OR Wiadomosci.publicmessage = 1 ORDER BY Wiadomosci.id OFFSET {(currentPage - 1) * pageSize} ROWS FETCH NEXT {pageSize} ROWS ONLY";
            // Create a SqlDataAdapter object to fill a DataTable
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // Create new labels for each message
            int y = 50; // vertical position of labels
            foreach (DataRow row in dt.Rows)
            {
                Label label = new Label();
                Button button = new Button();

                //get data
                string senderName = row["sender_name"].ToString();
                string subject = row["subject"].ToString();
                string message = row["text"].ToString();
                DateTime dateSent = ((DateTime)row["time"]).Date;
                string formattedDate = dateSent.ToString("dd/MM/yyyy");
                string preview = message.Substring(0, Math.Min(message.Length, 10)) + "...";

                // create label
                label.Text = $"{senderName} - Temat: {subject} Treść: {preview} ({formattedDate}):";
                label.AutoSize = true;
                label.Location = new Point(50, y + 5);
                label.Tag = "Wysłano dnia: " + formattedDate + "\r\nNadawca: " + senderName + "\r\n" + "Temat: " + subject + "\r\n" + "Treść wiadomości: " + "\r\n" + message; // store the full message in the label's Tag property
                labels.Add(label);

                // create button
                button.Text = "Show full";
                button.Location = new Point(500, y);
                button.Tag = label; // store the label that the button belongs to in the Tag property
                button.Click += ShowMessageButton_Click;
                buttons.Add(button);

                // add label and button to form
                this.Controls.Add(label);
                this.Controls.Add(button);

                y += 30;
            }


            // Update the paging controls
            pagenr.Text = $"Page {currentPage} of {maxPage}";
            prvpage.Enabled = currentPage > 1;
            nxtpage.Enabled = currentPage < maxPage;
            conn.Close();
        }

        private void ShowMessageButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Label label = (Label)button.Tag;
            string message = label.Tag.ToString();
            MessageBox.Show(message, "Full Message");
        }
        private void message_Load(object sender, EventArgs e)
        {
            conn.Open();

            // First request: Get the total number of messagesDisplayMessages
            SqlCommand cmdCount = new SqlCommand();
            cmdCount.Connection = conn;
            cmdCount.CommandText = $"SELECT COUNT(*) FROM Wiadomosci WHERE id_receiver = {UserData.user_id} OR publicmessage = 1";
            int totalCount = (int)cmdCount.ExecuteScalar();

            // Calculate the max number of pages
            maxPage = (int)Math.Ceiling((double)totalCount / pageSize);

            DisplayMessages();


        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            SendMessage myControl = new SendMessage();

            // Add the new user control to the parent control's Controls collection
            this.Controls.Add(myControl); // or Parent.Controls.Add(myControl) if the parent control is not this form

            // Set the Dock property of the new user control to Fill
            myControl.Dock = DockStyle.Fill;

            // Bring the new user control to the front
            myControl.BringToFront();
        }
        private void nxtpage_Click_1(object sender, EventArgs e)
        {
            if (currentPage < maxPage)
            {
                currentPage++;
                foreach (Label label in labels)
                {
                    this.Controls.Remove(label);
                    label.Dispose();
                }

                foreach (Button button in buttons)
                {
                    this.Controls.Remove(button);
                    button.Dispose();
                }
                labels.Clear();
                buttons.Clear();
                for (int i = 0; i < 250; i++)
                {

                }
                DisplayMessages();

            }
        }

        private void prvpage_Click_1(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;

                foreach (Label label in labels)
                {
                    this.Controls.Remove(label);
                    label.Dispose();
                }

                foreach (Button button in buttons)
                {
                    this.Controls.Remove(button);
                    button.Dispose();
                }
                labels.Clear();
                buttons.Clear();
                for (int i = 0; i < 250; i++)
                {

                }
                DisplayMessages();
            }
        }
    }
}