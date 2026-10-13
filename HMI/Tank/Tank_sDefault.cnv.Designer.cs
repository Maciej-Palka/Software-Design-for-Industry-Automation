/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 6/20/2016
 * Time: 3:36 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Tank
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sDefault));
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.pipe2 = new NxtControl.GuiFramework.Pipe();
			this.pipe3 = new NxtControl.GuiFramework.Pipe();
			this.roundedRectangle2 = new NxtControl.GuiFramework.RoundedRectangle();
			this.roundedRectangle3 = new NxtControl.GuiFramework.RoundedRectangle();
			this.roundedRectangle4 = new NxtControl.GuiFramework.RoundedRectangle();
			this.svLedON = new NxtControl.GuiFramework.Ellipse();
			this.outLedON = new NxtControl.GuiFramework.Ellipse();
			this.fvLedON = new NxtControl.GuiFramework.Ellipse();
			this.svLedOFF = new NxtControl.GuiFramework.Ellipse();
			this.fvLedOFF = new NxtControl.GuiFramework.Ellipse();
			this.outLedOFF = new NxtControl.GuiFramework.Ellipse();
			this.water = new NxtControl.GuiFramework.Rectangle();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle5 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle6 = new NxtControl.GuiFramework.Rectangle();
			this.attentionSign = new NxtControl.GuiFramework.Rectangle();
			this.label1 = new NxtControl.GuiFramework.Label();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(224)), ((float)(40)), ((float)(200)), ((float)(450)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(200)), ((float)(17)), ((float)(250)), ((float)(500)));
			this.roundedRectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalCenter));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			this.roundedRectangle1.Radius = 20;
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(15)), ((float)(517)), ((float)(271)), ((float)(67)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
									new NxtControl.Drawing.PointF(15, 584),
									new NxtControl.Drawing.PointF(286, 584),
									new NxtControl.Drawing.PointF(286, 517)});
			this.pipe1.Width = 30;
			// 
			// pipe2
			// 
			this.pipe2.Bounds = new NxtControl.Drawing.RectF(((float)(238)), ((float)(513)), ((float)(0)), ((float)(56)));
			this.pipe2.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe2.Name = "pipe2";
			this.pipe2.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe2.Points.AddRange(new NxtControl.Drawing.PointF[] {
									new NxtControl.Drawing.PointF(238, 513),
									new NxtControl.Drawing.PointF(238, 569)});
			// 
			// pipe3
			// 
			this.pipe3.Bounds = new NxtControl.Drawing.RectF(((float)(397)), ((float)(510)), ((float)(246)), ((float)(73)));
			this.pipe3.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe3.Name = "pipe3";
			this.pipe3.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe3.Points.AddRange(new NxtControl.Drawing.PointF[] {
									new NxtControl.Drawing.PointF(397, 510),
									new NxtControl.Drawing.PointF(397, 583),
									new NxtControl.Drawing.PointF(643, 583)});
			this.pipe3.Width = 25;
			// 
			// roundedRectangle2
			// 
			this.roundedRectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(221)), ((float)(526)), ((float)(34)), ((float)(33)));
			this.roundedRectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.roundedRectangle2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle2.Name = "roundedRectangle2";
			this.roundedRectangle2.Radius = 20;
			// 
			// roundedRectangle3
			// 
			this.roundedRectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(265)), ((float)(526)), ((float)(42)), ((float)(33)));
			this.roundedRectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.roundedRectangle3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle3.Name = "roundedRectangle3";
			this.roundedRectangle3.Radius = 20;
			// 
			// roundedRectangle4
			// 
			this.roundedRectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(377)), ((float)(526)), ((float)(39)), ((float)(33)));
			this.roundedRectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.roundedRectangle4.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle4.Name = "roundedRectangle4";
			this.roundedRectangle4.Radius = 20;
			// 
			// svLedON
			// 
			this.svLedON.Bounds = new NxtControl.Drawing.RectF(((float)(230)), ((float)(534)), ((float)(16)), ((float)(16)));
			this.svLedON.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.svLedON.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.svLedON.Name = "svLedON";
			this.svLedON.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// outLedON
			// 
			this.outLedON.Bounds = new NxtControl.Drawing.RectF(((float)(389)), ((float)(534)), ((float)(16)), ((float)(16)));
			this.outLedON.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.outLedON.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.outLedON.Name = "outLedON";
			this.outLedON.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvLedON
			// 
			this.fvLedON.Bounds = new NxtControl.Drawing.RectF(((float)(278)), ((float)(534)), ((float)(16)), ((float)(16)));
			this.fvLedON.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.fvLedON.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.fvLedON.Name = "fvLedON";
			this.fvLedON.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// svLedOFF
			// 
			this.svLedOFF.Bounds = new NxtControl.Drawing.RectF(((float)(230)), ((float)(534)), ((float)(16)), ((float)(16)));
			this.svLedOFF.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(86)), ((byte)(34)), ((byte)(30))));
			this.svLedOFF.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.svLedOFF.Name = "svLedOFF";
			this.svLedOFF.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(86)), ((byte)(34)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvLedOFF
			// 
			this.fvLedOFF.Bounds = new NxtControl.Drawing.RectF(((float)(278)), ((float)(534)), ((float)(16)), ((float)(16)));
			this.fvLedOFF.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(86)), ((byte)(34)), ((byte)(30))));
			this.fvLedOFF.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.fvLedOFF.Name = "fvLedOFF";
			this.fvLedOFF.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(86)), ((byte)(34)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// outLedOFF
			// 
			this.outLedOFF.Bounds = new NxtControl.Drawing.RectF(((float)(389)), ((float)(534)), ((float)(16)), ((float)(16)));
			this.outLedOFF.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(86)), ((byte)(34)), ((byte)(30))));
			this.outLedOFF.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.outLedOFF.Name = "outLedOFF";
			this.outLedOFF.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(86)), ((byte)(34)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// water
			// 
			this.water.Bounds = new NxtControl.Drawing.RectF(((float)(224)), ((float)(40)), ((float)(200)), ((float)(450)));
			this.water.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188))));
			this.water.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.water.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.water.Name = "water";
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(424)), ((float)(360)), ((float)(26)), ((float)(12)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(54)), ((byte)(54)), ((byte)(54))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(424)), ((float)(310)), ((float)(26)), ((float)(12)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(54)), ((byte)(54)), ((byte)(54))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(424)), ((float)(155)), ((float)(26)), ((float)(12)));
			this.rectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(54)), ((byte)(54)), ((byte)(54))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			// 
			// rectangle5
			// 
			this.rectangle5.Bounds = new NxtControl.Drawing.RectF(((float)(424)), ((float)(105)), ((float)(26)), ((float)(12)));
			this.rectangle5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(54)), ((byte)(54)), ((byte)(54))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter));
			this.rectangle5.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle5.Name = "rectangle5";
			// 
			// rectangle6
			// 
			this.rectangle6.Bounds = new NxtControl.Drawing.RectF(((float)(200)), ((float)(477)), ((float)(24)), ((float)(12)));
			this.rectangle6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(54)), ((byte)(54)), ((byte)(54))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalCenter));
			this.rectangle6.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle6.Name = "rectangle6";
			// 
			// attentionSign
			// 
			this.attentionSign.Bounds = new NxtControl.Drawing.RectF(((float)(260)), ((float)(229)), ((float)(128)), ((float)(111)));
			this.attentionSign.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.attentionSign.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.attentionSign.ImageStream = ((System.IO.MemoryStream)(resources.GetObject("attentionSign.ImageStream")));
			this.attentionSign.Name = "attentionSign";
			this.attentionSign.Pen = new NxtControl.Drawing.Pen("Transparent");
			this.attentionSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			// 
			// label1
			// 
			this.label1.AngleIgnore = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label1.Bounds = new NxtControl.Drawing.RectF(((float)(143)), ((float)(39)), ((float)(363)), ((float)(262)));
			this.label1.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.label1.Font = new NxtControl.Drawing.Font("Arial Black", 30F, System.Drawing.FontStyle.Bold);
			this.label1.Name = "label1";
			this.label1.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label1.Text = "TANK RUPTURE!";
			this.label1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.label1.TextAutoSizeHorizontalOffset = 10;
			this.label1.TextColor = new NxtControl.Drawing.Color("AlarmCame");
			this.label1.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.pipe1,
									this.pipe2,
									this.pipe3,
									this.roundedRectangle1,
									this.rectangle1,
									this.roundedRectangle2,
									this.roundedRectangle3,
									this.roundedRectangle4,
									this.svLedON,
									this.outLedON,
									this.fvLedON,
									this.svLedOFF,
									this.fvLedOFF,
									this.outLedOFF,
									this.water,
									this.rectangle2,
									this.rectangle3,
									this.rectangle4,
									this.rectangle5,
									this.rectangle6,
									this.attentionSign,
									this.label1});
			this.SymbolSize = new System.Drawing.Size(651, 620);
		}
		private NxtControl.GuiFramework.Rectangle attentionSign;
		private NxtControl.GuiFramework.Label label1;
		private NxtControl.GuiFramework.Rectangle rectangle6;
		private NxtControl.GuiFramework.Rectangle rectangle5;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle water;
		private NxtControl.GuiFramework.Ellipse outLedOFF;
		private NxtControl.GuiFramework.Ellipse fvLedOFF;
		private NxtControl.GuiFramework.Ellipse svLedOFF;
		private NxtControl.GuiFramework.Ellipse fvLedON;
		private NxtControl.GuiFramework.Ellipse outLedON;
		private NxtControl.GuiFramework.Ellipse svLedON;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle4;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle3;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle2;
		private NxtControl.GuiFramework.Pipe pipe3;
		private NxtControl.GuiFramework.Pipe pipe2;
		private NxtControl.GuiFramework.Pipe pipe1;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		#endregion
	}
}
