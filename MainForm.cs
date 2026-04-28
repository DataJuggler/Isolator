

#region using statements

using DataJuggler.PixelDatabase;
using DataJuggler.PixelDatabase.Enumerations;
using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;
using DataJuggler.UltimateHelper;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

#endregion

namespace Isolator
{

    #region class MainForm
    /// <summary>
    /// This class is the main form for this app
    /// </summary>
    public partial class MainForm : Form, ITextChanged
    {

        #region Private Variables
        private PixelDatabase pixelDB;
        private Rectangle controlSelectionRect;
        private Point dragStartPoint;
        private Rectangle lastRubberBandRect;
        private bool isDragging;
        private Timer marchTimer;
        private int marchOffset;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events

        #region Canvas_MouseDown(object sender, MouseEventArgs e)
        /// <summary>
        /// event is fired when Canvas _ Mouse Down
        /// </summary>
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            // if the left button was clicked.
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                dragStartPoint = e.Location;
                controlSelectionRect = Rectangle.Empty;
                lastRubberBandRect = Rectangle.Empty;
                marchTimer.Stop();
                Canvas.Capture = true;
            }
        }
        #endregion

        #region Canvas_MouseEnter(object sender, EventArgs e)
        /// <summary>
        /// event is fired when Canvas _ Mouse Enter
        /// </summary>
        private void Canvas_MouseEnter(object sender, EventArgs e)
        {
            // Only change cursor to hand if we actually have an image loaded
            // (no point showing "you can click here" on an empty canvas)
            if (Canvas.Image != null)
            {
                Cursor = Cursors.Hand;
            }
        }
        #endregion

        #region Canvas_MouseLeave(object sender, EventArgs e)
        /// <summary>
        /// event is fired when Canvas _ Mouse Leave
        /// </summary>
        private void Canvas_MouseLeave(object sender, EventArgs e)
        {
            // Change the cursor back to the default pointer
            Cursor = Cursors.Default;
        }
        #endregion

        #region Canvas_MouseMove(object sender, MouseEventArgs e)
        /// <summary>
        /// event is fired when Canvas _ Mouse Move
        /// </summary>
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            // if dragging
            if (isDragging)
            {
                // Get the current drawn rectangle
                Rectangle currentRect = GetNormalizedRectangle(dragStartPoint, e.Location);

                // Erase previous rubber band
                if (!lastRubberBandRect.IsEmpty)
                {
                    // Draw the ReversibleFrame
                    ControlPaint.DrawReversibleFrame(Canvas.RectangleToScreen(lastRubberBandRect), Color.Black, FrameStyle.Dashed);
                }

                // Draw new rubber band
                if (!currentRect.IsEmpty)
                {
                    // Draw the ReversibleFrame
                    ControlPaint.DrawReversibleFrame(Canvas.RectangleToScreen(currentRect), Color.Black, FrameStyle.Dashed);
                }

                // set the lastRubberBandRect to the currentRect
                lastRubberBandRect = currentRect;
            }
        }
        #endregion

        #region Canvas_MouseUp(object sender, MouseEventArgs e)
        /// <summary>
        /// event is fired when Canvas _ Mouse Up
        /// </summary>
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            bool shouldProcessSelection = false;

            if (isDragging)
            {
                if (e.Button == MouseButtons.Left)
                {
                    shouldProcessSelection = true;
                }
            }

            if (shouldProcessSelection)
            {
                isDragging = false;
                Canvas.Capture = false;

                // Erase last rubber band
                if (!lastRubberBandRect.IsEmpty)
                {
                    ControlPaint.DrawReversibleFrame(
                    Canvas.RectangleToScreen(lastRubberBandRect),
                    Color.Black, FrameStyle.Dashed);
                }

                lastRubberBandRect = Rectangle.Empty;

                // Finalize the selection rectangle
                controlSelectionRect = GetNormalizedRectangle(dragStartPoint, e.Location);

                // Start marching ants animation
                marchTimer.Start();
                Canvas.Invalidate();

                // This is the important call you were missing
                UpdateSelectionFields();
            }
        }
        #endregion

        #region Canvas_Paint(object sender, PaintEventArgs e)
        /// <summary>
        /// event is fired when Canvas _ Paint
        /// </summary>
        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            // default value
            bool shouldDrawSelection = false;

            if (!controlSelectionRect.IsEmpty)
            {
                if (!isDragging)
                {
                    shouldDrawSelection = true;
                }
            }

            // if the value for shouldDrawSelection is true
            if (shouldDrawSelection)
            {
                // Marching ants effect
                using (Pen blackPen = new Pen(Color.Black, 2.4f))
                {
                    blackPen.DashStyle = DashStyle.Dash;
                    blackPen.DashOffset = marchOffset;
                    e.Graphics.DrawRectangle(blackPen, controlSelectionRect);
                }

                using (Pen whitePen = new Pen(Color.White, 2.4f))
                {
                    whitePen.DashStyle = DashStyle.Dash;
                    whitePen.DashOffset = marchOffset + 4;
                    e.Graphics.DrawRectangle(whitePen, controlSelectionRect);
                }
            }
        }
        #endregion

        #region IsolateButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'IsolateButton' is clicked.
        /// </summary>
        private void IsolateButton_Click(object sender, EventArgs e)
        {
            // Capture values from form
            int leftX = LeftStartControl.IntValue;
            int topY = TopStartControl.IntValue;
            int rightX = RightStartControl.IntValue;
            int bottomY = BottomStartControl.IntValue;

            // borders
            int horizontalBorder = HorizontalBorderControl.IntValue;
            int verticalBorder = VerticalBorderControl.IntValue;

            // calculated values
            int midX = (leftX + rightX) / 2;
            int midY = (topY + bottomY) / 2;

            // create the point to copy the result
            int left = horizontalBorder;
            int top = verticalBorder;
            Point outputPoint = new Point(left, top);

            // for resizing
            int newHeight = 0;
            int newWidth = 0;

            // if the value for HasPixelDB is true
            if (HasPixelDB)
            {
                // we need to find the start coordinates
                PixelInformation leftPixel = PixelDB.FindFirstVisiblePixel(leftX, midY, DirectionEnum.LeftToRight);
                PixelInformation rightPixel = PixelDB.FindFirstVisiblePixel(rightX, midY, DirectionEnum.RightToLeft);
                PixelInformation topPixel = PixelDB.FindFirstVisiblePixel(midX, topY, DirectionEnum.TopToBottom);
                PixelInformation bottomPixel = PixelDB.FindFirstVisiblePixel(midX, bottomY, DirectionEnum.BottomToTop);

                // if all four exists
                if (NullHelper.Exists(leftPixel, rightPixel, topPixel, bottomPixel))
                {
                    // now we need to size of the sum image
                    Point topLeft = new Point(leftPixel.X, topPixel.Y);
                    Rectangle size = new Rectangle(topLeft.X, topLeft.Y, rightPixel.X - leftPixel.X, bottomPixel.Y - topPixel.Y);

                    // Create an isolated bitmap
                    Bitmap isolatedImage = PixelDB.CreateSubImage(topLeft, size);

                    // If the isolatedImage object exists
                    if (NullHelper.Exists(isolatedImage))
                    {
                        // load a pixelDatabase
                        PixelDatabase isolatedPixelDatabase = PixelDatabaseLoader.LoadPixelDatabase(isolatedImage, null);

                        // If the isolatedPixelDatabase object exists
                        if (NullHelper.Exists(isolatedPixelDatabase))
                        {
                            // set to isolated pixel database
                            PixelDatabase resizedImage = null;

                            // if either border is > 0, then we must resize the isolated image
                            if (horizontalBorder > 0 || verticalBorder > 0)
                            {
                                // set the new height and width
                                newHeight = OutputHeightControl.IntValue - verticalBorder * 2;
                                newWidth = OutputWidthControl.IntValue - horizontalBorder * 2;

                                // we must resize this image
                                resizedImage = isolatedPixelDatabase.Resize(newHeight, newWidth);
                            }
                            else
                            {
                                // resize to output size
                                newHeight = OutputHeightControl.IntValue;
                                newWidth = OutputWidthControl.IntValue;

                                // we must resize this image
                                resizedImage = isolatedPixelDatabase.Resize(newHeight, newWidth);
                            }

                            // If the resizedImage object exists
                            if (NullHelper.Exists(resizedImage))
                            {
                                // now we must load the blank image
                                Bitmap blankImage = Properties.Resources.Blank;

                                // load a pixelDatabase for the blank image
                                PixelDatabase blank = PixelDatabaseLoader.LoadPixelDatabase(blankImage, null);

                                // If the blank object exists
                                if (NullHelper.Exists(blank))
                                {
                                    // get the height and width
                                    int width = OutputWidthControl.IntValue;
                                    int height = OutputHeightControl.IntValue;

                                    // if the blank image is not the right size
                                    if ((blank.Width != width) || (blank.Height != height))
                                    {
                                        // Resize the blank
                                        blank = blank.Resize(OutputHeightControl.IntValue, OutputWidthControl.IntValue);    
                                    }

                                    // copy the sub image onto the blank
                                    blank.CopySubImage(resizedImage, outputPoint);

                                    // Now save the outputImage
                                    string path = Path.Combine(OutputFolderControl.Text, OutputFileNameControl.Text);

                                    // Save this image
                                    blank.SaveAs(path);

                                    // Show a message in red
                                    ShowStatus("Saved!", Color.LemonChiffon);

                                    // if Luanch Image is checked
                                    if (LaunchImageCheckBox.Checked)
                                    {
                                        // launch the file
                                        // Best way - explicit and clear
                                        var startInfo = new ProcessStartInfo
                                        {
                                            FileName = path,
                                            UseShellExecute = true
                                        };

                                        // launch the file
                                        Process.Start(startInfo);
                                    }
                                }
                                else
                                {
                                    // Show a message in red
                                    ShowStatus("Blank Image Does Not Exist", Color.Firebrick);
                                }
                            }
                            else
                            {
                                // Show a message in red
                                ShowStatus("Resized Image Does Not Exist", Color.Firebrick);
                            }
                        }
                        else
                        {
                            // Show a message in red
                            ShowStatus("Isolated Image Does Not Exist", Color.Firebrick);
                        }
                    }
                    else
                    {
                        // Show a message in red
                        ShowStatus("Isolated pixel database Does Not Exist", Color.Firebrick);
                    }
                }
                else
                {
                    // Show a message in red
                    ShowStatus("Image Could Not Be Isolated", Color.Firebrick);
                }
            }
            else
            {
                // Show a message in red
                ShowStatus("Source Image Does Not Exist", Color.Firebrick);
            }
        }
        #endregion

        #region MarchTimer_Tick(object sender, EventArgs e)
        /// <summary>
        /// event is fired when March Timer _ Tick
        /// </summary>
        private void MarchTimer_Tick(object sender, EventArgs e)
        {
            // Every timer tick we move the "ants" a little bit so they appear to march
            marchOffset = (marchOffset + 1) % 12;

            // Tell the Canvas to repaint itself so we see the new position of the ants
            Canvas.Invalidate();
        }
        #endregion

        #region OnTextChanged(Control sender, string text)
        /// <summary>
        /// event is fired when On Text Changed
        /// </summary>
        public void OnTextChanged(Control sender, string text)
        {
            // Get the fileName
            string fileName = SourceImageControl.Text;

            // If the fileName Exists On Disk
            if (FileHelper.Exists(fileName))
            {
                // Load the PixelDatabase
                this.PixelDB = PixelDatabaseLoader.LoadPixelDatabase(fileName, null);

                // if the value for HasPixelDB is true
                if (HasPixelDB)
                {
                    // Set the Background Image
                    Canvas.Image = PixelDB.DirectBitmap.Bitmap;

                    // Show the Canvas
                    Canvas.Visible = true;
                }
            }
        }
        #endregion

        #region StatusTimer_Tick(object sender, EventArgs e)
        /// <summary>
        /// event is fired when Status Timer _ Tick
        /// </summary>
        private void StatusTimer_Tick(object sender, EventArgs e)
        {
            // hide
            StatusLabel.Visible = false;
        }
        #endregion
        
        #endregion

        #region Methods

        #region GetImagePoint(Point controlPoint)
        /// <summary>
        /// method returns the Image Point
        /// </summary>
        private Point GetImagePoint(Point controlPoint)
        {
            if (Canvas.Image == null)
                return controlPoint;

            int imgW = Canvas.Image.Width;
            int imgH = Canvas.Image.Height;
            int pbW = Canvas.ClientSize.Width;
            int pbH = Canvas.ClientSize.Height;

            if (pbW == 0 || pbH == 0)
                return Point.Empty;

            // StretchImage scaling
            float scaleX = (float)imgW / pbW;
            float scaleY = (float)imgH / pbH;

            int x = (int)Math.Round(controlPoint.X * scaleX);
            int y = (int)Math.Round(controlPoint.Y * scaleY);

            x = Math.Max(0, Math.Min(x, imgW - 1));
            y = Math.Max(0, Math.Min(y, imgH - 1));

            return new Point(x, y);
        }
        #endregion

        #region GetImageRectFromControlRect(Rectangle controlRect)
        /// <summary>
        /// method returns the Image Rect From Control Rect
        /// </summary>
        private Rectangle GetImageRectFromControlRect(Rectangle controlRect)
        {
            if (controlRect.IsEmpty || Canvas.Image == null)
                return Rectangle.Empty;

            Point topLeft = GetImagePoint(controlRect.Location);
            Point bottomRight = GetImagePoint(new Point(controlRect.Right, controlRect.Bottom));

            int x = topLeft.X;
            int y = topLeft.Y;
            int width = bottomRight.X - topLeft.X;
            int height = bottomRight.Y - topLeft.Y;

            width = Math.Max(0, Math.Min(width, Canvas.Image.Width - x));
            height = Math.Max(0, Math.Min(height, Canvas.Image.Height - y));

            return new Rectangle(x, y, width, height);
        }
        #endregion

        #region GetNormalizedRectangle(Point p1, Point p2)
        /// <summary>
        /// method returns the Normalized Rectangle
        /// </summary>
        private Rectangle GetNormalizedRectangle(Point p1, Point p2)
        {
            int x = Math.Min(p1.X, p2.X);
            int y = Math.Min(p1.Y, p2.Y);
            int width = Math.Abs(p1.X - p2.X);
            int height = Math.Abs(p1.Y - p2.Y);

            // Clamp to Canvas bounds
            x = Math.Max(0, x);
            y = Math.Max(0, y);
            width = Math.Min(width, Canvas.Width - x);
            height = Math.Min(height, Canvas.Height - y);

            return new Rectangle(x, y, width, height);
        }
        #endregion

        #region Init()
        /// <summary>
        ///  This method performs initializations for this object.
        /// </summary>
        public void Init()
        {
            // wire up listener
            SourceImageControl.OnTextChangedListener = this;

            // Setup defaults for testing
            SourceImageControl.Text = @"C:\VideoProjects\Cards2026\Aces.png";
            OutputWidthControl.Text = "400";
            OutputHeightControl.Text = "560";            
            HorizontalBorderControl.Text = "2";
            VerticalBorderControl.Text = "2";
            LeftStartControl.Text = "0";
            RightStartControl.Text = "0";
            TopStartControl.Text = "0";
            BottomStartControl.Text = "0";
            Canvas.BackgroundImageLayout = ImageLayout.Stretch;
            Canvas.SizeMode = PictureBoxSizeMode.StretchImage;

            // For bouding box selection / Marching Ants Initialization
            // 
            controlSelectionRect = Rectangle.Empty;
            dragStartPoint = Point.Empty;
            lastRubberBandRect = Rectangle.Empty;
            isDragging = false;
            marchOffset = 0;

            // Create the timer
            marchTimer = new Timer
            {
                Interval = 120
            };
            marchTimer.Tick += MarchTimer_Tick;

            // Setting up double buffering
            this.DoubleBuffered = true;
        }
        #endregion

        #region ShowStatus(string message, Color color, bool visible = true)
        /// <summary>
        /// Show Status
        /// </summary>
        public void ShowStatus(string message, Color color, bool visible = true)
        {
            // Set the color and text
            StatusLabel.ForeColor = color;
            StatusLabel.Text = message;
            StatusLabel.Visible = visible;

            // if the value for visible is true
            if (visible)
            {
                // Start the timer
                StatusTimer.Start();
            }
        }
        #endregion

        #region UpdateSelectionFields()
        /// <summary>
        /// method Update Selection Fields
        /// </summary>
        private void UpdateSelectionFields()
        {
            // local
            bool shouldUpdate = false;

            // if the rectangle exists and an image is loaded
            if (!controlSelectionRect.IsEmpty)
            {
                // if the image exists
                if (Canvas.Image != null)
                {
                    // set to true
                    shouldUpdate = true;
                }
            }

            // if shouldUpdate
            if (shouldUpdate)
            {
                // Get the selected rectangle
                Rectangle imgRect = GetImageRectFromControlRect(controlSelectionRect);

                LeftStartControl.Text = imgRect.X.ToString();
                RightStartControl.Text = imgRect.Right.ToString();
                TopStartControl.Text = imgRect.Y.ToString();
                BottomStartControl.Text = imgRect.Bottom.ToString();
            }
        }
        #endregion

        #endregion

        #region Properties

        #region ControlSelectionRect
        /// <summary>
        /// This property gets or sets the value for 'ControlSelectionRect'.
        /// </summary>
        public Rectangle ControlSelectionRect
        {
            get { return controlSelectionRect; }
            set { controlSelectionRect = value; }
        }
        #endregion

        #region CreateParams
        /// <summary>
        /// This property here is what did the trick to reduce the flickering.
        /// I also needed to make all of the controls Double Buffered, but
        /// this was the final touch. It is a little slow when you switch tabs
        /// but that is because the repainting is finishing before control is
        /// returned.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                // initial value
                CreateParams cp = base.CreateParams;

                // Apparently this interrupts Paint to finish before showing
                cp.ExStyle |= 0x02000000;

                // return value
                return cp;
            }
        }
        #endregion

        #region DragStartPoint
        /// <summary>
        /// This property gets or sets the value for 'DragStartPoint'.
        /// </summary>
        public Point DragStartPoint
        {
            get { return dragStartPoint; }
            set { dragStartPoint = value; }
        }
        #endregion

        #region HasPixelDB
        /// <summary>
        /// This property returns true if this object has a 'HasPixelDB'.
        /// </summary>
        public bool HasPixelDB
        {
            get
            {
                // initial value
                bool hasPixelDB = (PixelDB != null);

                // return value
                return hasPixelDB;
            }
        }
        #endregion

        #region IsDragging
        /// <summary>
        /// This property gets or sets the value for 'IsDragging'.
        /// </summary>
        public bool IsDragging
        {
            get { return isDragging; }
            set { isDragging = value; }
        }
        #endregion

        #region LastRubberBandRect
        /// <summary>
        /// This property gets or sets the value for 'LastRubberBandRect'.
        /// </summary>
        public Rectangle LastRubberBandRect
        {
            get { return lastRubberBandRect; }
            set { lastRubberBandRect = value; }
        }
        #endregion

        #region MarchOffset
        /// <summary>
        /// This property gets or sets the value for 'MarchOffset'.
        /// </summary>
        public int MarchOffset
        {
            get { return marchOffset; }
            set { marchOffset = value; }
        }
        #endregion

        #region MarchTimer
        /// <summary>
        /// This property gets or sets the value for 'MarchTimer'.
        /// </summary>
        public Timer MarchTimer
        {
            get { return marchTimer; }
            set { marchTimer = value; }
        }
        #endregion

        #region PixelDatabase
        /// <summary>
        /// This property gets or sets the value for 'PixelDatabase'.
        /// </summary>
        public PixelDatabase PixelDB
        {
            get { return pixelDB; }
            set { pixelDB = value; }
        }
        #endregion

        #endregion

    }
    #endregion

}
