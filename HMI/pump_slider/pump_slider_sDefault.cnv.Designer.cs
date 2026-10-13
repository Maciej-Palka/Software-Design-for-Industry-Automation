/*
 * Created by nxtSTUDIO.
 * User: prana
 * Date: 12/30/2019
 * Time: 10:58 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.pump_slider
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
			this.Heat_Value = new System.HMI.Symbols.Base.TrackerVertical<float>();
			this.Label = new System.HMI.Symbols.Base.Label();
			this.Pump_Value = new System.HMI.Symbols.Base.TextBox<float>();
			// 
			// Heat_Value
			// 
			this.Heat_Value.BeginInit();
			this.Heat_Value.AngleIgnore = false;
			this.Heat_Value.Brush = new NxtControl.Drawing.Brush("TrackerBrush");
			this.Heat_Value.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 0.68333333333333324D, 104D, 42D);
			this.Heat_Value.Font = new NxtControl.Drawing.Font("TrackerFont");
			this.Heat_Value.Maximum = 200F;
			this.Heat_Value.MaximumTag = null;
			this.Heat_Value.Minimum = 0F;
			this.Heat_Value.MinimumTag = null;
			this.Heat_Value.MouseMoveValueThreshold = 0D;
			this.Heat_Value.Name = "Heat_Value";
			this.Heat_Value.Pen = new NxtControl.Drawing.Pen("TrackerPen");
			this.Heat_Value.Radius = 20D;
			this.Heat_Value.TagName = "Pump_Value";
			this.Heat_Value.TickLength = 5;
			this.Heat_Value.TrackHandleSize = 28;
			this.Heat_Value.TrackLineDisabledBrush = new NxtControl.Drawing.Brush("TrackerLineDisabledBrush");
			this.Heat_Value.EndInit();
			// 
			// Label
			// 
			this.Label.BeginInit();
			this.Label.AngleIgnore = false;
			this.Label.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label.DesignTransformation = new NxtControl.Drawing.Matrix(0.86D, 0D, 0D, 0.80952380952380953D, 64D, 262D);
			this.Label.FontScale = false;
			this.Label.IsOnlyInput = true;
			this.Label.Name = "Label";
			this.Label.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.Label.TagName = "Label";
			this.Label.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.LabelValueChanged);
			this.Label.EndInit();
			// 
			// Pump_Value
			// 
			this.Pump_Value.BeginInit();
			this.Pump_Value.AngleIgnore = false;
			this.Pump_Value.DesignTransformation = new NxtControl.Drawing.Matrix(0.31333333333333335D, 0D, 0D, 1D, 168D, 135D);
			this.Pump_Value.MaximumTag = null;
			this.Pump_Value.MinimumTag = null;
			this.Pump_Value.Name = "Pump_Value";
			this.Pump_Value.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.Pump_Value.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.Pump_Value.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.Pump_Value.TagName = "Pump_Value";
			this.Pump_Value.Value = 0F;
			this.Pump_Value.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.Heat_Value,
									this.Label,
									this.Pump_Value});
			this.SymbolSize = new System.Drawing.Size(600, 400);
		}
		private System.HMI.Symbols.Base.TextBox<float> Pump_Value;
		private System.HMI.Symbols.Base.Label Label;
		private System.HMI.Symbols.Base.TrackerVertical<float> Heat_Value;
		#endregion
	}
}
