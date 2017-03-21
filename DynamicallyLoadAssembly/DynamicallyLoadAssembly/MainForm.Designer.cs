namespace DynamicLoadAssembly
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btLoad = new System.Windows.Forms.Button();
            this.btTest = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btUnloadDLL = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btUnload = new System.Windows.Forms.Button();
            this.btException = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btTestExecute = new System.Windows.Forms.Button();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.btRefresh = new System.Windows.Forms.Button();
            this.btLoadAssembly = new System.Windows.Forms.Button();
            this.cbAssemblies = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(6, 6);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 23);
            this.btLoad.TabIndex = 0;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btTest
            // 
            this.btTest.Location = new System.Drawing.Point(168, 6);
            this.btTest.Name = "btTest";
            this.btTest.Size = new System.Drawing.Size(75, 23);
            this.btTest.TabIndex = 1;
            this.btTest.Text = "Test";
            this.btTest.UseVisualStyleBackColor = true;
            this.btTest.Click += new System.EventHandler(this.btTest_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(326, 223);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btUnloadDLL);
            this.tabPage1.Controls.Add(this.btLoad);
            this.tabPage1.Controls.Add(this.btTest);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(318, 197);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Simple Test";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btUnloadDLL
            // 
            this.btUnloadDLL.Location = new System.Drawing.Point(87, 6);
            this.btUnloadDLL.Name = "btUnloadDLL";
            this.btUnloadDLL.Size = new System.Drawing.Size(75, 23);
            this.btUnloadDLL.TabIndex = 2;
            this.btUnloadDLL.Text = "Unload";
            this.btUnloadDLL.UseVisualStyleBackColor = true;
            this.btUnloadDLL.Click += new System.EventHandler(this.btUnloadDLL_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btUnload);
            this.tabPage2.Controls.Add(this.btException);
            this.tabPage2.Controls.Add(this.txtResult);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btTestExecute);
            this.tabPage2.Controls.Add(this.txtValue2);
            this.tabPage2.Controls.Add(this.txtValue1);
            this.tabPage2.Controls.Add(this.btRefresh);
            this.tabPage2.Controls.Add(this.btLoadAssembly);
            this.tabPage2.Controls.Add(this.cbAssemblies);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(318, 197);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advance";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btUnload
            // 
            this.btUnload.Location = new System.Drawing.Point(221, 47);
            this.btUnload.Name = "btUnload";
            this.btUnload.Size = new System.Drawing.Size(75, 23);
            this.btUnload.TabIndex = 11;
            this.btUnload.Text = "Unload";
            this.btUnload.UseVisualStyleBackColor = true;
            this.btUnload.Click += new System.EventHandler(this.btUnload_Click);
            // 
            // btException
            // 
            this.btException.Location = new System.Drawing.Point(179, 129);
            this.btException.Name = "btException";
            this.btException.Size = new System.Drawing.Size(101, 46);
            this.btException.TabIndex = 10;
            this.btException.Text = "Exception Test";
            this.btException.UseVisualStyleBackColor = true;
            this.btException.Click += new System.EventHandler(this.btException_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(73, 129);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Value2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Value 1";
            // 
            // btTestExecute
            // 
            this.btTestExecute.Location = new System.Drawing.Point(179, 77);
            this.btTestExecute.Name = "btTestExecute";
            this.btTestExecute.Size = new System.Drawing.Size(101, 46);
            this.btTestExecute.TabIndex = 5;
            this.btTestExecute.Text = "Test";
            this.btTestExecute.UseVisualStyleBackColor = true;
            this.btTestExecute.Click += new System.EventHandler(this.btTestExecute_Click);
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(73, 103);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(100, 20);
            this.txtValue2.TabIndex = 4;
            this.txtValue2.Text = "22.45";
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(73, 77);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(100, 20);
            this.txtValue1.TabIndex = 3;
            this.txtValue1.Text = "20";
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(13, 18);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(75, 23);
            this.btRefresh.TabIndex = 2;
            this.btRefresh.Text = "Refresh";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btLoadAssembly
            // 
            this.btLoadAssembly.Location = new System.Drawing.Point(221, 18);
            this.btLoadAssembly.Name = "btLoadAssembly";
            this.btLoadAssembly.Size = new System.Drawing.Size(75, 23);
            this.btLoadAssembly.TabIndex = 1;
            this.btLoadAssembly.Text = "Load";
            this.btLoadAssembly.UseVisualStyleBackColor = true;
            this.btLoadAssembly.Click += new System.EventHandler(this.btLoadAssembly_Click);
            // 
            // cbAssemblies
            // 
            this.cbAssemblies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAssemblies.FormattingEnabled = true;
            this.cbAssemblies.Location = new System.Drawing.Point(94, 18);
            this.cbAssemblies.Name = "cbAssemblies";
            this.cbAssemblies.Size = new System.Drawing.Size(121, 21);
            this.cbAssemblies.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 223);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(342, 262);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btTest;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Button btLoadAssembly;
        private System.Windows.Forms.ComboBox cbAssemblies;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTestExecute;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btException;
        private System.Windows.Forms.Button btUnload;
        private System.Windows.Forms.Button btUnloadDLL;

    }
}

