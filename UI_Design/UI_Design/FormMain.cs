﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;


namespace UI_Design
{
    
    public partial class FormMain : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        readonly BabyDbContext db;

        private static Child child;
        private static Parent parent;

        public FormMain()
        {
            db = new BabyDbContext();

            db.Parents.Load();
            db.Childs.Load();
            db.Growth_Weights.Load();
            db.Images.Load();

            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            FormLogin logForm = new FormLogin();

            if (AuthService.LoginParentTrue(this, logForm))
            {
                parent = logForm.GetParent();
            }
            else
            {
                //а мы в эту ветку кода вообще попадем?
            }
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            StylesService.ViewClickButton(sender, pnlNav);
            lblTitle.Text = "Home";
            this.pnlFormLoader.Controls.Clear();
            //Form1 formHome = new Form1(); //{ Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //formHome.FormBorderStyle = FormBorderStyle.None;
            //this.pnlFormLoader.Controls.Add(formHome);
            //formHome.Show();
        }

        private void BtnDocuments_Click(object sender, EventArgs e)
        {
            StylesService.ViewClickButton(sender, pnlNav);

            FormDocuments fornDoc = new FormDocuments();
            StylesService.CreateForm(fornDoc, pnlFormLoader, lblTitle, "Documents");           
        }

        private void BtnMed_Click(object sender, EventArgs e)
        {
            StylesService.ViewClickButton(sender, pnlNav);

            FormMedicen formMed = new FormMedicen();
            StylesService.CreateForm(formMed, pnlFormLoader, lblTitle, "Medicina");       
           
        }

        private void BtnGrowth_Click(object sender, EventArgs e)
        {
            StylesService.ViewClickButton(sender, pnlNav);
        }

        private void BtnWeight_Click(object sender, EventArgs e)
        {
            StylesService.ViewClickButton(sender, pnlNav);
        }

        private void BtnAddChild_Click(object sender, EventArgs e)
        {
            StylesService.ViewClickButton(sender, pnlNav);        

            FormAddChild formAddChild = new FormAddChild(parent);//передали сущность Parent того кто залогинился в форме FormAddChild

            if(AuthService.AddChildTrue(this, formAddChild))
            {
                child = formAddChild.GetChild();
            }
            else
            {
                // сюда скорее всего не попадем
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            StylesService.ViewClickButton(sender, pnlNav);
        }

        private void BtnAll_Leave(object sender, EventArgs e)//курсор покинул пределы любой кнопки
        {
            StylesService.ViewBackColorButton(sender);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}