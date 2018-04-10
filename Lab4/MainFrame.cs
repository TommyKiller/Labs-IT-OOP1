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

        private void registerBtn_Click(object sender, EventArgs e)
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
                    brandInput.Text, typeInput.Text, Convert.ToInt32(mileageInput.Text));
                LabTask.vehicles.Add(newVehicle);
                output.Rows.Add(newVehicle.id, newVehicle.name, newVehicle.brand,
                    newVehicle.type, newVehicle.mileage);
            }
            else
            {
                errorLable.Text = "Incorrect input!";
            }
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            output.Columns.Add("idCol", "ID");
            output.Columns.Add("nameCol", "Name");
            output.Columns.Add("brandCol", "Brand");
            output.Columns.Add("typeCol", "Type");
            output.Columns.Add("mileageCol", "Mileage");
        }
    }

    public class LabTask
    {
        public static List<Vehicle> vehicles = new List<Vehicle>();

        public struct Vehicle
        {
            public readonly string id;
            public readonly string name;
            public readonly string brand;
            public readonly string type;
            public readonly int mileage;
            public Vehicle(string id, string name, string brand, string type, int mileage)
            {
                this.id = id;
                this.name = name;
                this.brand = brand;
                this.type = type;
                this.mileage = mileage;
            }
        }

        public static bool CheckId(string id)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.id == id) return false;
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
