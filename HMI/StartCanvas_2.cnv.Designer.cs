/* StartCanvas.cnv.Designer.cs */
/* =====================================================================$
 * Copyright (c) 2007-2015 nxtControl GesmbH.  All rights reserved.
 * The contents of this file is subject to confidentiality.
 *
 * =====================================================================$
 */

/*
 * Created by HMI.Main.
 * User: kovaivo
 * Date: 18.09.2008
 * Time: 17:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
  /// <summary>
  /// Summary description for StartCanvas_2.
  /// </summary>
  partial class StartCanvas_2
  {
    #region Component Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartCanvas_2));
      this.logo = new NxtControl.GuiFramework.Rectangle();
      this.canvasTopologyRose = new NxtControl.GuiFramework.CanvasTopologyRose();      
      this.canvasTopologySeparator1 = new NxtControl.GuiFramework.CanvasTopologySeparator();      
      this.canvasTopologySeparator2 = new NxtControl.GuiFramework.CanvasTopologySeparator();      
      this.workArea = new NxtControl.GuiFramework.WorkAreaControl();
      
      this.header1 = new NxtControl.GuiFramework.Rectangle();
this.siblingsPanel = new NxtControl.GuiFramework.CanvasTopologyPanel();
this.childrenPanel = new NxtControl.GuiFramework.CanvasTopologyPanel();
this.exit1 = new NxtControl.GuiFramework.Exit();
this.login1 = new NxtControl.GuiFramework.Login();
this.language1 = new NxtControl.GuiFramework.LanguageSwitcher();
this.currentUser1 = new NxtControl.GuiFramework.CurrentUser();

      // 
      // logo
      //
      this.logo.Anchor = NxtControl.Drawing.AnchorStyles.Left; 
      this.logo.Bounds = new NxtControl.Drawing.RectF(((float)(0)), ((float)(0)), ((float)(119)), ((float)(80)));
      this.logo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
      this.logo.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
      this.logo.ImageStream = ((System.IO.MemoryStream)(resources.GetObject("logo.ImageStream")));
      this.logo.Name = "logo";
      this.logo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
      this.logo.TextColor = new NxtControl.Drawing.Color("Black");
      // 
      // canvasTopologySeparator1
      //
      this.canvasTopologySeparator1.Anchor = NxtControl.Drawing.AnchorStyles.Left; 
      this.canvasTopologySeparator1.Bounds = new NxtControl.Drawing.RectF(((float)(119)), ((float)(0)), ((float)(2)), ((float)(80)));
      this.canvasTopologySeparator1.Name = "canvasTopologySeparator1";
      this.canvasTopologySeparator1.LookAndFeel = "Theme";
      this.canvasTopologySeparator1.Visible = true;
      // 
      // canvasTopologySeparator2
      //
      this.canvasTopologySeparator2.Anchor = NxtControl.Drawing.AnchorStyles.Left; 
      this.canvasTopologySeparator2.Bounds = new NxtControl.Drawing.RectF(((float)(470)), ((float)(0)), ((float)(2)), ((float)(80)));
      this.canvasTopologySeparator2.Name = "canvasTopologySeparator2";
      this.canvasTopologySeparator2.LookAndFeel = "Theme";
      this.canvasTopologySeparator2.Visible = true;
      // 
      // canvasTopologyRose
      // 
      this.canvasTopologyRose.BeginInit();
      this.canvasTopologyRose.Bounds = new NxtControl.Drawing.RectF(((float)(119)), ((float)(0)), ((float)(80)), ((float)(80)));
      this.canvasTopologyRose.Color = new NxtControl.Drawing.Color((byte) 255 , (byte) 255, (byte) 0);
      this.canvasTopologyRose.Name = "canvasTopologyRose";
      this.canvasTopologyRose.Transformation = new NxtControl.Drawing.Matrix(0.879120879120879, 0, 0, 0.919540229885057, 111.967032967033, -1.83908045977011);
      this.canvasTopologyRose.LookAndFeel = "Theme";
      this.canvasTopologyRose.EndInit();
      // 
      // workArea
      // 
      this.workArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                  | System.Windows.Forms.AnchorStyles.Left) 
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.workArea.AutoScroll = true;
      this.workArea.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.workArea.Location = new System.Drawing.Point(0, 80);
      this.workArea.Name = "workArea";
      this.workArea.RuntimeMode = true;
      this.workArea.Size = new System.Drawing.Size(590, 600);
      this.workArea.TabIndex = 0;
      this.workArea.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
      
      // 
      // header1
      // 
      this.header1.Anchor = ((NxtControl.Drawing.AnchorStyles)((NxtControl.Drawing.AnchorStyles.Left | NxtControl.Drawing.AnchorStyles.Right)));
      this.header1.Bounds = new NxtControl.Drawing.RectF(((float)(0)), ((float)(0)), ((float)(590)), ((float)(80)));
      this.header1.Name = "header1";
      this.header1.Brush = NxtControl.Drawing.Brush.FromName("CanvasTopologyHeaderBrush");
      this.header1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
    //
    // siblingsPanel
    //
    this.siblingsPanel.BeginInit();
    this.siblingsPanel.Anchor = ((NxtControl.Drawing.AnchorStyles)((NxtControl.Drawing.AnchorStyles.Left | NxtControl.Drawing.AnchorStyles.Right)));
    this.siblingsPanel.Bounds = new NxtControl.Drawing.RectF(((float)(199)), ((float)(0)), ((float)(271)), ((float)(80)));
    this.siblingsPanel.BtnColor = new NxtControl.Drawing.Color((byte) 255 , (byte) 255, (byte) 0);
    this.siblingsPanel.CurrentBtnColor = new NxtControl.Drawing.Color((byte) 255 , (byte) 255, (byte) 0);
    this.siblingsPanel.TopologyType = NxtControl.GuiFramework.CanvasTopologyType.Sibling;
    this.siblingsPanel.LookAndFeel = "Theme";
    this.siblingsPanel.BtnHeight = 30;
    this.siblingsPanel.BtnWidth = 140;
    this.siblingsPanel.Name = "siblingsPanel";
    this.siblingsPanel.WorkArea = workArea;
    this.siblingsPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
    this.siblingsPanel.EndInit();
    //
    // childrenPanel
    //
    this.childrenPanel.BeginInit();
    this.childrenPanel.Anchor = ((NxtControl.Drawing.AnchorStyles)((NxtControl.Drawing.AnchorStyles.Left | NxtControl.Drawing.AnchorStyles.Right)));
    this.childrenPanel.Bounds = new NxtControl.Drawing.RectF(((float)(199)), ((float)(39)), ((float)(271)), ((float)(80)));
    this.childrenPanel.BtnColor = new NxtControl.Drawing.Color((byte) 255 , (byte) 255, (byte) 0);
    this.childrenPanel.CurrentBtnColor = new NxtControl.Drawing.Color((byte) 255 , (byte) 255, (byte) 0);
    this.childrenPanel.TopologyType = NxtControl.GuiFramework.CanvasTopologyType.Child;
    this.childrenPanel.LookAndFeel = "Theme";
    this.childrenPanel.BtnHeight = 30;
    this.childrenPanel.BtnWidth = 140;
    this.childrenPanel.Name = "childrenPanel";
    this.childrenPanel.WorkArea = workArea;
    this.childrenPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
    this.childrenPanel.EndInit();
			// 
      // exit1
      // 
      this.exit1.Anchor = NxtControl.Drawing.AnchorStyles.Right;
      this.exit1.Bounds = new NxtControl.Drawing.RectF(((float)(550)), ((float)(0)), ((float)(40)), ((float)(40)));
      this.exit1.Text = "";
      this.exit1.Radius = 0;
      this.exit1.LookAndFeel = "Theme";
      this.exit1.Name = "exit1";
      this.exit1.Warning = true;
      this.exit1.WarningText = "";
			// 
      // login1
      // 
      this.login1.Anchor = NxtControl.Drawing.AnchorStyles.Right;
      this.login1.Bounds = new NxtControl.Drawing.RectF(((float)(470)), ((float)(0)), ((float)(40)), ((float)(40)));
      this.login1.Text = "";
      this.login1.Radius = 0;
      this.login1.LookAndFeel = "Theme";
      this.login1.Name = "login1";
			// 
      // language1
      // 
      this.language1.Anchor = NxtControl.Drawing.AnchorStyles.Right;
      this.language1.Bounds = new NxtControl.Drawing.RectF(((float)(510)), ((float)(0)), ((float)(40)), ((float)(40)));
      this.language1.LookAndFeel = "Theme";
      this.language1.Name = "language1";
			// 
      // currentUser1
      // 
      this.currentUser1.Anchor = NxtControl.Drawing.AnchorStyles.Right;
      this.currentUser1.AngleIgnore = true;
      this.currentUser1.Bounds = new NxtControl.Drawing.RectF(((float)(490)), ((float)(40)), ((float)(100)), ((float)(40)));
      this.currentUser1.Brush = new NxtControl.Drawing.Brush();
      this.currentUser1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
      this.currentUser1.LookAndFeel = "Theme";
      this.currentUser1.Name = "currentUser1";
      this.currentUser1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
      this.currentUser1.Text = "currentUser1";
      this.currentUser1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
      this.currentUser1.TextColor = new NxtControl.Drawing.Color("White");

      // 
      // StartCanvas_2
      // 
      this.Bounds = new NxtControl.Drawing.RectF(((float)(0)), ((float)(0)), ((float)(590)), ((float)(680)));
      this.Name = "StartCanvas_2";
      this.ResizeBehavior = NxtControl.GuiFramework.ResizeBehavior.None;
      this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
                  this.header1,

                  this.logo,
                  this.canvasTopologyRose,
                        siblingsPanel,
      childrenPanel,
      exit1,
      login1,
      language1,
      currentUser1,

                  this.canvasTopologySeparator1,
				  this.canvasTopologySeparator2,
				  this.workArea});
      this.Size = new System.Drawing.Size(590, 680);
    }
    
    private NxtControl.GuiFramework.Rectangle header1;
			private NxtControl.GuiFramework.CanvasTopologyPanel siblingsPanel;
			private NxtControl.GuiFramework.CanvasTopologyPanel childrenPanel;
private NxtControl.GuiFramework.Exit exit1;
private NxtControl.GuiFramework.Login login1;
private NxtControl.GuiFramework.LanguageSwitcher language1;
private NxtControl.GuiFramework.CurrentUser currentUser1;

    private NxtControl.GuiFramework.WorkAreaControl workArea;
    private NxtControl.GuiFramework.CanvasTopologyRose canvasTopologyRose;
    private NxtControl.GuiFramework.CanvasTopologySeparator canvasTopologySeparator1;
    private NxtControl.GuiFramework.CanvasTopologySeparator canvasTopologySeparator2;
    private NxtControl.GuiFramework.Rectangle logo;
    #endregion
  }
}
