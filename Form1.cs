using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;

namespace praktish
{
    public partial class Form1 : Form
    {
        Dictionary<string,string> conditions = new Dictionary<string,string>();

        public Form1()
        {
            InitializeComponent();
        }

        static bool EvaluateCondition(string condition, string variable, double value)
        {
            Expression expression = new Expression(condition);
            expression.Parameters[variable] = value;
            return (bool)expression.Evaluate();
        }

        static double EvaluateExpression(string expression, string variable, double value)
        {
            Expression expr = new Expression(expression);
            expr.Parameters[variable] = value;
            return Convert.ToDouble(expr.Evaluate());
        }


        private void button_condition_add_Click(object sender, EventArgs e)
        {
            if(textBox_condition.Text.Length == 0 )
            {
                label_conditions.Text += textBox_expression.Text + " в остальных случаях\n";
                conditions.Add(textBox_expression.Text, "1=1");
                textBox_expression.Text = string.Empty;
                return;
            }

            label_conditions.Text += textBox_expression.Text + " если " + textBox_condition.Text + '\n';
            conditions.Add(textBox_expression.Text, textBox_condition.Text);
            textBox_expression.Text = string.Empty;
            textBox_condition.Text = string.Empty;
        }

        private void button_conditions_clear_Click(object sender, EventArgs e)
        {
            conditions.Clear();
            label_conditions.Text = string.Empty;
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            foreach(KeyValuePair<string,string> kvp in conditions)
            {
                if (EvaluateCondition(kvp.Value, textBox_variable_name.Text, Convert.ToDouble(textBox_variable_value.Text)))
                {
                    label_answer.Text = Convert.ToString(EvaluateExpression(kvp.Key, textBox_variable_name.Text, Convert.ToDouble(textBox_variable_value.Text)));
                    return;
                }
            }
        }
    }
}
