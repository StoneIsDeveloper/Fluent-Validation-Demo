using CoreModel;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Validators;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        BindingList<string> errors = new BindingList<string>();

        public Form1()
        {
            InitializeComponent();
            errorListBox.DataSource = errors;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // decimal accountBalance = 0;
            errors.Clear();

            if(!decimal.TryParse(accountBalanceinput.Text, out decimal accountBalance))
            {
                errors.Add("accountBalance error !");
                return;
            }

            PersonalModel personal = new PersonalModel();

            personal.FirstName = this.fisrtNameInput.Text;
            personal.LastName = this.lastNameInput.Text;
            personal.AccountBalance = accountBalance;
            personal.DateOfBirth = this.dateOfBirthInput.Value;

            // validate data
            PersonValidator validator = new PersonValidator();

            ValidationResult results = validator.Validate(personal);

            if(results.IsValid == false)
            {
                foreach (ValidationFailure failure in results.Errors)
                {
                    errors.Add($"{ failure.PropertyName }： { failure.ErrorMessage }");
                }
            }

            // insert into DB

            MessageBox.Show("Operation Complete");

        }
    }
}
