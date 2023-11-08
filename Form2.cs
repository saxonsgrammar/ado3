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
    public partial class Form2 : Form
    {
        PersonContext db = new PersonContext();
        public Form2()
        {
            InitializeComponent();
            label1.Text = "";
            //using (db = new User())
            //{
            //    Person person1 = new Person() { Name = "Andrey", Age = 24, City = "Kyiv" };
            //    Person person2 = new Person() { Name = "Liza", Age = 18, City = "Kryvyi Rih" };
            //    Person person3 = new Person() { Name = "Oleg", Age = 15, City = "London" };
            //    Person person4 = new Person() { Name = "Sergey", Age = 55, City = "Kyiv" };
            //    Person person5 = new Person() { Name = "Sergey", Age = 32, City = "Kyiv" };

            //    db.Persons.Add(person1);
            //    db.Persons.Add(person2);
            //    db.Persons.Add(person3);
            //    db.Persons.Add(person4);
            //    db.Persons.Add(person5);
            //    db.SaveChanges();
            //}
        }
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "> 25";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 47);
            this.button2.TabIndex = 1;
            this.button2.Text = "not in Kyiv";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(392, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "in Kyiv";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(100, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 47);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sergey, > 35";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(302, 184);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 47);
            this.button5.TabIndex = 4;
            this.button5.Text = "in Kryvyi Rih";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(582, 247);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Задание 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            var persons = db.Persons;
            foreach (Person p in persons.Where(p => p.Age > 25))
            {
                label1.Text += p.Name + ", " + p.Age + "\n";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            var persons = db.Persons;
            foreach (Person p in persons.Where(p => p.City != "Kyiv"))
            {
                label1.Text += p.Name + ", " + p.Age + "\n";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            var persons = db.Persons;
            foreach (Person p in persons.Where(p => p.City == "Kyiv"))
            {
                label1.Text += p.Name + ", " + p.Age + "\n";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            var persons = db.Persons;
            foreach (Person p in persons.Where(p => p.Age > 35).Where(p => p.Name == "Sergey"))
            {
                label1.Text += p.Id + "\n";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            var persons = db.Persons;
            foreach (Person p in persons.Where(p => p.City == "Kryvyi Rih"))
            {
                label1.Text += p.Name + ", " + p.Age + "\n";
            }
        }
    }   
}