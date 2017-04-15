using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace New
{
    public partial class TechDic : Form
    {
        public TechDic()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string path = Environment.CurrentDirectory;
            string file = path + @"\dic.txt";
            if(!File.Exists(file))
                File.Create(file);
            String items = (item.Text);
            items=items.ToUpper();
            Hashtable Dic = new Hashtable();
            Dic.Add("I.T", "SHORT FORM OF INFORMATION TECHNOLOGY");
            Dic.Add("CPU", "SHORT FORM OF CENTRAL PROCESSING UNIT");
            Dic.Add("MOUSE", "AN INPUT DEVICE ");
            Dic.Add("GOOGLE", "A WORDWIDE SEARCH ENGINE ");
            Dic.Add("LAPTOP", "A PORTABLE COMPUTER");
            Dic.Add("BEAMWARE", "A GAME AND SOFTWARE COMPANY IN INDIA");
            Dic.Add("C", "A COMPUTER PROGRAMING LANGUAGE");
            Dic.Add("C++","A OBJECT ORIENTED PROGRAMING LANGUAGE BY BJARNE STROUSTRUP");
            Dic.Add("C#", "A NEWLY INVENTED OBJECT ORIENTED PROGRAMMING LANGUAGE");
            Dic.Add("KEYBOARD", "A INPUT DEVICE USED TO GIVE INSTRUCTIONS TO COMPUTER");
            Dic.Add("WINDOWS", "AN  OPERATING SYSTEM WHICH INVENTED BY MICROSOFT");
            Dic.Add("APPLE", "THE WORD WIDE COMPUTER  COMPANY FOUNDED BY STIEVE JOBS");
            if (Dic.ContainsKey(items) == true)
            {
                //foreach(String s in File.ReadAllLines)
                //{
                
                //}
                view.Text = items + " : " + Dic[items];
            }
            else
                view.Text = "Cannot Found";
        }

        private void TechDic_Load(object sender, EventArgs e)
        {
            item.Focus();
        }

        private void item_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

    }
}
