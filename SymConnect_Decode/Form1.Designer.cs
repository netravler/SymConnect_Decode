namespace SymConnect_Decode
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excludeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iQInquiryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rSIQResponseInquiryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aAssignedNumberOfTheUnitTheClientIsUsingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bTypeOfDeviceTheClientIsUsingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cStreetAddressOfTheClientNoMeaningForProcessingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dAccountNumberOfrIQFMRGOrTRTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eUserCodeFromThePreferenceRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fFMTransactionToCreateAnAccountContainsPasswordForAudioOrHBPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gFileThatTheRequestIsTargetingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hHierarchicRecordPathIerecordsubrecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jFileMaintenanceDependsOnTypeOfTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kResponseStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lMiscellaneousDataFlagIsOnlyUsedWithFMfileMaintenanceInquiryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nSymConnectUserBetween032767DefaultIs0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thisIsABetaUtilityPaulX43101ForAssistanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.editRTB = new System.Windows.Forms.RichTextBox();
            this.saveBase = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(562, 22);
            this.textBox1.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(27, 58);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.richTextBox1.Size = new System.Drawing.Size(850, 498);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.WordWrap = false;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseDown);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(993, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(23, 14);
            this.button2.TabIndex = 3;
            this.button2.Text = "Export .CSV";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "IQ",
            "RSIQ",
            "FM",
            "RSAD",
            "RSFM",
            "~A",
            "~B",
            "~C",
            "~D",
            "~E",
            "~F",
            "~G",
            "~H",
            "~J",
            "~K",
            "~L",
            "password",
            "~N"});
            this.checkedListBox1.Location = new System.Drawing.Point(891, 59);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(316, 497);
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkedListBox1_MouseDown_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.processesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1219, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.saveCSVToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.openToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(141, 24);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveCSVToolStripMenuItem
            // 
            this.saveCSVToolStripMenuItem.Name = "saveCSVToolStripMenuItem";
            this.saveCSVToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.saveCSVToolStripMenuItem.Text = "Save_CSV";
            this.saveCSVToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // processesToolStripMenuItem
            // 
            this.processesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excludeToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.processesToolStripMenuItem.Name = "processesToolStripMenuItem";
            this.processesToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.processesToolStripMenuItem.Text = "Processes";
            // 
            // excludeToolStripMenuItem
            // 
            this.excludeToolStripMenuItem.Name = "excludeToolStripMenuItem";
            this.excludeToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.excludeToolStripMenuItem.Text = "Exclude";
            this.excludeToolStripMenuItem.Click += new System.EventHandler(this.excludeToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codesToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // codesToolStripMenuItem
            // 
            this.codesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iQInquiryToolStripMenuItem,
            this.rSIQResponseInquiryToolStripMenuItem,
            this.aAssignedNumberOfTheUnitTheClientIsUsingToolStripMenuItem,
            this.bTypeOfDeviceTheClientIsUsingToolStripMenuItem,
            this.cStreetAddressOfTheClientNoMeaningForProcessingToolStripMenuItem,
            this.dAccountNumberOfrIQFMRGOrTRTransactionsToolStripMenuItem,
            this.eUserCodeFromThePreferenceRecordToolStripMenuItem,
            this.fFMTransactionToCreateAnAccountContainsPasswordForAudioOrHBPasswordToolStripMenuItem,
            this.gFileThatTheRequestIsTargetingToolStripMenuItem,
            this.hHierarchicRecordPathIerecordsubrecordToolStripMenuItem,
            this.jFileMaintenanceDependsOnTypeOfTransactionToolStripMenuItem,
            this.kResponseStatusToolStripMenuItem,
            this.lMiscellaneousDataFlagIsOnlyUsedWithFMfileMaintenanceInquiryToolStripMenuItem,
            this.nSymConnectUserBetween032767DefaultIs0ToolStripMenuItem});
            this.codesToolStripMenuItem.Name = "codesToolStripMenuItem";
            this.codesToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.codesToolStripMenuItem.Text = "Codes";
            // 
            // iQInquiryToolStripMenuItem
            // 
            this.iQInquiryToolStripMenuItem.Name = "iQInquiryToolStripMenuItem";
            this.iQInquiryToolStripMenuItem.Size = new System.Drawing.Size(639, 24);
            this.iQInquiryToolStripMenuItem.Text = "IQ - Inquiry";
            // 
            // rSIQResponseInquiryToolStripMenuItem
            // 
            this.rSIQResponseInquiryToolStripMenuItem.Name = "rSIQResponseInquiryToolStripMenuItem";
            this.rSIQResponseInquiryToolStripMenuItem.Size = new System.Drawing.Size(639, 24);
            this.rSIQResponseInquiryToolStripMenuItem.Text = "RSIQ - Response inquiry";
            // 
            // aAssignedNumberOfTheUnitTheClientIsUsingToolStripMenuItem
            // 
            this.aAssignedNumberOfTheUnitTheClientIsUsingToolStripMenuItem.Name = "aAssignedNumberOfTheUnitTheClientIsUsingToolStripMenuItem";
            this.aAssignedNumberOfTheUnitTheClientIsUsingToolStripMenuItem.Size = new System.Drawing.Size(639, 24);
            this.aAssignedNumberOfTheUnitTheClientIsUsingToolStripMenuItem.Text = "A - Number of the unit the client is using";
            // 
            // bTypeOfDeviceTheClientIsUsingToolStripMenuItem
            // 
            this.bTypeOfDeviceTheClientIsUsingToolStripMenuItem.Name = "bTypeOfDeviceTheClientIsUsingToolStripMenuItem";
            this.bTypeOfDeviceTheClientIsUsingToolStripMenuItem.Size = new System.Drawing.Size(639, 24);
            this.bTypeOfDeviceTheClientIsUsingToolStripMenuItem.Text = "B - Type of device the client is using";
            // 
            // cStreetAddressOfTheClientNoMeaningForProcessingToolStripMenuItem
            // 
            this.cStreetAddressOfTheClientNoMeaningForProcessingToolStripMenuItem.Name = "cStreetAddressOfTheClientNoMeaningForProcessingToolStripMenuItem";
            this.cStreetAddressOfTheClientNoMeaningForProcessingToolStripMenuItem.Size = new System.Drawing.Size(639, 24);
            this.cStreetAddressOfTheClientNoMeaningForProcessingToolStripMenuItem.Text = "C - Street address of the client.  No meaning for processing";
            // 
            // dAccountNumberOfrIQFMRGOrTRTransactionsToolStripMenuItem
            // 
            this.dAccountNumberOfrIQFMRGOrTRTransactionsToolStripMenuItem.Name = "dAccountNumberOfrIQFMRGOrTRTransactionsToolStripMenuItem";
            this.dAccountNumberOfrIQFMRGOrTRTransactionsToolStripMenuItem.Size = new System.Drawing.Size(639, 24);
            this.dAccountNumberOfrIQFMRGOrTRTransactionsToolStripMenuItem.Text = "D - Account Number ofr IQ, FM, RG, or TR transactions";
            // 
            // eUserCodeFromThePreferenceRecordToolStripMenuItem
            // 
            this.eUserCodeFromThePreferenceRecordToolStripMenuItem.Name = "eUserCodeFromThePreferenceRecordToolStripMenuItem";
            this.eUserCodeFromThePreferenceRecordToolStripMenuItem.Size = new System.Drawing.Size(639, 24);
            this.eUserCodeFromThePreferenceRecordToolStripMenuItem.Text = "E - User Code from the Preference record";
            // 
            // fFMTransactionToCreateAnAccountContainsPasswordForAudioOrHBPasswordToolStripMenuItem
            // 
            this.fFMTransactionToCreateAnAccountContainsPasswordForAudioOrHBPasswordToolStripMenuItem.Name = "fFMTransactionToCreateAnAccountContainsPasswordForAudioOrHBPasswordToolStripMenuI" +
    "tem";
            this.fFMTransactionToCreateAnAccountContainsPasswordForAudioOrHBPasswordToolStripMenuItem.Size = new System.Drawing.Size(639, 24);
            this.fFMTransactionToCreateAnAccountContainsPasswordForAudioOrHBPasswordToolStripMenuItem.Text = "F - FM transaction to create an Account contains password for Audio or HB passwor" +
    "d";
            // 
            // gFileThatTheRequestIsTargetingToolStripMenuItem
            // 
            this.gFileThatTheRequestIsTargetingToolStripMenuItem.Name = "gFileThatTheRequestIsTargetingToolStripMenuItem";
            this.gFileThatTheRequestIsTargetingToolStripMenuItem.Size = new System.Drawing.Size(639, 24);
            this.gFileThatTheRequestIsTargetingToolStripMenuItem.Text = "G - File that the request is targeting";
            // 
            // hHierarchicRecordPathIerecordsubrecordToolStripMenuItem
            // 
            this.hHierarchicRecordPathIerecordsubrecordToolStripMenuItem.Name = "hHierarchicRecordPathIerecordsubrecordToolStripMenuItem";
            this.hHierarchicRecordPathIerecordsubrecordToolStripMenuItem.Size = new System.Drawing.Size(639, 24);
            this.hHierarchicRecordPathIerecordsubrecordToolStripMenuItem.Text = "H - Hierarchic record path: i.e. <record>{[:<subrecord>]}";
            // 
            // jFileMaintenanceDependsOnTypeOfTransactionToolStripMenuItem
            // 
            this.jFileMaintenanceDependsOnTypeOfTransactionToolStripMenuItem.Name = "jFileMaintenanceDependsOnTypeOfTransactionToolStripMenuItem";
            this.jFileMaintenanceDependsOnTypeOfTransactionToolStripMenuItem.Size = new System.Drawing.Size(639, 24);
            this.jFileMaintenanceDependsOnTypeOfTransactionToolStripMenuItem.Text = "J - File maintenance depends on type of transaction";
            // 
            // kResponseStatusToolStripMenuItem
            // 
            this.kResponseStatusToolStripMenuItem.Name = "kResponseStatusToolStripMenuItem";
            this.kResponseStatusToolStripMenuItem.Size = new System.Drawing.Size(639, 24);
            this.kResponseStatusToolStripMenuItem.Text = "K - Response status";
            // 
            // lMiscellaneousDataFlagIsOnlyUsedWithFMfileMaintenanceInquiryToolStripMenuItem
            // 
            this.lMiscellaneousDataFlagIsOnlyUsedWithFMfileMaintenanceInquiryToolStripMenuItem.Name = "lMiscellaneousDataFlagIsOnlyUsedWithFMfileMaintenanceInquiryToolStripMenuItem";
            this.lMiscellaneousDataFlagIsOnlyUsedWithFMfileMaintenanceInquiryToolStripMenuItem.Size = new System.Drawing.Size(639, 24);
            this.lMiscellaneousDataFlagIsOnlyUsedWithFMfileMaintenanceInquiryToolStripMenuItem.Text = "L - Miscellaneous data flag.  Is only used with FM (file maintenance) inquiry";
            // 
            // nSymConnectUserBetween032767DefaultIs0ToolStripMenuItem
            // 
            this.nSymConnectUserBetween032767DefaultIs0ToolStripMenuItem.Name = "nSymConnectUserBetween032767DefaultIs0ToolStripMenuItem";
            this.nSymConnectUserBetween032767DefaultIs0ToolStripMenuItem.Size = new System.Drawing.Size(639, 24);
            this.nSymConnectUserBetween032767DefaultIs0ToolStripMenuItem.Text = "N - SymConnect User between 0 - 32767 default is 0";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thisIsABetaUtilityPaulX43101ForAssistanceToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(119, 24);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // thisIsABetaUtilityPaulX43101ForAssistanceToolStripMenuItem
            // 
            this.thisIsABetaUtilityPaulX43101ForAssistanceToolStripMenuItem.Name = "thisIsABetaUtilityPaulX43101ForAssistanceToolStripMenuItem";
            this.thisIsABetaUtilityPaulX43101ForAssistanceToolStripMenuItem.Size = new System.Drawing.Size(451, 24);
            this.thisIsABetaUtilityPaulX43101ForAssistanceToolStripMenuItem.Text = "If you need assistance send me an email via CodeProject";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(960, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 16);
            this.button1.TabIndex = 0;
            this.button1.Text = "Find File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // editRTB
            // 
            this.editRTB.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRTB.Location = new System.Drawing.Point(960, 523);
            this.editRTB.Name = "editRTB";
            this.editRTB.Size = new System.Drawing.Size(28, 23);
            this.editRTB.TabIndex = 6;
            this.editRTB.Text = "";
            this.editRTB.Visible = false;
            // 
            // saveBase
            // 
            this.saveBase.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBase.Location = new System.Drawing.Point(960, 473);
            this.saveBase.Name = "saveBase";
            this.saveBase.Size = new System.Drawing.Size(28, 23);
            this.saveBase.TabIndex = 7;
            this.saveBase.Text = "";
            this.saveBase.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(668, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(887, 30);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Lines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(791, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Characters";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 584);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.saveBase);
            this.Controls.Add(this.editRTB);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SymConnect Decode";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveCSVToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox editRTB;
        private System.Windows.Forms.ToolStripMenuItem processesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excludeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iQInquiryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rSIQResponseInquiryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aAssignedNumberOfTheUnitTheClientIsUsingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bTypeOfDeviceTheClientIsUsingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cStreetAddressOfTheClientNoMeaningForProcessingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dAccountNumberOfrIQFMRGOrTRTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eUserCodeFromThePreferenceRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fFMTransactionToCreateAnAccountContainsPasswordForAudioOrHBPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gFileThatTheRequestIsTargetingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hHierarchicRecordPathIerecordsubrecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jFileMaintenanceDependsOnTypeOfTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kResponseStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lMiscellaneousDataFlagIsOnlyUsedWithFMfileMaintenanceInquiryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nSymConnectUserBetween032767DefaultIs0ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox saveBase;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thisIsABetaUtilityPaulX43101ForAssistanceToolStripMenuItem;
    }
}

