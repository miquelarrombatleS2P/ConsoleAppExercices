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

namespace TextFilesStandard
{
    public partial class Form1 : Form
    {
        // create a generic list of the person class
        BindingList<Person> persons = new BindingList<Person>();
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
            String[] list = File.ReadAllLines("C:/Users/Miquel/source/repos/ConsoleAppExercices/TextFilesStandard/StandardDataSet.csv");

            // We go through the whole array and then put it in the listbox
            for (int i = 1; i < list.Length; i++)
            {
                // we divide the attributes of each person
                String[] contains = list[i].Split(',');
                bool live = false;

                // if isalive 
                if (contains[3] == "1")
                {
                    live = true;
                }
                persons.Add(new Person
                {
                    firtsName = contains[0],
                    lastName = contains[1],
                    years = int.Parse(contains[2]),
                    islive = live
                });
            }

        }
    }
}
