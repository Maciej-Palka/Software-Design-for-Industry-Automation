/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 6/3/2016
 * Time: 10:37 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Door
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
			this.DoorLeft = new NxtControl.GuiFramework.Rectangle();
			this.DoorRight = new NxtControl.GuiFramework.Rectangle();
			this.DoorPosition = new System.HMI.Symbols.Base.Execute<float>();
			// 
			// DoorLeft
			// 
			this.DoorLeft.Bounds = new NxtControl.Drawing.RectF(((float)(70)), ((float)(50)), ((float)(50)), ((float)(120)));
			this.DoorLeft.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(2)), ((byte)(178)), ((byte)(238))));
			this.DoorLeft.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.DoorLeft.Name = "DoorLeft";
			this.DoorLeft.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188))), 4F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// DoorRight
			// 
			this.DoorRight.Bounds = new NxtControl.Drawing.RectF(((float)(123)), ((float)(50)), ((float)(50)), ((float)(120)));
			this.DoorRight.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(2)), ((byte)(178)), ((byte)(238))));
			this.DoorRight.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.DoorRight.Name = "DoorRight";
			this.DoorRight.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188))), 4F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// DoorPosition
			// 
			this.DoorPosition.BeginInit();
			this.DoorPosition.AngleIgnore = false;
			this.DoorPosition.DesignTransformation = new NxtControl.Drawing.Matrix(1, 0, 0, 1, 88, 265);
			this.DoorPosition.IsOnlyInput = true;
			this.DoorPosition.Name = "DoorPosition";
			this.DoorPosition.TagName = "DoorPosition";
			this.DoorPosition.Value = 0F;
			this.DoorPosition.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DoorPositionValueChanged);
			this.DoorPosition.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.DoorLeft,
									this.DoorRight,
									this.DoorPosition});
			this.SymbolSize = new System.Drawing.Size(600, 400);
		}
		private NxtControl.GuiFramework.Rectangle DoorLeft;
		private NxtControl.GuiFramework.Rectangle DoorRight;
		private System.HMI.Symbols.Base.Execute<System.Single> DoorPosition;
		#endregion
	}
}
