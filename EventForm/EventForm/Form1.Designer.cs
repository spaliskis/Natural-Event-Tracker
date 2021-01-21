
namespace EventForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.allEventsBtn = new System.Windows.Forms.Button();
            this.eventsPanel = new System.Windows.Forms.Panel();
            this.volcanoesBtn = new System.Windows.Forms.Button();
            this.wildfireBtn = new System.Windows.Forms.Button();
            this.stormsBtn = new System.Windows.Forms.Button();
            this.EventsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.clearBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.eventsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Panel1.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.gmap);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1282, 545);
            this.splitContainer1.SplitterDistance = 127;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clearBtn);
            this.panel1.Controls.Add(this.allEventsBtn);
            this.panel1.Controls.Add(this.eventsPanel);
            this.panel1.Controls.Add(this.EventsBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 545);
            this.panel1.TabIndex = 4;
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // allEventsBtn
            // 
            this.allEventsBtn.Location = new System.Drawing.Point(3, 80);
            this.allEventsBtn.Name = "allEventsBtn";
            this.allEventsBtn.Size = new System.Drawing.Size(131, 31);
            this.allEventsBtn.TabIndex = 6;
            this.allEventsBtn.Text = "All events";
            this.allEventsBtn.UseVisualStyleBackColor = true;
            this.allEventsBtn.Click += new System.EventHandler(this.allEventsBtn_Click);
            // 
            // eventsPanel
            // 
            this.eventsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventsPanel.Controls.Add(this.volcanoesBtn);
            this.eventsPanel.Controls.Add(this.wildfireBtn);
            this.eventsPanel.Controls.Add(this.stormsBtn);
            this.eventsPanel.Location = new System.Drawing.Point(3, 153);
            this.eventsPanel.Name = "eventsPanel";
            this.eventsPanel.Size = new System.Drawing.Size(131, 93);
            this.eventsPanel.TabIndex = 5;
            this.eventsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.eventsPanel_Paint);
            // 
            // volcanoesBtn
            // 
            this.volcanoesBtn.BackColor = System.Drawing.Color.Silver;
            this.volcanoesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.volcanoesBtn.Location = new System.Drawing.Point(0, 60);
            this.volcanoesBtn.Name = "volcanoesBtn";
            this.volcanoesBtn.Size = new System.Drawing.Size(131, 30);
            this.volcanoesBtn.TabIndex = 0;
            this.volcanoesBtn.Text = "Volcanoes";
            this.volcanoesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.volcanoesBtn.UseVisualStyleBackColor = false;
            this.volcanoesBtn.Click += new System.EventHandler(this.volcanoesBtn_Click);
            // 
            // wildfireBtn
            // 
            this.wildfireBtn.BackColor = System.Drawing.Color.Silver;
            this.wildfireBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.wildfireBtn.Location = new System.Drawing.Point(0, 30);
            this.wildfireBtn.Name = "wildfireBtn";
            this.wildfireBtn.Size = new System.Drawing.Size(131, 30);
            this.wildfireBtn.TabIndex = 1;
            this.wildfireBtn.Text = "Wildfires";
            this.wildfireBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wildfireBtn.UseVisualStyleBackColor = false;
            this.wildfireBtn.Click += new System.EventHandler(this.wildfireBtn_Click);
            // 
            // stormsBtn
            // 
            this.stormsBtn.BackColor = System.Drawing.Color.Silver;
            this.stormsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.stormsBtn.Location = new System.Drawing.Point(0, 0);
            this.stormsBtn.Name = "stormsBtn";
            this.stormsBtn.Size = new System.Drawing.Size(131, 30);
            this.stormsBtn.TabIndex = 2;
            this.stormsBtn.Text = "Storms";
            this.stormsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stormsBtn.UseVisualStyleBackColor = false;
            this.stormsBtn.Click += new System.EventHandler(this.stormsBtn_Click);
            // 
            // EventsBtn
            // 
            this.EventsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EventsBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EventsBtn.Location = new System.Drawing.Point(3, 117);
            this.EventsBtn.Name = "EventsBtn";
            this.EventsBtn.Size = new System.Drawing.Size(134, 30);
            this.EventsBtn.TabIndex = 3;
            this.EventsBtn.Text = "Event Types";
            this.EventsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EventsBtn.UseVisualStyleBackColor = false;
            this.EventsBtn.Click += new System.EventHandler(this.EventsBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(458, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Natural Event Tracker";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gmap
            // 
            this.gmap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemory = 5;
            this.gmap.Location = new System.Drawing.Point(12, 48);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 2;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(1127, 485);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 0D;
            this.gmap.Load += new System.EventHandler(this.gmap_Load);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(3, 48);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(131, 26);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Clear Map";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1282, 545);
            this.Controls.Add(this.splitContainer1);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeBegin += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.eventsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel eventsPanel;
        private System.Windows.Forms.Button volcanoesBtn;
        private System.Windows.Forms.Button wildfireBtn;
        private System.Windows.Forms.Button stormsBtn;
        private System.Windows.Forms.Button EventsBtn;
        private System.Windows.Forms.Button allEventsBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}

