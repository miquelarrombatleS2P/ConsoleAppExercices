using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextFiles;

namespace TextFilesAdvanced
{
    public partial class Form1 : Form
    {
        // create a generic list of the person class
        BindingList<Person> persons = new BindingList<Person>();
        int orderFirstName = 0;
        int orderLastName = 0;
        int orderYear = 0;
        int orderIsAlive = 0;

        public Form1()
        {
            InitializeComponent();

            list();

            personList();
        }

        private void personList()
        {
            // Sets the data source for the person class to display data.
            listBox1.DataSource = persons;
            // Sets a string that specifies where to gather selections to display in the drop-down list.
            listBox1.DisplayMember = nameof(Person.putText);
        }

        public void list()
        {
            // We introduce in a string array the loaded file
            String[] list = File.ReadAllLines("C:/Users/Miquel/source/repos/ConsoleAppExercices/TextFilesAdvanced/AdvancedDataSet.csv");

            String[] columns = list[0].Split(',');

            for (int i = 0; i < columns.Length; i++)
            {
                if (columns[i] == "FirstName")
                {
                    orderFirstName = i;
                }
                else if (columns[i] == "LastName")
                {
                    orderLastName = i;
                }
                else if (columns[i] == "Age")
                {
                    orderYear = i;
                }else
                {
                    orderIsAlive = i;
                }
            }

            // We go through the whole array and then put it in the listbox
            for (int i = 1; i < list.Length; i++)
            {
                // we divide the attributes of each person
                String[] contains = list[i].Split(',');
                bool live = false;

                // if isalive 
                if (contains[orderIsAlive] == "1")
                {
                    live = true;
                }
                persons.Add(new Person
                {
                    firtsName = contains[orderFirstName],
                    lastName = contains[orderLastName],
                    years = int.Parse(contains[orderYear]),
                    islive = live
                });
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            persons.Add(new Person
            {
                firtsName = FirstNameBox1.Text,
                lastName = LastNameBox2.Text,
                years = (int)yearsNumeric.Value,
                islive = AliveBox1.Checked

            });

            FirstNameBox1.Text = "";
            LastNameBox2.Text = "";
            yearsNumeric.Value = 0;
            AliveBox1.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> groupPersons = new List<string>();

            groupPersons.Add("firstName,lastName,years,isalive");

            foreach (Person item in persons)
            {
                int aliveValue = 0;

                if (item.islive == true)
                {
                    aliveValue = 1;
                }

                groupPersons.Add($"{item.firtsName},{item.lastName},{item.years},{item.islive}");
            }

            File.WriteAllLines("C:/Users/Miquel/source/repos/ConsoleAppExercices/TextFilesAdvanced/AdvancedDataSet.csv", groupPersons);

            MessageBox.Show("Save complete!");
        }

        private void FirstNameBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
