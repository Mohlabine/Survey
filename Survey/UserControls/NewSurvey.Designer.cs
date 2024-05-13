using System.Drawing;
using System.Windows.Forms;

namespace Survey.UserControls
{
    partial class NewSurvey
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputName = new System.Windows.Forms.TextBox();
            this.InputEmail = new System.Windows.Forms.TextBox();
            this.InputContactNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CheckPizza = new System.Windows.Forms.CheckBox();
            this.CheckPasta = new System.Windows.Forms.CheckBox();
            this.CheckPap = new System.Windows.Forms.CheckBox();
            this.CheckOther = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.radioMoviesStronglyDisagree = new System.Windows.Forms.RadioButton();
            this.radioMoviesNormal = new System.Windows.Forms.RadioButton();
            this.radioMoviesDisagree = new System.Windows.Forms.RadioButton();
            this.radioMoviesAgree = new System.Windows.Forms.RadioButton();
            this.radioMoviesStonglyAgree = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.radioEetOutStronglyDisagree = new System.Windows.Forms.RadioButton();
            this.radioEetOutNormal = new System.Windows.Forms.RadioButton();
            this.radioEetOutDisagree = new System.Windows.Forms.RadioButton();
            this.radioEetOutAgree = new System.Windows.Forms.RadioButton();
            this.radioEetOutStronglyAgree = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.radioListenRadioStronglyDisagree = new System.Windows.Forms.RadioButton();
            this.radioListenRadioNormal = new System.Windows.Forms.RadioButton();
            this.radioListenRadioDisagree = new System.Windows.Forms.RadioButton();
            this.radioListenRadioAgree = new System.Windows.Forms.RadioButton();
            this.radioListenRadioStronglyAgree = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.radioWatchTvStronglyDisagree = new System.Windows.Forms.RadioButton();
            this.radioWatchTvNormal = new System.Windows.Forms.RadioButton();
            this.radioWatchTvDisagree = new System.Windows.Forms.RadioButton();
            this.radioWatchTvAgree = new System.Windows.Forms.RadioButton();
            this.radioWatchTvStronglyAgree = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.InputDOB = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputName
            // 
            this.InputName.Location = new System.Drawing.Point(379, 72);
            this.InputName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(535, 22);
            this.InputName.TabIndex = 0;
            // 
            // InputEmail
            // 
            this.InputEmail.Location = new System.Drawing.Point(379, 112);
            this.InputEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputEmail.Name = "InputEmail";
            this.InputEmail.Size = new System.Drawing.Size(535, 22);
            this.InputEmail.TabIndex = 1;
            // 
            // InputContactNumber
            // 
            this.InputContactNumber.Location = new System.Drawing.Point(379, 192);
            this.InputContactNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputContactNumber.Name = "InputContactNumber";
            this.InputContactNumber.Size = new System.Drawing.Size(535, 22);
            this.InputContactNumber.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Personal Details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Full Names";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contact Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(138, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "What is your favourit food?";
            // 
            // CheckPizza
            // 
            this.CheckPizza.AutoSize = true;
            this.CheckPizza.Location = new System.Drawing.Point(380, 248);
            this.CheckPizza.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckPizza.Name = "CheckPizza";
            this.CheckPizza.Size = new System.Drawing.Size(61, 20);
            this.CheckPizza.TabIndex = 13;
            this.CheckPizza.Text = "Pizza";
            this.CheckPizza.UseVisualStyleBackColor = true;
            this.CheckPizza.CheckedChanged += new System.EventHandler(this.CheckPizza_CheckedChanged);
            // 
            // CheckPasta
            // 
            this.CheckPasta.AutoSize = true;
            this.CheckPasta.Location = new System.Drawing.Point(498, 248);
            this.CheckPasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckPasta.Name = "CheckPasta";
            this.CheckPasta.Size = new System.Drawing.Size(64, 20);
            this.CheckPasta.TabIndex = 14;
            this.CheckPasta.Text = "Pasta";
            this.CheckPasta.UseVisualStyleBackColor = true;
            this.CheckPasta.CheckedChanged += new System.EventHandler(this.CheckPasta_CheckedChanged);
            // 
            // CheckPap
            // 
            this.CheckPap.AutoSize = true;
            this.CheckPap.Location = new System.Drawing.Point(585, 248);
            this.CheckPap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckPap.Name = "CheckPap";
            this.CheckPap.Size = new System.Drawing.Size(115, 20);
            this.CheckPap.TabIndex = 15;
            this.CheckPap.Text = "Pap and Wors";
            this.CheckPap.UseVisualStyleBackColor = true;
            this.CheckPap.CheckedChanged += new System.EventHandler(this.CheckPap_CheckedChanged);
            // 
            // CheckOther
            // 
            this.CheckOther.AutoSize = true;
            this.CheckOther.Location = new System.Drawing.Point(712, 248);
            this.CheckOther.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckOther.Name = "CheckOther";
            this.CheckOther.Size = new System.Drawing.Size(61, 20);
            this.CheckOther.TabIndex = 16;
            this.CheckOther.Text = "Other";
            this.CheckOther.UseVisualStyleBackColor = true;
            this.CheckOther.CheckedChanged += new System.EventHandler(this.CheckOther_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(674, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Please rate your level of agreement on a scale from 1 to to 5, with 1 being `stro" +
    "ngly  agree` and 5 is strongly agree";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.radioMoviesStronglyDisagree);
            this.panel1.Controls.Add(this.radioMoviesNormal);
            this.panel1.Controls.Add(this.radioMoviesDisagree);
            this.panel1.Controls.Add(this.radioMoviesAgree);
            this.panel1.Controls.Add(this.radioMoviesStonglyAgree);
            this.panel1.Location = new System.Drawing.Point(138, 346);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(931, 26);
            this.panel1.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 5);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "I like to watch movies";
            // 
            // radioMoviesStronglyDisagree
            // 
            this.radioMoviesStronglyDisagree.AutoSize = true;
            this.radioMoviesStronglyDisagree.Location = new System.Drawing.Point(702, 6);
            this.radioMoviesStronglyDisagree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioMoviesStronglyDisagree.Name = "radioMoviesStronglyDisagree";
            this.radioMoviesStronglyDisagree.Size = new System.Drawing.Size(17, 16);
            this.radioMoviesStronglyDisagree.TabIndex = 27;
            this.radioMoviesStronglyDisagree.TabStop = true;
            this.radioMoviesStronglyDisagree.UseVisualStyleBackColor = true;
            // 
            // radioMoviesNormal
            // 
            this.radioMoviesNormal.AutoSize = true;
            this.radioMoviesNormal.Location = new System.Drawing.Point(456, 6);
            this.radioMoviesNormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioMoviesNormal.Name = "radioMoviesNormal";
            this.radioMoviesNormal.Size = new System.Drawing.Size(17, 16);
            this.radioMoviesNormal.TabIndex = 26;
            this.radioMoviesNormal.TabStop = true;
            this.radioMoviesNormal.UseVisualStyleBackColor = true;
            // 
            // radioMoviesDisagree
            // 
            this.radioMoviesDisagree.AutoSize = true;
            this.radioMoviesDisagree.Location = new System.Drawing.Point(579, 6);
            this.radioMoviesDisagree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioMoviesDisagree.Name = "radioMoviesDisagree";
            this.radioMoviesDisagree.Size = new System.Drawing.Size(17, 16);
            this.radioMoviesDisagree.TabIndex = 25;
            this.radioMoviesDisagree.TabStop = true;
            this.radioMoviesDisagree.UseVisualStyleBackColor = true;
            // 
            // radioMoviesAgree
            // 
            this.radioMoviesAgree.AutoSize = true;
            this.radioMoviesAgree.Location = new System.Drawing.Point(338, 6);
            this.radioMoviesAgree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioMoviesAgree.Name = "radioMoviesAgree";
            this.radioMoviesAgree.Size = new System.Drawing.Size(17, 16);
            this.radioMoviesAgree.TabIndex = 24;
            this.radioMoviesAgree.TabStop = true;
            this.radioMoviesAgree.UseVisualStyleBackColor = true;
            // 
            // radioMoviesStonglyAgree
            // 
            this.radioMoviesStonglyAgree.AutoSize = true;
            this.radioMoviesStonglyAgree.Location = new System.Drawing.Point(212, 6);
            this.radioMoviesStonglyAgree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioMoviesStonglyAgree.Name = "radioMoviesStonglyAgree";
            this.radioMoviesStonglyAgree.Size = new System.Drawing.Size(17, 16);
            this.radioMoviesStonglyAgree.TabIndex = 23;
            this.radioMoviesStonglyAgree.TabStop = true;
            this.radioMoviesStonglyAgree.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.radioEetOutStronglyDisagree);
            this.panel2.Controls.Add(this.radioEetOutNormal);
            this.panel2.Controls.Add(this.radioEetOutDisagree);
            this.panel2.Controls.Add(this.radioEetOutAgree);
            this.panel2.Controls.Add(this.radioEetOutStronglyAgree);
            this.panel2.Location = new System.Drawing.Point(138, 408);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 26);
            this.panel2.TabIndex = 24;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 16);
            this.label15.TabIndex = 29;
            this.label15.Text = "I like to eat out";
            // 
            // radioEetOutStronglyDisagree
            // 
            this.radioEetOutStronglyDisagree.AutoSize = true;
            this.radioEetOutStronglyDisagree.Location = new System.Drawing.Point(702, 6);
            this.radioEetOutStronglyDisagree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioEetOutStronglyDisagree.Name = "radioEetOutStronglyDisagree";
            this.radioEetOutStronglyDisagree.Size = new System.Drawing.Size(17, 16);
            this.radioEetOutStronglyDisagree.TabIndex = 27;
            this.radioEetOutStronglyDisagree.TabStop = true;
            this.radioEetOutStronglyDisagree.UseVisualStyleBackColor = true;
            // 
            // radioEetOutNormal
            // 
            this.radioEetOutNormal.AutoSize = true;
            this.radioEetOutNormal.Location = new System.Drawing.Point(456, 6);
            this.radioEetOutNormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioEetOutNormal.Name = "radioEetOutNormal";
            this.radioEetOutNormal.Size = new System.Drawing.Size(17, 16);
            this.radioEetOutNormal.TabIndex = 26;
            this.radioEetOutNormal.TabStop = true;
            this.radioEetOutNormal.UseVisualStyleBackColor = true;
            // 
            // radioEetOutDisagree
            // 
            this.radioEetOutDisagree.AutoSize = true;
            this.radioEetOutDisagree.Location = new System.Drawing.Point(579, 6);
            this.radioEetOutDisagree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioEetOutDisagree.Name = "radioEetOutDisagree";
            this.radioEetOutDisagree.Size = new System.Drawing.Size(17, 16);
            this.radioEetOutDisagree.TabIndex = 25;
            this.radioEetOutDisagree.TabStop = true;
            this.radioEetOutDisagree.UseVisualStyleBackColor = true;
            // 
            // radioEetOutAgree
            // 
            this.radioEetOutAgree.AutoSize = true;
            this.radioEetOutAgree.Location = new System.Drawing.Point(338, 6);
            this.radioEetOutAgree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioEetOutAgree.Name = "radioEetOutAgree";
            this.radioEetOutAgree.Size = new System.Drawing.Size(17, 16);
            this.radioEetOutAgree.TabIndex = 24;
            this.radioEetOutAgree.TabStop = true;
            this.radioEetOutAgree.UseVisualStyleBackColor = true;
            // 
            // radioEetOutStronglyAgree
            // 
            this.radioEetOutStronglyAgree.AutoSize = true;
            this.radioEetOutStronglyAgree.Location = new System.Drawing.Point(212, 6);
            this.radioEetOutStronglyAgree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioEetOutStronglyAgree.Name = "radioEetOutStronglyAgree";
            this.radioEetOutStronglyAgree.Size = new System.Drawing.Size(17, 16);
            this.radioEetOutStronglyAgree.TabIndex = 23;
            this.radioEetOutStronglyAgree.TabStop = true;
            this.radioEetOutStronglyAgree.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.radioListenRadioStronglyDisagree);
            this.panel3.Controls.Add(this.radioListenRadioNormal);
            this.panel3.Controls.Add(this.radioListenRadioDisagree);
            this.panel3.Controls.Add(this.radioListenRadioAgree);
            this.panel3.Controls.Add(this.radioListenRadioStronglyAgree);
            this.panel3.Location = new System.Drawing.Point(139, 377);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(931, 26);
            this.panel3.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Ilike to listen to radio";
            // 
            // radioListenRadioStronglyDisagree
            // 
            this.radioListenRadioStronglyDisagree.AutoSize = true;
            this.radioListenRadioStronglyDisagree.Location = new System.Drawing.Point(702, 6);
            this.radioListenRadioStronglyDisagree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioListenRadioStronglyDisagree.Name = "radioListenRadioStronglyDisagree";
            this.radioListenRadioStronglyDisagree.Size = new System.Drawing.Size(17, 16);
            this.radioListenRadioStronglyDisagree.TabIndex = 27;
            this.radioListenRadioStronglyDisagree.TabStop = true;
            this.radioListenRadioStronglyDisagree.UseVisualStyleBackColor = true;
            // 
            // radioListenRadioNormal
            // 
            this.radioListenRadioNormal.AutoSize = true;
            this.radioListenRadioNormal.Location = new System.Drawing.Point(456, 6);
            this.radioListenRadioNormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioListenRadioNormal.Name = "radioListenRadioNormal";
            this.radioListenRadioNormal.Size = new System.Drawing.Size(17, 16);
            this.radioListenRadioNormal.TabIndex = 26;
            this.radioListenRadioNormal.TabStop = true;
            this.radioListenRadioNormal.UseVisualStyleBackColor = true;
            // 
            // radioListenRadioDisagree
            // 
            this.radioListenRadioDisagree.AutoSize = true;
            this.radioListenRadioDisagree.Location = new System.Drawing.Point(579, 6);
            this.radioListenRadioDisagree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioListenRadioDisagree.Name = "radioListenRadioDisagree";
            this.radioListenRadioDisagree.Size = new System.Drawing.Size(17, 16);
            this.radioListenRadioDisagree.TabIndex = 25;
            this.radioListenRadioDisagree.TabStop = true;
            this.radioListenRadioDisagree.UseVisualStyleBackColor = true;
            // 
            // radioListenRadioAgree
            // 
            this.radioListenRadioAgree.AutoSize = true;
            this.radioListenRadioAgree.Location = new System.Drawing.Point(338, 6);
            this.radioListenRadioAgree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioListenRadioAgree.Name = "radioListenRadioAgree";
            this.radioListenRadioAgree.Size = new System.Drawing.Size(17, 16);
            this.radioListenRadioAgree.TabIndex = 24;
            this.radioListenRadioAgree.TabStop = true;
            this.radioListenRadioAgree.UseVisualStyleBackColor = true;
            // 
            // radioListenRadioStronglyAgree
            // 
            this.radioListenRadioStronglyAgree.AutoSize = true;
            this.radioListenRadioStronglyAgree.Location = new System.Drawing.Point(212, 6);
            this.radioListenRadioStronglyAgree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioListenRadioStronglyAgree.Name = "radioListenRadioStronglyAgree";
            this.radioListenRadioStronglyAgree.Size = new System.Drawing.Size(17, 16);
            this.radioListenRadioStronglyAgree.TabIndex = 23;
            this.radioListenRadioStronglyAgree.TabStop = true;
            this.radioListenRadioStronglyAgree.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.radioWatchTvStronglyDisagree);
            this.panel4.Controls.Add(this.radioWatchTvNormal);
            this.panel4.Controls.Add(this.radioWatchTvDisagree);
            this.panel4.Controls.Add(this.radioWatchTvAgree);
            this.panel4.Controls.Add(this.radioWatchTvStronglyAgree);
            this.panel4.Location = new System.Drawing.Point(139, 439);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(931, 26);
            this.panel4.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 16);
            this.label16.TabIndex = 30;
            this.label16.Text = "I like to watch tv";
            // 
            // radioWatchTvStronglyDisagree
            // 
            this.radioWatchTvStronglyDisagree.AutoSize = true;
            this.radioWatchTvStronglyDisagree.Location = new System.Drawing.Point(702, 6);
            this.radioWatchTvStronglyDisagree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioWatchTvStronglyDisagree.Name = "radioWatchTvStronglyDisagree";
            this.radioWatchTvStronglyDisagree.Size = new System.Drawing.Size(17, 16);
            this.radioWatchTvStronglyDisagree.TabIndex = 27;
            this.radioWatchTvStronglyDisagree.TabStop = true;
            this.radioWatchTvStronglyDisagree.UseVisualStyleBackColor = true;
            // 
            // radioWatchTvNormal
            // 
            this.radioWatchTvNormal.AutoSize = true;
            this.radioWatchTvNormal.Location = new System.Drawing.Point(456, 6);
            this.radioWatchTvNormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioWatchTvNormal.Name = "radioWatchTvNormal";
            this.radioWatchTvNormal.Size = new System.Drawing.Size(17, 16);
            this.radioWatchTvNormal.TabIndex = 26;
            this.radioWatchTvNormal.TabStop = true;
            this.radioWatchTvNormal.UseVisualStyleBackColor = true;
            // 
            // radioWatchTvDisagree
            // 
            this.radioWatchTvDisagree.AutoSize = true;
            this.radioWatchTvDisagree.Location = new System.Drawing.Point(579, 6);
            this.radioWatchTvDisagree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioWatchTvDisagree.Name = "radioWatchTvDisagree";
            this.radioWatchTvDisagree.Size = new System.Drawing.Size(17, 16);
            this.radioWatchTvDisagree.TabIndex = 25;
            this.radioWatchTvDisagree.TabStop = true;
            this.radioWatchTvDisagree.UseVisualStyleBackColor = true;
            // 
            // radioWatchTvAgree
            // 
            this.radioWatchTvAgree.AutoSize = true;
            this.radioWatchTvAgree.Location = new System.Drawing.Point(338, 6);
            this.radioWatchTvAgree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioWatchTvAgree.Name = "radioWatchTvAgree";
            this.radioWatchTvAgree.Size = new System.Drawing.Size(17, 16);
            this.radioWatchTvAgree.TabIndex = 24;
            this.radioWatchTvAgree.TabStop = true;
            this.radioWatchTvAgree.UseVisualStyleBackColor = true;
            // 
            // radioWatchTvStronglyAgree
            // 
            this.radioWatchTvStronglyAgree.AutoSize = true;
            this.radioWatchTvStronglyAgree.Location = new System.Drawing.Point(212, 6);
            this.radioWatchTvStronglyAgree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioWatchTvStronglyAgree.Name = "radioWatchTvStronglyAgree";
            this.radioWatchTvStronglyAgree.Size = new System.Drawing.Size(17, 16);
            this.radioWatchTvStronglyAgree.TabIndex = 23;
            this.radioWatchTvStronglyAgree.TabStop = true;
            this.radioWatchTvStronglyAgree.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(139, 314);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(931, 26);
            this.panel5.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(648, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Strongly Disagree";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(558, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Disagree";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(436, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Normal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Agree";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Strongly Agree";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(976, 483);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(94, 23);
            this.BtnSubmit.TabIndex = 29;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // InputDOB
            // 
            this.InputDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.InputDOB.Location = new System.Drawing.Point(382, 152);
            this.InputDOB.Name = "InputDOB";
            this.InputDOB.Size = new System.Drawing.Size(532, 22);
            this.InputDOB.TabIndex = 30;
            // 
            // NewSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InputDOB);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CheckOther);
            this.Controls.Add(this.CheckPap);
            this.Controls.Add(this.CheckPasta);
            this.Controls.Add(this.CheckPizza);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputContactNumber);
            this.Controls.Add(this.InputEmail);
            this.Controls.Add(this.InputName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewSurvey";
            this.Size = new System.Drawing.Size(1198, 562);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox InputName;
        private TextBox InputEmail;
        private TextBox InputContactNumber;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private CheckBox CheckPizza;
        private CheckBox CheckPasta;
        private CheckBox CheckPap;
        private CheckBox CheckOther;
        private Label label6;
        private Panel panel1;
        private RadioButton radioMoviesStronglyDisagree;
        private RadioButton radioMoviesNormal;
        private RadioButton radioMoviesDisagree;
        private RadioButton radioMoviesAgree;
        private RadioButton radioMoviesStonglyAgree;
        private Panel panel2;
        private RadioButton radioEetOutStronglyDisagree;
        private RadioButton radioEetOutNormal;
        private RadioButton radioEetOutDisagree;
        private RadioButton radioEetOutAgree;
        private RadioButton radioEetOutStronglyAgree;
        private Panel panel3;
        private RadioButton radioListenRadioStronglyDisagree;
        private RadioButton radioListenRadioNormal;
        private RadioButton radioListenRadioDisagree;
        private RadioButton radioListenRadioAgree;
        private RadioButton radioListenRadioStronglyAgree;
        private Panel panel4;
        private RadioButton radioWatchTvStronglyDisagree;
        private RadioButton radioWatchTvNormal;
        private RadioButton radioWatchTvDisagree;
        private RadioButton radioWatchTvAgree;
        private RadioButton radioWatchTvStronglyAgree;
        private Panel panel5;
        private Label label13;
        private Label label15;
        private Label label14;
        private Label label16;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button BtnSubmit;
        private DateTimePicker InputDOB;
    }
}
