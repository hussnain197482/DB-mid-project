﻿namespace WinFormsApp1
{
    partial class ManageInventoryAS
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
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            button1 = new Button();
            button5 = new Button();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            COURSE = new DataGridViewTextBoxColumn();
            RESEARCH_SUPERVISION = new DataGridViewTextBoxColumn();
            ADMIN_DUTIES = new DataGridViewTextBoxColumn();
            ADD = new DataGridViewButtonColumn();
            EDIT = new DataGridViewButtonColumn();
            DELETE = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { COURSE, RESEARCH_SUPERVISION, ADMIN_DUTIES, ADD, EDIT, DELETE });
            dataGridView1.Location = new Point(233, 126);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(719, 256);
            dataGridView1.TabIndex = 18;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(160, 463);
            panel2.TabIndex = 17;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = SystemColors.HotTrack;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(-2, 235);
            button1.Name = "button1";
            button1.Size = new Size(160, 35);
            button1.TabIndex = 3;
            button1.Text = "Manage Inventory";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.BackColor = Color.Goldenrod;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(1, 276);
            button5.Name = "button5";
            button5.Size = new Size(158, 35);
            button5.TabIndex = 3;
            button5.Text = "Settings";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.Goldenrod;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(0, 116);
            button2.Name = "button2";
            button2.Size = new Size(157, 35);
            button2.TabIndex = 3;
            button2.Text = "Dashboard";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.Goldenrod;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(-3, 153);
            button4.Name = "button4";
            button4.Size = new Size(158, 35);
            button4.TabIndex = 3;
            button4.Text = " Manage Faculty";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.Goldenrod;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(1, 194);
            button3.Name = "button3";
            button3.Size = new Size(158, 35);
            button3.TabIndex = 3;
            button3.Text = "Process Requests";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.download_removebg_preview__3_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(85, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 56);
            panel1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(789, 20);
            label2.Name = "label2";
            label2.Size = new Size(163, 21);
            label2.TabIndex = 3;
            label2.Text = "Administrative Staff";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.user_6380868_1280_removebg_preview;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources.user_6380868_1280_removebg_preview;
            pictureBox2.Location = new Point(933, -7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 72);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(342, 9);
            label1.Name = "label1";
            label1.Size = new Size(341, 34);
            label1.TabIndex = 1;
            label1.Text = "FACULTY MANAGEMENT SYSTEM";
            // 
            // COURSE
            // 
            COURSE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            COURSE.HeaderText = "Resource Type";
            COURSE.Name = "COURSE";
            COURSE.Resizable = DataGridViewTriState.True;
            // 
            // RESEARCH_SUPERVISION
            // 
            RESEARCH_SUPERVISION.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RESEARCH_SUPERVISION.HeaderText = "Quantity Available";
            RESEARCH_SUPERVISION.Name = "RESEARCH_SUPERVISION";
            // 
            // ADMIN_DUTIES
            // 
            ADMIN_DUTIES.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ADMIN_DUTIES.HeaderText = "Last Updated";
            ADMIN_DUTIES.Name = "ADMIN_DUTIES";
            // 
            // ADD
            // 
            ADD.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ADD.HeaderText = "ADD";
            ADD.Name = "ADD";
            ADD.Resizable = DataGridViewTriState.True;
            ADD.SortMode = DataGridViewColumnSortMode.Automatic;
            ADD.UseColumnTextForButtonValue = true;
            // 
            // EDIT
            // 
            EDIT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            EDIT.HeaderText = "EDIT";
            EDIT.Name = "EDIT";
            EDIT.Resizable = DataGridViewTriState.True;
            EDIT.SortMode = DataGridViewColumnSortMode.Automatic;
            EDIT.UseColumnTextForButtonValue = true;
            // 
            // DELETE
            // 
            DELETE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DELETE.HeaderText = "DELETE";
            DELETE.Name = "DELETE";
            DELETE.Resizable = DataGridViewTriState.True;
            DELETE.SortMode = DataGridViewColumnSortMode.Automatic;
            DELETE.UseColumnTextForButtonValue = true;
            // 
            // ManageInventoryAS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 461);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ManageInventoryAS";
            Text = "ManageInventoryAS";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel2;
        private Button button1;
        private Button button5;
        private Button button2;
        private Button button4;
        private Button button3;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label1;
        private DataGridViewTextBoxColumn COURSE;
        private DataGridViewTextBoxColumn RESEARCH_SUPERVISION;
        private DataGridViewTextBoxColumn ADMIN_DUTIES;
        private DataGridViewButtonColumn ADD;
        private DataGridViewButtonColumn EDIT;
        private DataGridViewButtonColumn DELETE;
    }
}