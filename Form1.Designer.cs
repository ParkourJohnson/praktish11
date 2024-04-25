namespace praktish
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_variable_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_variable_value = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_expression = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_condition = new System.Windows.Forms.TextBox();
            this.button_condition_add = new System.Windows.Forms.Button();
            this.button_conditions_clear = new System.Windows.Forms.Button();
            this.label_conditions = new System.Windows.Forms.Label();
            this.label_answer = new System.Windows.Forms.Label();
            this.button_calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя переменной";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_variable_name
            // 
            this.textBox_variable_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_variable_name.Location = new System.Drawing.Point(180, 159);
            this.textBox_variable_name.Name = "textBox_variable_name";
            this.textBox_variable_name.Size = new System.Drawing.Size(47, 26);
            this.textBox_variable_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Значение переменной";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_variable_value
            // 
            this.textBox_variable_value.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_variable_value.Location = new System.Drawing.Point(180, 191);
            this.textBox_variable_value.Name = "textBox_variable_value";
            this.textBox_variable_value.Size = new System.Drawing.Size(47, 26);
            this.textBox_variable_value.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(58, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Выражение";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_expression
            // 
            this.textBox_expression.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_expression.Location = new System.Drawing.Point(12, 37);
            this.textBox_expression.Multiline = true;
            this.textBox_expression.Name = "textBox_expression";
            this.textBox_expression.Size = new System.Drawing.Size(215, 110);
            this.textBox_expression.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(542, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Условие";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_condition
            // 
            this.textBox_condition.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_condition.Location = new System.Drawing.Point(477, 37);
            this.textBox_condition.Multiline = true;
            this.textBox_condition.Name = "textBox_condition";
            this.textBox_condition.Size = new System.Drawing.Size(215, 108);
            this.textBox_condition.TabIndex = 7;
            // 
            // button_condition_add
            // 
            this.button_condition_add.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_condition_add.Location = new System.Drawing.Point(252, 10);
            this.button_condition_add.Name = "button_condition_add";
            this.button_condition_add.Size = new System.Drawing.Size(75, 23);
            this.button_condition_add.TabIndex = 8;
            this.button_condition_add.Text = "Добавить";
            this.button_condition_add.UseVisualStyleBackColor = true;
            this.button_condition_add.Click += new System.EventHandler(this.button_condition_add_Click);
            // 
            // button_conditions_clear
            // 
            this.button_conditions_clear.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_conditions_clear.Location = new System.Drawing.Point(396, 10);
            this.button_conditions_clear.Name = "button_conditions_clear";
            this.button_conditions_clear.Size = new System.Drawing.Size(75, 23);
            this.button_conditions_clear.TabIndex = 9;
            this.button_conditions_clear.Text = "Очистить";
            this.button_conditions_clear.UseVisualStyleBackColor = true;
            this.button_conditions_clear.Click += new System.EventHandler(this.button_conditions_clear_Click);
            // 
            // label_conditions
            // 
            this.label_conditions.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_conditions.Location = new System.Drawing.Point(233, 37);
            this.label_conditions.Name = "label_conditions";
            this.label_conditions.Size = new System.Drawing.Size(238, 312);
            this.label_conditions.TabIndex = 10;
            this.label_conditions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_answer
            // 
            this.label_answer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label_answer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_answer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_answer.Location = new System.Drawing.Point(252, 391);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(219, 50);
            this.label_answer.TabIndex = 11;
            this.label_answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_calculate
            // 
            this.button_calculate.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_calculate.Location = new System.Drawing.Point(322, 365);
            this.button_calculate.Name = "button_calculate";
            this.button_calculate.Size = new System.Drawing.Size(75, 23);
            this.button_calculate.TabIndex = 12;
            this.button_calculate.Text = "Посчитать";
            this.button_calculate.UseVisualStyleBackColor = true;
            this.button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.button_calculate);
            this.Controls.Add(this.label_answer);
            this.Controls.Add(this.label_conditions);
            this.Controls.Add(this.button_conditions_clear);
            this.Controls.Add(this.button_condition_add);
            this.Controls.Add(this.textBox_condition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_expression);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_variable_value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_variable_name);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_variable_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_variable_value;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_expression;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_condition;
        private System.Windows.Forms.Button button_condition_add;
        private System.Windows.Forms.Button button_conditions_clear;
        private System.Windows.Forms.Label label_conditions;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.Button button_calculate;
    }
}

