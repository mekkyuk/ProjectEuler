using Business_Layer.Solutions.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Presenter : Form
    {
        public Presenter()
        {
            InitializeComponent();
            var type = typeof(ISolver);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && p != type).ToList();
            types.ForEach(t => cmbQuestions.SelectedIndex = cmbQuestions.Items.Add(t.Name.Replace("Solver", "")));
            txtInput.Focus();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            var type = typeof(ISolver);
            var solverType = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && p.Name == "Solver" + cmbQuestions.Text).Single();
            var solver = (ISolver)Activator.CreateInstance(solverType);
            long input;
            if (long.TryParse(txtInput.Text, out input))
            {
                txtAnswer.Text = solver.Solve(long.Parse(txtInput.Text)).ToString();
            } else
            {
                txtAnswer.Text = solver.Solve(null).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
