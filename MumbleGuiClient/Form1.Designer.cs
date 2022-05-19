﻿namespace MumbleGuiClient
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelVoiceDetectorThreshold = new System.Windows.Forms.Label();
            this.numVoiceDetectorThreshold = new System.Windows.Forms.NumericUpDown();
            this.cbPlaybackDevices = new System.Windows.Forms.ComboBox();
            this.cbRecordingDevices = new System.Windows.Forms.ComboBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.RichTextBox();
            this.tbSendMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.labelServer = new System.Windows.Forms.Label();
            this.textBoxUserPassword = new System.Windows.Forms.TextBox();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.tvUsers = new MumbleGuiClient.ChannelsTreeView();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.mumbleUpdater = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVoiceDetectorThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelVoiceDetectorThreshold);
            this.splitContainer1.Panel1.Controls.Add(this.numVoiceDetectorThreshold);
            this.splitContainer1.Panel1.Controls.Add(this.cbPlaybackDevices);
            this.splitContainer1.Panel1.Controls.Add(this.cbRecordingDevices);
            this.splitContainer1.Panel1.Controls.Add(this.btnRecord);
            this.splitContainer1.Panel1.Controls.Add(this.tbLog);
            this.splitContainer1.Panel1.Controls.Add(this.tbSendMessage);
            this.splitContainer1.Panel1.Controls.Add(this.btnSend);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelServer);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxUserPassword);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxServer);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxUserName);
            this.splitContainer1.Panel2.Controls.Add(this.labelPassword);
            this.splitContainer1.Panel2.Controls.Add(this.labelUser);
            this.splitContainer1.Panel2.Controls.Add(this.tvUsers);
            this.splitContainer1.Panel2.Controls.Add(this.btnDisconnect);
            this.splitContainer1.Panel2.Controls.Add(this.btnConnect);
            this.splitContainer1.Size = new System.Drawing.Size(638, 294);
            this.splitContainer1.SplitterDistance = 383;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelVoiceDetectorThreshold
            // 
            this.labelVoiceDetectorThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVoiceDetectorThreshold.AutoSize = true;
            this.labelVoiceDetectorThreshold.Location = new System.Drawing.Point(117, 73);
            this.labelVoiceDetectorThreshold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVoiceDetectorThreshold.Name = "labelVoiceDetectorThreshold";
            this.labelVoiceDetectorThreshold.Size = new System.Drawing.Size(138, 15);
            this.labelVoiceDetectorThreshold.TabIndex = 7;
            this.labelVoiceDetectorThreshold.Text = "Voice Detector Threshold";
            // 
            // numVoiceDetectorThreshold
            // 
            this.numVoiceDetectorThreshold.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numVoiceDetectorThreshold.Location = new System.Drawing.Point(272, 69);
            this.numVoiceDetectorThreshold.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numVoiceDetectorThreshold.Name = "numVoiceDetectorThreshold";
            this.numVoiceDetectorThreshold.Size = new System.Drawing.Size(97, 23);
            this.numVoiceDetectorThreshold.TabIndex = 6;
            this.numVoiceDetectorThreshold.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numVoiceDetectorThreshold.ValueChanged += new System.EventHandler(this.numVoiceDetectionThreshold_ValueChanged);
            // 
            // cbPlaybackDevices
            // 
            this.cbPlaybackDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPlaybackDevices.FormattingEnabled = true;
            this.cbPlaybackDevices.Location = new System.Drawing.Point(4, 7);
            this.cbPlaybackDevices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbPlaybackDevices.Name = "cbPlaybackDevices";
            this.cbPlaybackDevices.Size = new System.Drawing.Size(261, 23);
            this.cbPlaybackDevices.TabIndex = 5;
            this.cbPlaybackDevices.SelectedIndexChanged += new System.EventHandler(this.cbPlaybackDevices_SelectedIndexChanged);
            // 
            // cbRecordingDevices
            // 
            this.cbRecordingDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRecordingDevices.FormattingEnabled = true;
            this.cbRecordingDevices.Location = new System.Drawing.Point(4, 38);
            this.cbRecordingDevices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbRecordingDevices.Name = "cbRecordingDevices";
            this.cbRecordingDevices.Size = new System.Drawing.Size(261, 23);
            this.cbRecordingDevices.TabIndex = 4;
            this.cbRecordingDevices.SelectedIndexChanged += new System.EventHandler(this.cbRecordingDevices_SelectedIndexChanged);
            // 
            // btnRecord
            // 
            this.btnRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecord.Location = new System.Drawing.Point(272, 38);
            this.btnRecord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(97, 24);
            this.btnRecord.TabIndex = 3;
            this.btnRecord.Text = "record";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // tbLog
            // 
            this.tbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLog.Location = new System.Drawing.Point(0, 99);
            this.tbLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(379, 161);
            this.tbLog.TabIndex = 0;
            this.tbLog.Text = "";
            // 
            // tbSendMessage
            // 
            this.tbSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSendMessage.Location = new System.Drawing.Point(4, 268);
            this.tbSendMessage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbSendMessage.Name = "tbSendMessage";
            this.tbSendMessage.Size = new System.Drawing.Size(271, 23);
            this.tbSendMessage.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(283, 268);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(97, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // labelServer
            // 
            this.labelServer.AutoSize = true;
            this.labelServer.Location = new System.Drawing.Point(4, 68);
            this.labelServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelServer.Name = "labelServer";
            this.labelServer.Size = new System.Drawing.Size(39, 15);
            this.labelServer.TabIndex = 9;
            this.labelServer.Text = "Server";
            // 
            // textBoxUserPassword
            // 
            this.textBoxUserPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUserPassword.Location = new System.Drawing.Point(64, 35);
            this.textBoxUserPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxUserPassword.Name = "textBoxUserPassword";
            this.textBoxUserPassword.PasswordChar = '*';
            this.textBoxUserPassword.Size = new System.Drawing.Size(181, 23);
            this.textBoxUserPassword.TabIndex = 5;
            this.textBoxUserPassword.Text = "123";
            // 
            // textBoxServer
            // 
            this.textBoxServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxServer.Location = new System.Drawing.Point(64, 65);
            this.textBoxServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(181, 23);
            this.textBoxServer.TabIndex = 2;
            this.textBoxServer.Text = "54.76.228.230:64738";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUserName.Location = new System.Drawing.Point(64, 3);
            this.textBoxUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(181, 23);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.Text = "JordanDemo";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(4, 38);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(57, 15);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Password";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(4, 7);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(30, 15);
            this.labelUser.TabIndex = 7;
            this.labelUser.Text = "User";
            // 
            // tvUsers
            // 
            this.tvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvUsers.Location = new System.Drawing.Point(4, 128);
            this.tvUsers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tvUsers.Name = "tvUsers";
            this.tvUsers.Size = new System.Drawing.Size(242, 162);
            this.tvUsers.TabIndex = 6;
            this.tvUsers.UpdateInterval = 500;
            this.tvUsers.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvUsers_BeforeCollapse);
            this.tvUsers.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvUsers_NodeMouseDoubleClick);
            this.tvUsers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tvUsers_MouseDoubleClick);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(64, 95);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(88, 27);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(159, 95);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(88, 27);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // mumbleUpdater
            // 
            this.mumbleUpdater.Enabled = true;
            this.mumbleUpdater.Interval = 10;
            this.mumbleUpdater.Tick += new System.EventHandler(this.mumbleUpdater_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 294);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "MumbleSharp Client - GUI version";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numVoiceDetectorThreshold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox tbLog;
        private System.Windows.Forms.TextBox tbSendMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Timer mumbleUpdater;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.ComboBox cbRecordingDevices;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox textBoxUserPassword;
        private ChannelsTreeView tvUsers;
        private System.Windows.Forms.ComboBox cbPlaybackDevices;
        private System.Windows.Forms.Label labelServer;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.NumericUpDown numVoiceDetectorThreshold;
        private System.Windows.Forms.Label labelVoiceDetectorThreshold;
    }
}

