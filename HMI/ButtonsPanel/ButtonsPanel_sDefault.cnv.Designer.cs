/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 7/13/2016
 * Time: 4:28 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.ButtonsPanel
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.label1 = new NxtControl.GuiFramework.Label();
			this.roundRectangle2 = new NxtControl.GuiFramework.RoundedRectangle();
			this.label2 = new NxtControl.GuiFramework.Label();
			this.roundedRectangle3 = new NxtControl.GuiFramework.RoundedRectangle();
			this.label3 = new NxtControl.GuiFramework.Label();
			this.roundedRectangle4 = new NxtControl.GuiFramework.RoundedRectangle();
			this.label4 = new NxtControl.GuiFramework.Label();
			this.startLed = new NxtControl.GuiFramework.RoundedRectangle();
			this.resetLed = new NxtControl.GuiFramework.RoundedRectangle();
			this.ackLed = new NxtControl.GuiFramework.RoundedRectangle();
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.stopButton = new NxtControl.GuiFramework.Group();
			this.roundedRectangle5 = new NxtControl.GuiFramework.RoundedRectangle();
			this.label5 = new NxtControl.GuiFramework.Label();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.start_led = new System.HMI.Symbols.Base.Execute<bool>();
			this.reset_led = new System.HMI.Symbols.Base.Execute<bool>();
			this.ack_led = new System.HMI.Symbols.Base.Execute<bool>();
			this.startButton = new NxtControl.GuiFramework.Group();
			this.ackButton = new NxtControl.GuiFramework.Group();
			this.resetButton = new NxtControl.GuiFramework.Group();
			this.ellipse2 = new NxtControl.GuiFramework.Ellipse();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.singleSwitch = new NxtControl.GuiFramework.Group();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(25D)), ((float)(35D)), ((float)(372D)), ((float)(96D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(222)), ((byte)(243))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(49D)), ((float)(71D)), ((float)(50D)), ((float)(50D)));
			this.roundedRectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(130)), ((byte)(130)), ((byte)(130))));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			this.roundedRectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// label1
			// 
			this.label1.AngleIgnore = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label1.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(43D)), ((float)(36D)), ((float)(21D)));
			this.label1.Brush = new NxtControl.Drawing.Brush("White");
			this.label1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.label1.Name = "label1";
			this.label1.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label1.ShadowOffSet = 1;
			this.label1.Text = "Start";
			this.label1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label1.TextAutoSizeHorizontalOffset = 10;
			this.label1.TextColor = new NxtControl.Drawing.Color("DarkGrey");
			this.label1.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// roundRectangle2
			// 
			this.roundRectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(117D)), ((float)(71D)), ((float)(50D)), ((float)(50D)));
			this.roundRectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(130)), ((byte)(130)), ((byte)(130))));
			this.roundRectangle2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.roundRectangle2.Name = "roundRectangle2";
			this.roundRectangle2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// label2
			// 
			this.label2.AngleIgnore = true;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label2.Bounds = new NxtControl.Drawing.RectF(((float)(121D)), ((float)(43D)), ((float)(43D)), ((float)(21D)));
			this.label2.Brush = new NxtControl.Drawing.Brush("White");
			this.label2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.label2.Name = "label2";
			this.label2.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label2.ShadowOffSet = 1;
			this.label2.Text = "Reset";
			this.label2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.label2.TextAutoSizeHorizontalOffset = 10;
			this.label2.TextColor = new NxtControl.Drawing.Color("DarkGrey");
			this.label2.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// roundedRectangle3
			// 
			this.roundedRectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(186D)), ((float)(71D)), ((float)(50D)), ((float)(50D)));
			this.roundedRectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(130)), ((byte)(130)), ((byte)(130))));
			this.roundedRectangle3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle3.Name = "roundedRectangle3";
			this.roundedRectangle3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// label3
			// 
			this.label3.AngleIgnore = true;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label3.Bounds = new NxtControl.Drawing.RectF(((float)(193D)), ((float)(43D)), ((float)(36D)), ((float)(21D)));
			this.label3.Brush = new NxtControl.Drawing.Brush("White");
			this.label3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.label3.Name = "label3";
			this.label3.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label3.ShadowOffSet = 1;
			this.label3.Text = "Ack";
			this.label3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.label3.TextAutoSizeHorizontalOffset = 10;
			this.label3.TextColor = new NxtControl.Drawing.Color("DarkGrey");
			this.label3.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// roundedRectangle4
			// 
			this.roundedRectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(254D)), ((float)(71D)), ((float)(50D)), ((float)(50D)));
			this.roundedRectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.roundedRectangle4.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle4.Name = "roundedRectangle4";
			this.roundedRectangle4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// label4
			// 
			this.label4.AngleIgnore = true;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label4.Bounds = new NxtControl.Drawing.RectF(((float)(262D)), ((float)(43D)), ((float)(36D)), ((float)(21D)));
			this.label4.Brush = new NxtControl.Drawing.Brush("White");
			this.label4.Font = new NxtControl.Drawing.Font("LabelFont");
			this.label4.Name = "label4";
			this.label4.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label4.ShadowOffSet = 1;
			this.label4.Text = "Stop";
			this.label4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label4.TextAutoSizeHorizontalOffset = 10;
			this.label4.TextColor = new NxtControl.Drawing.Color("DarkGrey");
			this.label4.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// startLed
			// 
			this.startLed.Bounds = new NxtControl.Drawing.RectF(((float)(49D)), ((float)(71D)), ((float)(50D)), ((float)(50D)));
			this.startLed.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(231)), ((byte)(231)), ((byte)(231))));
			this.startLed.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.startLed.Name = "startLed";
			this.startLed.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// resetLed
			// 
			this.resetLed.Bounds = new NxtControl.Drawing.RectF(((float)(117D)), ((float)(71D)), ((float)(50D)), ((float)(50D)));
			this.resetLed.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(231)), ((byte)(231)), ((byte)(231))));
			this.resetLed.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.resetLed.Name = "resetLed";
			this.resetLed.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ackLed
			// 
			this.ackLed.Bounds = new NxtControl.Drawing.RectF(((float)(186D)), ((float)(71D)), ((float)(50D)), ((float)(50D)));
			this.ackLed.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(231)), ((byte)(231)), ((byte)(231))));
			this.ackLed.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ackLed.Name = "ackLed";
			this.ackLed.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(262D)), ((float)(80D)), ((float)(33D)), ((float)(33D)));
			this.ellipse1.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.ellipse1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			this.ellipse1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))), 3F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// stopButton
			// 
			this.stopButton.BeginInit();
			this.stopButton.Name = "stopButton";
			this.stopButton.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.roundedRectangle4,
			this.ellipse1});
			this.stopButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StopButtonMouseDown);
			this.stopButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StopButtonMouseUp);
			this.stopButton.EndInit();
			// 
			// roundedRectangle5
			// 
			this.roundedRectangle5.Bounds = new NxtControl.Drawing.RectF(((float)(326D)), ((float)(71D)), ((float)(50D)), ((float)(50D)));
			this.roundedRectangle5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(130)), ((byte)(130)), ((byte)(130))));
			this.roundedRectangle5.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle5.Name = "roundedRectangle5";
			this.roundedRectangle5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// label5
			// 
			this.label5.AngleIgnore = true;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label5.Bounds = new NxtControl.Drawing.RectF(((float)(307D)), ((float)(43D)), ((float)(91D)), ((float)(21D)));
			this.label5.Brush = new NxtControl.Drawing.Brush("White");
			this.label5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.label5.Name = "label5";
			this.label5.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label5.ShadowOffSet = 1;
			this.label5.Text = "Manual";
			this.label5.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.label5.TextAutoSizeHorizontalOffset = 10;
			this.label5.TextColor = new NxtControl.Drawing.Color("DarkGrey");
			this.label5.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(74D, 109D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(74D, 84D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(142D, 109D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(142D, 84D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(211D, 109D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(211D, 84D);
			// 
			// start_led
			// 
			this.start_led.BeginInit();
			this.start_led.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.start_led.IsOnlyInput = true;
			this.start_led.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.start_led.Name = "start_led";
			this.start_led.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.start_led.TagName = "start_led";
			this.start_led.Value = false;
			this.start_led.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Start_ledValueChanged);
			this.start_led.EndInit();
			// 
			// reset_led
			// 
			this.reset_led.BeginInit();
			this.reset_led.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.reset_led.IsOnlyInput = true;
			this.reset_led.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.reset_led.Name = "reset_led";
			this.reset_led.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.reset_led.TagName = "reset_led";
			this.reset_led.Value = false;
			this.reset_led.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Reset_ledValueChanged);
			this.reset_led.EndInit();
			// 
			// ack_led
			// 
			this.ack_led.BeginInit();
			this.ack_led.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.ack_led.IsOnlyInput = true;
			this.ack_led.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.ack_led.Name = "ack_led";
			this.ack_led.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.ack_led.TagName = "ack_led";
			this.ack_led.Value = false;
			this.ack_led.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Ack_ledValueChanged);
			this.ack_led.EndInit();
			// 
			// startButton
			// 
			this.startButton.BeginInit();
			this.startButton.Name = "startButton";
			this.startButton.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.roundedRectangle1,
			this.startLed,
			this.line1});
			this.startButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartButtonMouseDown);
			this.startButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StartButtonMouseUp);
			this.startButton.MouseLeave += new System.EventHandler(this.StartButtonMouseLeave);
			this.startButton.EndInit();
			// 
			// ackButton
			// 
			this.ackButton.BeginInit();
			this.ackButton.Name = "ackButton";
			this.ackButton.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.roundedRectangle3,
			this.ackLed,
			this.line3});
			this.ackButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AckButtonMouseDown);
			this.ackButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AckButtonMouseUp);
			this.ackButton.MouseLeave += new System.EventHandler(this.AckButtonMouseLeave);
			this.ackButton.EndInit();
			// 
			// resetButton
			// 
			this.resetButton.BeginInit();
			this.resetButton.Name = "resetButton";
			this.resetButton.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.roundRectangle2,
			this.resetLed,
			this.line2});
			this.resetButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResetButtonMouseDown);
			this.resetButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ResetButtonMouseUp);
			this.resetButton.MouseLeave += new System.EventHandler(this.ResetButtonMouseLeave);
			this.resetButton.EndInit();
			// 
			// ellipse2
			// 
			this.ellipse2.Bounds = new NxtControl.Drawing.RectF(((float)(332D)), ((float)(75D)), ((float)(40D)), ((float)(40D)));
			this.ellipse2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))));
			this.ellipse2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ellipse2.Name = "ellipse2";
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(332D)), ((float)(83D)), ((float)(31D)), ((float)(33D)));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(357D, 83D),
			new NxtControl.Drawing.PointF(332D, 110D),
			new NxtControl.Drawing.PointF(338D, 116D),
			new NxtControl.Drawing.PointF(363D, 88D),
			new NxtControl.Drawing.PointF(357D, 83D),
			new NxtControl.Drawing.PointF(357D, 83D),
			new NxtControl.Drawing.PointF(357D, 83D),
			new NxtControl.Drawing.PointF(357D, 83D),
			new NxtControl.Drawing.PointF(357D, 83D),
			new NxtControl.Drawing.PointF(357D, 83D)});
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(341D)), ((float)(83D)), ((float)(31D)), ((float)(33D)));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(347D, 83D),
			new NxtControl.Drawing.PointF(372D, 110D),
			new NxtControl.Drawing.PointF(366D, 116D),
			new NxtControl.Drawing.PointF(341D, 88D),
			new NxtControl.Drawing.PointF(347D, 83D)});
			// 
			// singleSwitch
			// 
			this.singleSwitch.BeginInit();
			this.singleSwitch.Name = "singleSwitch";
			this.singleSwitch.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ellipse2,
			this.polygon1,
			this.polygon2});
			this.singleSwitch.Click += new System.EventHandler(this.ManualSwitchClick);
			this.singleSwitch.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.label1,
			this.label2,
			this.label3,
			this.label4,
			this.stopButton,
			this.roundedRectangle5,
			this.label5,
			this.start_led,
			this.reset_led,
			this.ack_led,
			this.startButton,
			this.ackButton,
			this.resetButton,
			this.singleSwitch});
			this.SymbolSize = new System.Drawing.Size(600, 189);

		}
		private NxtControl.GuiFramework.Group singleSwitch;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Ellipse ellipse2;
		private NxtControl.GuiFramework.RoundedRectangle roundRectangle2;
		private NxtControl.GuiFramework.Group ackButton;
		private NxtControl.GuiFramework.Group startButton;
		private NxtControl.GuiFramework.Group resetButton;
		private System.HMI.Symbols.Base.Execute<bool> ack_led;
		private System.HMI.Symbols.Base.Execute<bool> reset_led;
		private System.HMI.Symbols.Base.Execute<bool> start_led;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Label label5;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle5;
		private NxtControl.GuiFramework.Group stopButton;
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private NxtControl.GuiFramework.RoundedRectangle ackLed;
		private NxtControl.GuiFramework.RoundedRectangle resetLed;
		private NxtControl.GuiFramework.RoundedRectangle startLed;
		private NxtControl.GuiFramework.Label label4;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle4;
		private NxtControl.GuiFramework.Label label3;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle3;
		private NxtControl.GuiFramework.Label label2;
		private NxtControl.GuiFramework.Label label1;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		#endregion
	}
}
