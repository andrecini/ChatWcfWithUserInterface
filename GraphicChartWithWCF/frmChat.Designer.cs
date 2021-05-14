
namespace GraphicChartWithWCF
{
    partial class frmChat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.Chat = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtKeyboard = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.borderLayout1 = new Syncfusion.Windows.Forms.Tools.BorderLayout(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeyboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderLayout1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 33);
            this.panel1.TabIndex = 0;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(288, 7);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(50, 20);
            this.txtUser.TabIndex = 0;
            this.txtUser.Text = "Usuário";
            // 
            // Chat
            // 
            this.Chat.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(219)))), ((int)(((byte)(242))))), System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(244))))));
            this.Chat.Border3DStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.Chat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(110)))), ((int)(((byte)(115)))));
            this.Chat.Location = new System.Drawing.Point(0, 33);
            this.Chat.Name = "Chat";
            this.Chat.Size = new System.Drawing.Size(350, 377);
            this.Chat.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.btnSend.Font = new System.Drawing.Font("Impact", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(234)))), ((int)(((byte)(244)))));
            this.btnSend.Location = new System.Drawing.Point(286, 406);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(64, 50);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKeyboard
            // 
            this.txtKeyboard.BackColor = System.Drawing.SystemColors.Window;
            this.txtKeyboard.BeforeTouchSize = new System.Drawing.Size(288, 48);
            this.txtKeyboard.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.txtKeyboard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.txtKeyboard.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.txtKeyboard.Location = new System.Drawing.Point(0, 408);
            this.txtKeyboard.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.txtKeyboard.Multiline = true;
            this.txtKeyboard.Name = "txtKeyboard";
            this.txtKeyboard.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtKeyboard.Size = new System.Drawing.Size(288, 48);
            this.txtKeyboard.TabIndex = 0;
            // 
            // borderLayout1
            // 
            this.borderLayout1.CustomLayoutBounds = new System.Drawing.Rectangle(1, 0, 0, 0);
            this.borderLayout1.HGap = 0;
            this.borderLayout1.VGap = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 453);
            this.Controls.Add(this.Chat);
            this.Controls.Add(this.txtKeyboard);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmChat";
            this.Text = "Chat";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeyboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderLayout1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel Chat;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtKeyboard;
        private Syncfusion.Windows.Forms.Tools.BorderLayout borderLayout1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Timer timer1;
    }
}

