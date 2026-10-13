/*
 * Created by nxtSTUDIO.
 * User: prana
 * Date: 12/30/2019
 * Time: 11:16 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.wtch_trend
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
			this.trend1 = new NxtControl.GuiFramework.Trend();
			this.Water_Level = new System.HMI.Symbols.Base.TextBox<float>();
			this.Water_Temp = new System.HMI.Symbols.Base.TextBox<float>();
			((System.ComponentModel.ISupportInitialize)(this.trend1)).BeginInit();
			// 
			// trend1
			// 
			this.trend1.Location = new System.Drawing.Point(371, 52);
			this.trend1.Name = "trend1";
			this.trend1.ParentSymbol = this;
			this.trend1.Series.Add(new NxtControl.GuiFramework.TrendFastLine("Water_Level", new NxtControl.Drawing.Color(((byte)(255)), ((byte)(127)), ((byte)(71))), false, 0D, 100D, "Left", "", 1, NxtControl.Drawing.DashStyle.Solid, true, "", 100000));
			this.trend1.Series.Add(new NxtControl.GuiFramework.TrendFastLine("Water_Temp", new NxtControl.Drawing.Color(((byte)(129)), ((byte)(202)), ((byte)(219))), false, 0D, 100D, "Left", "", 1, NxtControl.Drawing.DashStyle.Solid, true, "", 100000));
			this.trend1.Size = new System.Drawing.Size(656, 379);
			this.trend1.TabIndex = 0;
			this.trend1.TimeScale = new NxtControl.GuiFramework.TrendTimeScale(true, "HH:mm", false, true);
			this.trend1.TimeSpan = System.TimeSpan.Parse("00:05:00");
			this.trend1.ValueScales.Add(new NxtControl.GuiFramework.TrendValueScale(this.trend1, NxtControl.GuiFramework.TrendValueScaleType.Left, true, "#,##0.##", 0D, 100D, true, "", 0D, 100D, false, false, true));
			this.trend1.ValueScales.Add(new NxtControl.GuiFramework.TrendValueScale(this.trend1, NxtControl.GuiFramework.TrendValueScaleType.Right, true, "#,##0.##", 0D, 0D, false, "", 0D, 100D, false, false, true));
			this.trend1.ZoomPercentX = 10D;
			this.trend1.ZoomPercentY = 10D;
			// 
			// Water_Level
			// 
			this.Water_Level.BeginInit();
			this.Water_Level.AngleIgnore = false;
			this.Water_Level.DesignTransformation = new NxtControl.Drawing.Matrix(0.47333333333333333D, 0D, 0D, 1D, 86D, 115D);
			this.Water_Level.IsOnlyInput = true;
			this.Water_Level.MaximumTag = null;
			this.Water_Level.MinimumTag = null;
			this.Water_Level.Name = "Water_Level";
			this.Water_Level.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.Water_Level.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.Water_Level.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.Water_Level.TagName = "Water_Level";
			this.Water_Level.Value = 0F;
			this.Water_Level.EndInit();
			// 
			// Water_Temp
			// 
			this.Water_Temp.BeginInit();
			this.Water_Temp.AngleIgnore = false;
			this.Water_Temp.DesignTransformation = new NxtControl.Drawing.Matrix(0.47333333333333338D, 0D, 0D, 1D, 185D, 115D);
			this.Water_Temp.IsOnlyInput = true;
			this.Water_Temp.MaximumTag = null;
			this.Water_Temp.MinimumTag = null;
			this.Water_Temp.Name = "Water_Temp";
			this.Water_Temp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.Water_Temp.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.Water_Temp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.Water_Temp.TagName = "Water_Temp";
			this.Water_Temp.Value = 0F;
			this.Water_Temp.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.trend1,
									this.Water_Level,
									this.Water_Temp});
			this.SymbolSize = new System.Drawing.Size(1147, 667);
			((System.ComponentModel.ISupportInitialize)(this.trend1)).EndInit();
		}
		private System.HMI.Symbols.Base.TextBox<float> Water_Temp;
		private System.HMI.Symbols.Base.TextBox<float> Water_Level;
		private NxtControl.GuiFramework.Trend trend1;
		#endregion
	}
}
