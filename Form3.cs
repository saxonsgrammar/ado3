using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ado3
{
    public partial class Form3 : Form
    {
        EmployeeContext db2 = new EmployeeContext();
        public Form3()
        {
            InitializeComponent();
            label2.Text = "";
            //using (db2)
            //{
            //    List<Department> departments = new List<Department>()
            //    {
            //        new Department(){ Id = 1, Country = "Ukraine", City = "Donetsk" },
            //        new Department(){ Id = 2, Country = "Ukraine", City = "Kyiv" },
            //        new Department(){ Id = 3, Country = "France", City = "Paris" },
            //        new Department(){ Id = 4, Country = "UK", City = "London" }
            //    };
            //    db2.Departments.AddRange(departments);
            //    db2.SaveChanges();

            //    List<Employee> employees = new List<Employee>()
            //    {
            //        new Employee(){ Id = 1, FirstName = "Tamara", LastName = "Ivanova", Age = 22, DepId = 2 },
            //        new Employee(){ Id = 2, FirstName = "Nikita", LastName = "Larin", Age = 33, DepId = 1 },
            //        new Employee() { Id = 3, FirstName = "Alica", LastName = "Ivanova", Age = 43, DepId = 3 },
            //        new Employee() { Id = 4, FirstName = "Lida", LastName = "Marusyk", Age = 22, DepId = 2 },
            //        new Employee() { Id = 5, FirstName = "Lida", LastName = "Voron", Age = 36, DepId = 4 },
            //        new Employee() { Id = 6, FirstName = "Ivan", LastName = "Kalyta", Age = 22, DepId = 2 },
            //        new Employee() { Id = 7, FirstName = "Nikita", LastName = " Krotov ", Age = 27,DepId = 4 }
            //    };
            //    db2.Employees.AddRange(employees);
            //    db2.SaveChanges();
            //}
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            List<Department> dep = db2.Departments.ToList();
            List<Employee> employers = db2.Employees.ToList();
            foreach (Employee emp in employers.Where(emp => emp.DepId == dep.Where(d => d.Country == "Ukraine").Where(d => d.City != "Donetsk").FirstOrDefault().Id))
            {
                label2.Text += emp.FirstName + " " + emp.LastName + "\n";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            List<Department> dep = db2.Departments.ToList();
            foreach (Department d in dep.Distinct())
            {
                label2.Text += d.Country + "\n";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            List<Employee> employers = db2.Employees.ToList();
            foreach (Employee emp in employers.Where(emp => emp.Age > 25).Take(3))
            {
                label2.Text += emp.FirstName + " " + emp.LastName + "\n";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            List<Employee> employers = db2.Employees.ToList();
            List<Department> dep = db2.Departments.ToList();
            foreach (Employee emp in employers.Where(emp => emp.Age > 20).Where(emp => emp.DepId == dep.Where(d => d.City == "Kyiv").FirstOrDefault().Id))
            {
                label2.Text += emp.FirstName + " " + emp.LastName + ", " + emp.Age + "\n";
            }
        }
    }
}