namespace Isolator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Canvas = new PictureBox();
            LeftStartControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            RightStartControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            TopStartControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            BottomStartControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            HorizontalBorderControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            VerticalBorderControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            IsolateButton = new DataJuggler.Win.Controls.Button();
            SourceImageControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            OutputFolderControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            OutputHeightControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            OutputWidthControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            OutputFileNameControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            StatusLabel = new Label();
            StatusTimer = new System.Windows.Forms.Timer(components);
            LaunchImageCheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            ((System.ComponentModel.ISupportInitialize)Canvas).BeginInit();
            SuspendLayout();
            // 
            // Canvas
            // 
            Canvas.BackColor = Color.Transparent;
            Canvas.BackgroundImage = Properties.Resources.Wood;
            Canvas.BackgroundImageLayout = ImageLayout.Stretch;
            Canvas.Location = new Point(32, 32);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(720, 576);
            Canvas.TabIndex = 0;
            Canvas.TabStop = false;
            Canvas.Visible = false;
            Canvas.Paint += Canvas_Paint;
            Canvas.MouseDown += Canvas_MouseDown;
            Canvas.MouseEnter += Canvas_MouseEnter;
            Canvas.MouseLeave += Canvas_MouseLeave;
            Canvas.MouseMove += Canvas_MouseMove;
            Canvas.MouseUp += Canvas_MouseUp;
            // 
            // LeftStartControl
            // 
            LeftStartControl.BackColor = Color.Transparent;
            LeftStartControl.BottomMargin = 0;
            LeftStartControl.Editable = true;
            LeftStartControl.Encrypted = false;
            LeftStartControl.Font = new Font("Calibri", 12F, FontStyle.Bold);
            LeftStartControl.Inititialized = true;
            LeftStartControl.LabelBottomMargin = 0;
            LeftStartControl.LabelColor = Color.LemonChiffon;
            LeftStartControl.LabelFont = new Font("Calibri", 12F, FontStyle.Bold);
            LeftStartControl.LabelText = "Left Start:";
            LeftStartControl.LabelTopMargin = 0;
            LeftStartControl.LabelWidth = 120;
            LeftStartControl.Location = new Point(760, 176);
            LeftStartControl.MultiLine = false;
            LeftStartControl.Name = "LeftStartControl";
            LeftStartControl.OnTextChangedListener = null;
            LeftStartControl.PasswordMode = false;
            LeftStartControl.ScrollBars = ScrollBars.None;
            LeftStartControl.Size = new Size(243, 32);
            LeftStartControl.TabIndex = 1;
            LeftStartControl.TextBoxBottomMargin = 0;
            LeftStartControl.TextBoxDisabledColor = Color.LightGray;
            LeftStartControl.TextBoxEditableColor = Color.White;
            LeftStartControl.TextBoxFont = new Font("Calibri", 12F);
            LeftStartControl.TextBoxTopMargin = 0;
            LeftStartControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // RightStartControl
            // 
            RightStartControl.BackColor = Color.Transparent;
            RightStartControl.BottomMargin = 0;
            RightStartControl.Editable = true;
            RightStartControl.Encrypted = false;
            RightStartControl.Font = new Font("Calibri", 12F, FontStyle.Bold);
            RightStartControl.Inititialized = true;
            RightStartControl.LabelBottomMargin = 0;
            RightStartControl.LabelColor = Color.LemonChiffon;
            RightStartControl.LabelFont = new Font("Calibri", 12F, FontStyle.Bold);
            RightStartControl.LabelText = "Right Start:";
            RightStartControl.LabelTopMargin = 0;
            RightStartControl.LabelWidth = 120;
            RightStartControl.Location = new Point(1007, 176);
            RightStartControl.MultiLine = false;
            RightStartControl.Name = "RightStartControl";
            RightStartControl.OnTextChangedListener = null;
            RightStartControl.PasswordMode = false;
            RightStartControl.ScrollBars = ScrollBars.None;
            RightStartControl.Size = new Size(243, 32);
            RightStartControl.TabIndex = 2;
            RightStartControl.TextBoxBottomMargin = 0;
            RightStartControl.TextBoxDisabledColor = Color.LightGray;
            RightStartControl.TextBoxEditableColor = Color.White;
            RightStartControl.TextBoxFont = new Font("Calibri", 12F);
            RightStartControl.TextBoxTopMargin = 0;
            RightStartControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // TopStartControl
            // 
            TopStartControl.BackColor = Color.Transparent;
            TopStartControl.BottomMargin = 0;
            TopStartControl.Editable = true;
            TopStartControl.Encrypted = false;
            TopStartControl.Font = new Font("Calibri", 12F, FontStyle.Bold);
            TopStartControl.Inititialized = true;
            TopStartControl.LabelBottomMargin = 0;
            TopStartControl.LabelColor = Color.LemonChiffon;
            TopStartControl.LabelFont = new Font("Calibri", 12F, FontStyle.Bold);
            TopStartControl.LabelText = "Top Start:";
            TopStartControl.LabelTopMargin = 0;
            TopStartControl.LabelWidth = 120;
            TopStartControl.Location = new Point(760, 224);
            TopStartControl.MultiLine = false;
            TopStartControl.Name = "TopStartControl";
            TopStartControl.OnTextChangedListener = null;
            TopStartControl.PasswordMode = false;
            TopStartControl.ScrollBars = ScrollBars.None;
            TopStartControl.Size = new Size(243, 32);
            TopStartControl.TabIndex = 3;
            TopStartControl.TextBoxBottomMargin = 0;
            TopStartControl.TextBoxDisabledColor = Color.LightGray;
            TopStartControl.TextBoxEditableColor = Color.White;
            TopStartControl.TextBoxFont = new Font("Calibri", 12F);
            TopStartControl.TextBoxTopMargin = 0;
            TopStartControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // BottomStartControl
            // 
            BottomStartControl.BackColor = Color.Transparent;
            BottomStartControl.BottomMargin = 0;
            BottomStartControl.Editable = true;
            BottomStartControl.Encrypted = false;
            BottomStartControl.Font = new Font("Calibri", 12F, FontStyle.Bold);
            BottomStartControl.Inititialized = true;
            BottomStartControl.LabelBottomMargin = 0;
            BottomStartControl.LabelColor = Color.LemonChiffon;
            BottomStartControl.LabelFont = new Font("Calibri", 12F, FontStyle.Bold);
            BottomStartControl.LabelText = "Bottom Start:";
            BottomStartControl.LabelTopMargin = 0;
            BottomStartControl.LabelWidth = 120;
            BottomStartControl.Location = new Point(1007, 224);
            BottomStartControl.MultiLine = false;
            BottomStartControl.Name = "BottomStartControl";
            BottomStartControl.OnTextChangedListener = null;
            BottomStartControl.PasswordMode = false;
            BottomStartControl.ScrollBars = ScrollBars.None;
            BottomStartControl.Size = new Size(243, 32);
            BottomStartControl.TabIndex = 4;
            BottomStartControl.TextBoxBottomMargin = 0;
            BottomStartControl.TextBoxDisabledColor = Color.LightGray;
            BottomStartControl.TextBoxEditableColor = Color.White;
            BottomStartControl.TextBoxFont = new Font("Calibri", 12F);
            BottomStartControl.TextBoxTopMargin = 0;
            BottomStartControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // HorizontalBorderControl
            // 
            HorizontalBorderControl.BackColor = Color.Transparent;
            HorizontalBorderControl.BottomMargin = 0;
            HorizontalBorderControl.Editable = true;
            HorizontalBorderControl.Encrypted = false;
            HorizontalBorderControl.Font = new Font("Calibri", 12F, FontStyle.Bold);
            HorizontalBorderControl.Inititialized = true;
            HorizontalBorderControl.LabelBottomMargin = 0;
            HorizontalBorderControl.LabelColor = Color.LemonChiffon;
            HorizontalBorderControl.LabelFont = new Font("Calibri", 12F, FontStyle.Bold);
            HorizontalBorderControl.LabelText = "Hor Border:";
            HorizontalBorderControl.LabelTopMargin = 0;
            HorizontalBorderControl.LabelWidth = 120;
            HorizontalBorderControl.Location = new Point(760, 272);
            HorizontalBorderControl.MultiLine = false;
            HorizontalBorderControl.Name = "HorizontalBorderControl";
            HorizontalBorderControl.OnTextChangedListener = null;
            HorizontalBorderControl.PasswordMode = false;
            HorizontalBorderControl.ScrollBars = ScrollBars.None;
            HorizontalBorderControl.Size = new Size(243, 32);
            HorizontalBorderControl.TabIndex = 5;
            HorizontalBorderControl.TextBoxBottomMargin = 0;
            HorizontalBorderControl.TextBoxDisabledColor = Color.LightGray;
            HorizontalBorderControl.TextBoxEditableColor = Color.White;
            HorizontalBorderControl.TextBoxFont = new Font("Calibri", 12F);
            HorizontalBorderControl.TextBoxTopMargin = 0;
            HorizontalBorderControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // VerticalBorderControl
            // 
            VerticalBorderControl.BackColor = Color.Transparent;
            VerticalBorderControl.BottomMargin = 0;
            VerticalBorderControl.Editable = true;
            VerticalBorderControl.Encrypted = false;
            VerticalBorderControl.Font = new Font("Calibri", 12F, FontStyle.Bold);
            VerticalBorderControl.Inititialized = true;
            VerticalBorderControl.LabelBottomMargin = 0;
            VerticalBorderControl.LabelColor = Color.LemonChiffon;
            VerticalBorderControl.LabelFont = new Font("Calibri", 12F, FontStyle.Bold);
            VerticalBorderControl.LabelText = "Ver Border:";
            VerticalBorderControl.LabelTopMargin = 0;
            VerticalBorderControl.LabelWidth = 120;
            VerticalBorderControl.Location = new Point(1007, 272);
            VerticalBorderControl.MultiLine = false;
            VerticalBorderControl.Name = "VerticalBorderControl";
            VerticalBorderControl.OnTextChangedListener = null;
            VerticalBorderControl.PasswordMode = false;
            VerticalBorderControl.ScrollBars = ScrollBars.None;
            VerticalBorderControl.Size = new Size(243, 32);
            VerticalBorderControl.TabIndex = 6;
            VerticalBorderControl.TextBoxBottomMargin = 0;
            VerticalBorderControl.TextBoxDisabledColor = Color.LightGray;
            VerticalBorderControl.TextBoxEditableColor = Color.White;
            VerticalBorderControl.TextBoxFont = new Font("Calibri", 12F);
            VerticalBorderControl.TextBoxTopMargin = 0;
            VerticalBorderControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // IsolateButton
            // 
            IsolateButton.BackColor = Color.Transparent;
            IsolateButton.ButtonText = "Isolate";
            IsolateButton.FlatStyle = FlatStyle.Flat;
            IsolateButton.ForeColor = Color.LemonChiffon;
            IsolateButton.Location = new Point(1130, 468);
            IsolateButton.Name = "IsolateButton";
            IsolateButton.Size = new Size(120, 44);
            IsolateButton.TabIndex = 7;
            IsolateButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Glass;
            IsolateButton.UseMnemonic = true;
            IsolateButton.Click += IsolateButton_Click;
            // 
            // SourceImageControl
            // 
            SourceImageControl.BackColor = Color.Transparent;
            SourceImageControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            SourceImageControl.ButtonColor = Color.LemonChiffon;
            SourceImageControl.ButtonImage = (Image)resources.GetObject("SourceImageControl.ButtonImage");
            SourceImageControl.ButtonWidth = 48;
            SourceImageControl.DarkMode = false;
            SourceImageControl.DisabledLabelColor = Color.Empty;
            SourceImageControl.Editable = true;
            SourceImageControl.EnabledLabelColor = Color.Empty;
            SourceImageControl.Filter = null;
            SourceImageControl.Font = new Font("Calibri", 12F);
            SourceImageControl.HideBrowseButton = false;
            SourceImageControl.LabelBottomMargin = 0;
            SourceImageControl.LabelColor = Color.LemonChiffon;
            SourceImageControl.LabelFont = new Font("Calibri", 12F, FontStyle.Bold);
            SourceImageControl.LabelText = "Source Image:";
            SourceImageControl.LabelTopMargin = 0;
            SourceImageControl.LabelWidth = 120;
            SourceImageControl.Location = new Point(760, 32);
            SourceImageControl.Name = "SourceImageControl";
            SourceImageControl.OnTextChangedListener = null;
            SourceImageControl.OpenCallback = null;
            SourceImageControl.ScrollBars = ScrollBars.None;
            SourceImageControl.SelectedPath = null;
            SourceImageControl.Size = new Size(490, 32);
            SourceImageControl.StartPath = null;
            SourceImageControl.TabIndex = 8;
            SourceImageControl.TextBoxBottomMargin = 0;
            SourceImageControl.TextBoxDisabledColor = Color.Empty;
            SourceImageControl.TextBoxEditableColor = Color.Empty;
            SourceImageControl.TextBoxFont = new Font("Calibri", 12F);
            SourceImageControl.TextBoxTopMargin = 0;
            SourceImageControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // OutputFolderControl
            // 
            OutputFolderControl.BackColor = Color.Transparent;
            OutputFolderControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
            OutputFolderControl.ButtonColor = Color.LemonChiffon;
            OutputFolderControl.ButtonImage = (Image)resources.GetObject("OutputFolderControl.ButtonImage");
            OutputFolderControl.ButtonWidth = 48;
            OutputFolderControl.DarkMode = false;
            OutputFolderControl.DisabledLabelColor = Color.Empty;
            OutputFolderControl.Editable = true;
            OutputFolderControl.EnabledLabelColor = Color.Empty;
            OutputFolderControl.Filter = null;
            OutputFolderControl.Font = new Font("Calibri", 12F);
            OutputFolderControl.HideBrowseButton = false;
            OutputFolderControl.LabelBottomMargin = 0;
            OutputFolderControl.LabelColor = Color.LemonChiffon;
            OutputFolderControl.LabelFont = new Font("Calibri", 12F, FontStyle.Bold);
            OutputFolderControl.LabelText = "Output Folder:";
            OutputFolderControl.LabelTopMargin = 0;
            OutputFolderControl.LabelWidth = 120;
            OutputFolderControl.Location = new Point(760, 80);
            OutputFolderControl.Name = "OutputFolderControl";
            OutputFolderControl.OnTextChangedListener = null;
            OutputFolderControl.OpenCallback = null;
            OutputFolderControl.ScrollBars = ScrollBars.None;
            OutputFolderControl.SelectedPath = null;
            OutputFolderControl.Size = new Size(490, 32);
            OutputFolderControl.StartPath = null;
            OutputFolderControl.TabIndex = 9;
            OutputFolderControl.TextBoxBottomMargin = 0;
            OutputFolderControl.TextBoxDisabledColor = Color.Empty;
            OutputFolderControl.TextBoxEditableColor = Color.Empty;
            OutputFolderControl.TextBoxFont = new Font("Calibri", 12F);
            OutputFolderControl.TextBoxTopMargin = 0;
            OutputFolderControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // OutputHeightControl
            // 
            OutputHeightControl.BackColor = Color.Transparent;
            OutputHeightControl.BottomMargin = 0;
            OutputHeightControl.Editable = true;
            OutputHeightControl.Encrypted = false;
            OutputHeightControl.Font = new Font("Calibri", 12F, FontStyle.Bold);
            OutputHeightControl.Inititialized = true;
            OutputHeightControl.LabelBottomMargin = 0;
            OutputHeightControl.LabelColor = Color.LemonChiffon;
            OutputHeightControl.LabelFont = new Font("Calibri", 12F, FontStyle.Bold);
            OutputHeightControl.LabelText = "Output Height:";
            OutputHeightControl.LabelTopMargin = 0;
            OutputHeightControl.LabelWidth = 120;
            OutputHeightControl.Location = new Point(1007, 320);
            OutputHeightControl.MultiLine = false;
            OutputHeightControl.Name = "OutputHeightControl";
            OutputHeightControl.OnTextChangedListener = null;
            OutputHeightControl.PasswordMode = false;
            OutputHeightControl.ScrollBars = ScrollBars.None;
            OutputHeightControl.Size = new Size(243, 32);
            OutputHeightControl.TabIndex = 13;
            OutputHeightControl.TextBoxBottomMargin = 0;
            OutputHeightControl.TextBoxDisabledColor = Color.LightGray;
            OutputHeightControl.TextBoxEditableColor = Color.White;
            OutputHeightControl.TextBoxFont = new Font("Calibri", 12F);
            OutputHeightControl.TextBoxTopMargin = 0;
            OutputHeightControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // OutputWidthControl
            // 
            OutputWidthControl.BackColor = Color.Transparent;
            OutputWidthControl.BottomMargin = 0;
            OutputWidthControl.Editable = true;
            OutputWidthControl.Encrypted = false;
            OutputWidthControl.Font = new Font("Calibri", 12F, FontStyle.Bold);
            OutputWidthControl.Inititialized = true;
            OutputWidthControl.LabelBottomMargin = 0;
            OutputWidthControl.LabelColor = Color.LemonChiffon;
            OutputWidthControl.LabelFont = new Font("Calibri", 12F, FontStyle.Bold);
            OutputWidthControl.LabelText = "Output Width:";
            OutputWidthControl.LabelTopMargin = 0;
            OutputWidthControl.LabelWidth = 120;
            OutputWidthControl.Location = new Point(760, 320);
            OutputWidthControl.MultiLine = false;
            OutputWidthControl.Name = "OutputWidthControl";
            OutputWidthControl.OnTextChangedListener = null;
            OutputWidthControl.PasswordMode = false;
            OutputWidthControl.ScrollBars = ScrollBars.None;
            OutputWidthControl.Size = new Size(243, 32);
            OutputWidthControl.TabIndex = 12;
            OutputWidthControl.TextBoxBottomMargin = 0;
            OutputWidthControl.TextBoxDisabledColor = Color.LightGray;
            OutputWidthControl.TextBoxEditableColor = Color.White;
            OutputWidthControl.TextBoxFont = new Font("Calibri", 12F);
            OutputWidthControl.TextBoxTopMargin = 0;
            OutputWidthControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // OutputFileNameControl
            // 
            OutputFileNameControl.BackColor = Color.Transparent;
            OutputFileNameControl.BottomMargin = 0;
            OutputFileNameControl.Editable = true;
            OutputFileNameControl.Encrypted = false;
            OutputFileNameControl.Font = new Font("Calibri", 12F, FontStyle.Bold);
            OutputFileNameControl.Inititialized = true;
            OutputFileNameControl.LabelBottomMargin = 0;
            OutputFileNameControl.LabelColor = Color.LemonChiffon;
            OutputFileNameControl.LabelFont = new Font("Calibri", 12F, FontStyle.Bold);
            OutputFileNameControl.LabelText = "Output Name:";
            OutputFileNameControl.LabelTopMargin = 0;
            OutputFileNameControl.LabelWidth = 120;
            OutputFileNameControl.Location = new Point(760, 128);
            OutputFileNameControl.MultiLine = false;
            OutputFileNameControl.Name = "OutputFileNameControl";
            OutputFileNameControl.OnTextChangedListener = null;
            OutputFileNameControl.PasswordMode = false;
            OutputFileNameControl.ScrollBars = ScrollBars.None;
            OutputFileNameControl.Size = new Size(490, 32);
            OutputFileNameControl.TabIndex = 14;
            OutputFileNameControl.TextBoxBottomMargin = 0;
            OutputFileNameControl.TextBoxDisabledColor = Color.LightGray;
            OutputFileNameControl.TextBoxEditableColor = Color.White;
            OutputFileNameControl.TextBoxFont = new Font("Calibri", 12F);
            OutputFileNameControl.TextBoxTopMargin = 0;
            OutputFileNameControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // StatusLabel
            // 
            StatusLabel.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StatusLabel.ForeColor = Color.LemonChiffon;
            StatusLabel.Location = new Point(32, 625);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(606, 43);
            StatusLabel.TabIndex = 15;
            // 
            // StatusTimer
            // 
            StatusTimer.Interval = 5000;
            StatusTimer.Tick += StatusTimer_Tick;
            // 
            // LaunchImageCheckBox
            // 
            LaunchImageCheckBox.BackColor = Color.Transparent;
            LaunchImageCheckBox.CheckBoxHorizontalOffSet = 0;
            LaunchImageCheckBox.CheckBoxVerticalOffSet = 4;
            LaunchImageCheckBox.CheckChangedListener = null;
            LaunchImageCheckBox.Checked = true;
            LaunchImageCheckBox.Editable = true;
            LaunchImageCheckBox.Font = new Font("Calibri", 12F);
            LaunchImageCheckBox.LabelColor = Color.LemonChiffon;
            LaunchImageCheckBox.LabelFont = new Font("Calibri", 12F, FontStyle.Bold);
            LaunchImageCheckBox.LabelText = "Launch Image:";
            LaunchImageCheckBox.LabelWidth = 120;
            LaunchImageCheckBox.Location = new Point(760, 580);
            LaunchImageCheckBox.Name = "LaunchImageCheckBox";
            LaunchImageCheckBox.Size = new Size(160, 28);
            LaunchImageCheckBox.TabIndex = 16;
            LaunchImageCheckBox.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1318, 685);
            Controls.Add(LaunchImageCheckBox);
            Controls.Add(StatusLabel);
            Controls.Add(OutputFileNameControl);
            Controls.Add(OutputHeightControl);
            Controls.Add(OutputWidthControl);
            Controls.Add(OutputFolderControl);
            Controls.Add(SourceImageControl);
            Controls.Add(IsolateButton);
            Controls.Add(VerticalBorderControl);
            Controls.Add(HorizontalBorderControl);
            Controls.Add(BottomStartControl);
            Controls.Add(TopStartControl);
            Controls.Add(RightStartControl);
            Controls.Add(LeftStartControl);
            Controls.Add(Canvas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Isolator";
            ((System.ComponentModel.ISupportInitialize)Canvas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Canvas;
        private DataJuggler.Win.Controls.LabelTextBoxControl LeftStartControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl RightStartControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl TopStartControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl BottomStartControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl HorizontalBorderControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl VerticalBorderControl;
        private DataJuggler.Win.Controls.Button IsolateButton;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl SourceImageControl;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl OutputFolderControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl OutputHeightControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl OutputWidthControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl OutputFileNameControl;
        private Label StatusLabel;
        private System.Windows.Forms.Timer StatusTimer;
        private DataJuggler.Win.Controls.LabelCheckBoxControl LaunchImageCheckBox;
    }
}
