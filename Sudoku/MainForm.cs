using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class MainForm : Form
    {
        private Controller m_controller;
        public MainForm()
        {
            InitializeComponent();
        }
        private void InitializeMainForm()
        {
            m_controller = new Controller();
        }

        private void Click()
        {
            int row, col;
            bool editOK;
            /*
             * Hämta strängen eller knapptryckningen?
             * Hämta rad och kolumn
             * Skicka strängen till:
             * editOK = m_controller.EditSquare(row, col, stringToConvert);
             * if(!editOK)
             * {
             *      MessageBox.Show(m_controller.ErrorMessage);
             *      
             * 
             *  
             * }
             * 
             * 
             */
        }
        
    }
}
