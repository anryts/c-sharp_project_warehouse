﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GreatProject
{
    public partial class AddFood : Form
    {
         Food value = new Food();
        List<Food> list_of_value = new List<Food>(); 
        public AddFood()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //if (textBox3.Text.Length != 0)
            //{
            //    value.Expiration_date = textBox3.Text;
            //}
        }

        private void Add_ToList_Click(object sender, EventArgs e)
        {

            //Food value = new Food(textBox1.Text, dateTimePicker1.Value);                                
            //catch (ExpirationDateException ex)               
            //MessageBox.Show(ex.Message);         
               try
                {
                    value.Name = textBox1.Text;
                }
                catch (ZeroLenghtException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                    return;
                }

                try
                {
                    value.Expiration_date = dateTimePicker1.Value;
                }
                catch (ExpirationDateException ex)
                {
                    MessageBox.Show($"{ex.}\n{ex.Message}");
                    return;
                }
           
                    
                    list_of_value.Add(value);
                    listBox1.Items.Add($"Name:{value.Name}  Price:{value.price_of_item()}  Expiration Date:{value.Expiration_date}");
                    MessageBox.Show($"Added!\n{value.Print_Info()}");
            
            
           // value.
          
            textBox1.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void write_in_file_click(object sender, EventArgs e)
        {
          //чи нада воно
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //dateTimePicker1.Format = DateTimePickerFormat.Short;
            //DateTime? selectedDate = dateTimePicker1.Value;
           
        }
    }
}
