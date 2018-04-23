﻿namespace SpreadsheetDocServerPivotAPI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.verticalSplitContainerControl1 = new System.Windows.Forms.SplitContainer();
            this.horisontalSplitContainerControl1 = new System.Windows.Forms.SplitContainer();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.richEditControlCS = new DevExpress.XtraRichEdit.RichEditControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.richEditControlVB = new DevExpress.XtraRichEdit.RichEditControl();
            this.codeExampleNameLbl = new DevExpress.XtraEditors.LabelControl();
            this.btnOpenExcel = new DevExpress.XtraEditors.SimpleButton();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.verticalSplitContainerControl1)).BeginInit();
            this.verticalSplitContainerControl1.Panel1.SuspendLayout();
            this.verticalSplitContainerControl1.Panel2.SuspendLayout();
            this.verticalSplitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horisontalSplitContainerControl1)).BeginInit();
            this.horisontalSplitContainerControl1.Panel1.SuspendLayout();
            this.horisontalSplitContainerControl1.Panel2.SuspendLayout();
            this.horisontalSplitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // verticalSplitContainerControl1
            // 
            this.verticalSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verticalSplitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.verticalSplitContainerControl1.Name = "verticalSplitContainerControl1";
            // 
            // verticalSplitContainerControl1.Panel1
            // 
            this.verticalSplitContainerControl1.Panel1.Controls.Add(this.horisontalSplitContainerControl1);
            // 
            // verticalSplitContainerControl1.Panel2
            // 
            this.verticalSplitContainerControl1.Panel2.Controls.Add(this.treeList1);
            this.verticalSplitContainerControl1.Size = new System.Drawing.Size(1212, 655);
            this.verticalSplitContainerControl1.SplitterDistance = 949;
            this.verticalSplitContainerControl1.TabIndex = 0;
            // 
            // horisontalSplitContainerControl1
            // 
            this.horisontalSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.horisontalSplitContainerControl1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.horisontalSplitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.horisontalSplitContainerControl1.Name = "horisontalSplitContainerControl1";
            this.horisontalSplitContainerControl1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // horisontalSplitContainerControl1.Panel1
            // 
            this.horisontalSplitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.horisontalSplitContainerControl1.Panel1.Controls.Add(this.codeExampleNameLbl);
            // 
            // horisontalSplitContainerControl1.Panel2
            // 
            this.horisontalSplitContainerControl1.Panel2.Controls.Add(this.btnOpenExcel);
            this.horisontalSplitContainerControl1.Size = new System.Drawing.Size(949, 655);
            this.horisontalSplitContainerControl1.SplitterDistance = 584;
            this.horisontalSplitContainerControl1.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.AppearancePage.PageClient.BackColor = System.Drawing.Color.Transparent;
            this.xtraTabControl1.AppearancePage.PageClient.BackColor2 = System.Drawing.Color.Transparent;
            this.xtraTabControl1.AppearancePage.PageClient.BorderColor = System.Drawing.Color.Transparent;
            this.xtraTabControl1.AppearancePage.PageClient.Options.UseBackColor = true;
            this.xtraTabControl1.AppearancePage.PageClient.Options.UseBorderColor = true;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 49);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(949, 535);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.HeaderActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.xtraTabPage1.Appearance.HeaderActive.Options.UseFont = true;
            this.xtraTabPage1.Controls.Add(this.richEditControlCS);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(947, 510);
            this.xtraTabPage1.Text = "C#";
            // 
            // richEditControlCS
            // 
            this.richEditControlCS.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
            this.richEditControlCS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControlCS.Location = new System.Drawing.Point(0, 0);
            this.richEditControlCS.Name = "richEditControlCS";
            this.richEditControlCS.Options.Comments.ShowAllAuthors = false;
            this.richEditControlCS.Options.Export.Rtf.ExportTheme = true;
            this.richEditControlCS.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.richEditControlCS.Size = new System.Drawing.Size(947, 510);
            this.richEditControlCS.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.HeaderActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.xtraTabPage2.Appearance.HeaderActive.Options.UseFont = true;
            this.xtraTabPage2.Controls.Add(this.richEditControlVB);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(947, 510);
            this.xtraTabPage2.Text = "VB";
            // 
            // richEditControlVB
            // 
            this.richEditControlVB.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
            this.richEditControlVB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControlVB.Location = new System.Drawing.Point(0, 0);
            this.richEditControlVB.Name = "richEditControlVB";
            this.richEditControlVB.Options.Comments.ShowAllAuthors = false;
            this.richEditControlVB.Options.Export.Rtf.ExportTheme = true;
            this.richEditControlVB.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.richEditControlVB.Size = new System.Drawing.Size(947, 510);
            this.richEditControlVB.TabIndex = 0;
            // 
            // codeExampleNameLbl
            // 
            this.codeExampleNameLbl.Appearance.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeExampleNameLbl.Appearance.Options.UseFont = true;
            this.codeExampleNameLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.codeExampleNameLbl.Location = new System.Drawing.Point(0, 0);
            this.codeExampleNameLbl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.codeExampleNameLbl.Name = "codeExampleNameLbl";
            this.codeExampleNameLbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.codeExampleNameLbl.Size = new System.Drawing.Size(0, 49);
            this.codeExampleNameLbl.TabIndex = 0;
            // 
            // btnOpenExcel
            // 
            this.btnOpenExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenExcel.Image")));
            this.btnOpenExcel.Location = new System.Drawing.Point(12, 8);
            this.btnOpenExcel.Name = "btnOpenExcel";
            this.btnOpenExcel.Size = new System.Drawing.Size(182, 45);
            this.btnOpenExcel.TabIndex = 0;
            this.btnOpenExcel.Text = "Open in Microsoft Excel";
            this.btnOpenExcel.Click += new System.EventHandler(this.btnOpenExcel_Click);
            // 
            // treeList1
            // 
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(259, 655);
            this.treeList1.TabIndex = 0;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 655);
            this.Controls.Add(this.verticalSplitContainerControl1);
            this.Name = "Form1";
            this.Text = "Pivot Table API";
            this.verticalSplitContainerControl1.Panel1.ResumeLayout(false);
            this.verticalSplitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.verticalSplitContainerControl1)).EndInit();
            this.verticalSplitContainerControl1.ResumeLayout(false);
            this.horisontalSplitContainerControl1.Panel1.ResumeLayout(false);
            this.horisontalSplitContainerControl1.Panel1.PerformLayout();
            this.horisontalSplitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.horisontalSplitContainerControl1)).EndInit();
            this.horisontalSplitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer verticalSplitContainerControl1;
        private System.Windows.Forms.SplitContainer horisontalSplitContainerControl1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraEditors.LabelControl codeExampleNameLbl;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraRichEdit.RichEditControl richEditControlCS;
        private DevExpress.XtraRichEdit.RichEditControl richEditControlVB;
        private DevExpress.XtraEditors.SimpleButton btnOpenExcel;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}

