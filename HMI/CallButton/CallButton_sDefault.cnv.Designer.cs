/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 6/3/2016
 * Time: 3:38 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.CallButton
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
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.ledOFF = new NxtControl.GuiFramework.Ellipse();
			this.ellipse3 = new NxtControl.GuiFramework.Ellipse();
			this.ledON = new NxtControl.GuiFramework.Ellipse();
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(10)), ((float)(10)), ((float)(36)), ((float)(36)));
			this.ellipse1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.ellipse1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			// 
			// ledOFF
			// 
			this.ledOFF.Bounds = new NxtControl.Drawing.RectF(((float)(14)), ((float)(14)), ((float)(28)), ((float)(28)));
			this.ledOFF.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(86)), ((byte)(34)), ((byte)(30))));
			this.ledOFF.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ledOFF.Name = "ledOFF";
			this.ledOFF.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(86)), ((byte)(34)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ellipse3
			// 
			this.ellipse3.Bounds = new NxtControl.Drawing.RectF(((float)(17)), ((float)(17)), ((float)(22)), ((float)(22)));
			this.ellipse3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))));
			this.ellipse3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ellipse3.Name = "ellipse3";
			this.ellipse3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Ellipse3MouseUp);
			this.ellipse3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Ellipse3MouseDown);
			this.ellipse3.MouseLeave += new System.EventHandler(this.Ellipse3MouseLeave);
			// 
			// ledON
			// 
			this.ledON.Bounds = new NxtControl.Drawing.RectF(((float)(14)), ((float)(14)), ((float)(28)), ((float)(28)));
			this.ledON.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.ledON.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ledON.Name = "ledON";
			this.ledON.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.ellipse1,
									this.ledOFF,
									this.ledON,
									this.ellipse3});
			this.SymbolSize = new System.Drawing.Size(600, 400);
		}
		private NxtControl.GuiFramework.Ellipse ledON;
		private NxtControl.GuiFramework.Ellipse ledOFF;
		private NxtControl.GuiFramework.Ellipse ellipse3;
		private NxtControl.GuiFramework.Ellipse ellipse1;
		#endregion
	}
}
