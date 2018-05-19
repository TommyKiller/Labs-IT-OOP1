using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab4
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            errorLable.Text = "";
            if ((LabTask.CheckInput(idInput.Text, new Regex(@"^[A-Z]{2}[0-9]{4}[A-Z]{2}$"))) &&
                (LabTask.CheckInput(nameInput.Text, new Regex(@"^[^-][0-9a-zA-Z-]{1,}[^-]$"))) &&
                (LabTask.CheckInput(brandInput.Text, new Regex(@"^[A-Z]{1}[a-zA-Z]{1,}$"))) &&
                (LabTask.CheckInput(typeInput.Text, new Regex(@"^(passenger|truck|SUV)$", RegexOptions.IgnoreCase))) &&
                (LabTask.CheckInput(mileageInput.Text, new Regex(@"^\d{1,}$"), true)) &&
                (LabTask.CheckId(idInput.Text)))
            {
                LabTask.Vehicle newVehicle = new LabTask.Vehicle(idInput.Text, nameInput.Text,
                    brandInput.Text, typeInput.Text, mileageInput.Text);
                LabTask.vehicles.Add(newVehicle);
            }
            else
            {
                errorLable.Text = "Incorrect input!";
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            errorLable.Text = "";
            if ((LabTask.CheckInput(idInput.Text, new Regex(@"^[A-Z]{2}[0-9]{4}[A-Z]{2}$"))) &&
                (LabTask.CheckInput(nameInput.Text, new Regex(@"^[^-][0-9a-zA-Z-]{1,}[^-]$"))) &&
                (LabTask.CheckInput(brandInput.Text, new Regex(@"^[A-Z]{1}[a-zA-Z]{1,}$"))) &&
                (LabTask.CheckInput(typeInput.Text, new Regex(@"^(passenger|truck|SUV)$", RegexOptions.IgnoreCase))) &&
                (LabTask.CheckInput(mileageInput.Text, new Regex(@"^\d{1,}$"), true)) &&
                (LabTask.CheckInput(indexInput.Text, new Regex(@"^\d$"), true)) &&
                (Convert.ToInt32(indexInput.Text) < LabTask.vehicles.Count) &&
                (Convert.ToInt32(indexInput.Text) >= 0) &&
                (LabTask.CheckId(idInput.Text)))
            {
                LabTask.Vehicle newVehicle = new LabTask.Vehicle(idInput.Text, nameInput.Text,
                    brandInput.Text, typeInput.Text, mileageInput.Text);
                LabTask.vehicles.Insert(Convert.ToInt32(indexInput.Text), newVehicle);
            }
            else
            {
                errorLable.Text = "Incorrect input!";
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            BindingList<LabTask.Vehicle> temp = new BindingList<LabTask.Vehicle>();
            switch (deleteField.Text)
            {
                case "ID":
                    foreach (LabTask.Vehicle vehicle in LabTask.vehicles)
                    {
                        if (vehicle.IdCol != deleteInput.Text) temp.Add(vehicle);
                    }
                    break;
                case "Name":
                    foreach (LabTask.Vehicle vehicle in LabTask.vehicles)
                    {
                        if (vehicle.NameCol != deleteInput.Text) temp.Add(vehicle);
                    }
                    break;
                case "Brand":
                    foreach (LabTask.Vehicle vehicle in LabTask.vehicles)
                    {
                        if (vehicle.BrandCol != deleteInput.Text) temp.Add(vehicle);
                    }
                    break;
                case "Type":
                    foreach (LabTask.Vehicle vehicle in LabTask.vehicles)
                    {
                        if (vehicle.TypeCol != deleteInput.Text) temp.Add(vehicle);
                    }
                    break;
                case "Mileage":
                    foreach (LabTask.Vehicle vehicle in LabTask.vehicles)
                    {
                        if (vehicle.MileageCol != deleteInput.Text) temp.Add(vehicle);
                    }
                    break;
            }
            LabTask.vehicles = temp;
            output.DataSource = LabTask.vehicles;
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            if (sortCbb.Text != "")
            {
                IEnumerable<LabTask.Vehicle> query = new List<LabTask.Vehicle>(); ;
                switch (sortCbb.Text)
                {
                    case "ID":
                        query = LabTask.vehicles.OrderBy(vehicle => vehicle.IdCol);
                        break;
                    case "Name":
                        query = LabTask.vehicles.OrderBy(vehicle => vehicle.NameCol);
                        break;
                    case "Brand":
                        query = LabTask.vehicles.OrderBy(vehicle => vehicle.BrandCol);
                        break;
                    case "Type":
                        query = LabTask.vehicles.OrderBy(vehicle => vehicle.TypeCol);
                        break;
                    case "Mileage":
                        query = LabTask.vehicles.OrderBy(vehicle => vehicle.MileageCol);
                        break;
                }
                BindingList<LabTask.Vehicle> temp = new BindingList<LabTask.Vehicle>();
                foreach (LabTask.Vehicle vehicle in query)
                {
                    temp.Add(vehicle);
                }
                LabTask.vehicles = temp;
                output.DataSource = LabTask.vehicles;
            }
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in output.Rows)
            {
                row.Selected = false;
                if ((Convert.ToString(row.Cells[0].Value) == findIdInput.Text) ||
                    (Convert.ToString(row.Cells[1].Value) == findNameInput.Text) ||
                    (Convert.ToString(row.Cells[2].Value) == findBrandInput.Text) ||
                    (Convert.ToString(row.Cells[3].Value) == findTypeInput.Text) ||
                    (Convert.ToString(row.Cells[4].Value) == findMileageInput.Text))
                {
                    row.Selected = true;
                }
            }
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            output.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdCol",
                DataPropertyName = "IdCol",
                HeaderText = "ID"
            });
            output.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NameCol",
                DataPropertyName = "NameCol",
                HeaderText = "Name"
            });
            output.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "BrandCol",
                DataPropertyName = "BrandCol",
                HeaderText = "Brand"
            });
            output.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TypeCol",
                DataPropertyName = "TypeCol",
                HeaderText = "Type"
            });
            output.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MileageCol",
                DataPropertyName = "MileageCol",
                HeaderText = "Mileage"
            });
            output.DataSource = LabTask.vehicles;
        }
    }

    public class LabTask
    {
        public static BindingList<Vehicle> vehicles = new BindingList<Vehicle>();

        public struct Vehicle
        {
            public string IdCol { get; set; }
            public string NameCol { get; set; }
            public string BrandCol { get; set; }
            public string TypeCol { get; set; }
            public string MileageCol { get; set; }
            public Vehicle(string id, string name, string brand, string type, string mileage)
            {
                IdCol = id;
                NameCol = name;
                BrandCol = brand;
                TypeCol = type;
                MileageCol = mileage;
            }
        }

        public static bool CheckId(string id)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.IdCol == id) return false;
            }
            return true;
        }

        public static bool CheckInput(string input, Regex regex, bool mode = false)
        {
            try
            {
                if (!regex.IsMatch(input))
                {
                    throw new Exception();
                }
                if (mode)
                {
                    int convertedInput = Convert.ToInt32(input);
                    if (convertedInput < 0)
                    {
                        throw new Exception();
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
