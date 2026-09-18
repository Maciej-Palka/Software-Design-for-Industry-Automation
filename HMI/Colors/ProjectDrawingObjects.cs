namespace NxtControl.Drawing {
    
    
    public class ProjectBrushes {
        
        public static NxtControl.Drawing.Brush Transparent;
        
        public static NxtControl.Drawing.Brush Black;
        
        public static NxtControl.Drawing.Brush White;
        
        public static NxtControl.Drawing.Brush TrackerLineBrush;
        
        public static NxtControl.Drawing.Brush TrackerLineDisabledBrush;
        
        public static NxtControl.Drawing.Brush RoundKnobBrush;
        
        public static NxtControl.Drawing.Brush GroupBoxBrush;
        
        public static NxtControl.Drawing.Brush TextBoxBrush;
        
        public static NxtControl.Drawing.Brush CanvasBrush;
        
        public static NxtControl.Drawing.Brush RuntimeConnectionBrush;
        
        public static NxtControl.Drawing.Brush LogStateBrush;
        
        public static NxtControl.Drawing.Brush TrackerHandleBrush;
        
        public static NxtControl.Drawing.Brush ButtonFalseBrush;
        
        public static NxtControl.Drawing.Brush ButtonTrueBrush;
        
        public static NxtControl.Drawing.Brush ButtonBrush;
        
        public static NxtControl.Drawing.Brush ButtonSwitchBackgroundBrush;
        
        public static NxtControl.Drawing.Brush TrackerBrush;
        
        public static NxtControl.Drawing.Brush TrackerLineBackgroundBrush;
        
        public static NxtControl.Drawing.Brush TrackerHandleDisabledBrush;
        
        public static NxtControl.Drawing.Brush TextBoxReadOnlyBrush;
        
        public static NxtControl.Drawing.Brush ButtonSwitchBrush;
        
        public static NxtControl.Drawing.Brush CheckBoxBrush;
        
        public static NxtControl.Drawing.Brush CanvasTopologyButtonBrush;
        
        public static NxtControl.Drawing.Brush CanvasTopologyButtonCurrentBrush;
        
        public static NxtControl.Drawing.Brush CanvasTopologyRoseBrush;
        
        public static NxtControl.Drawing.Brush CanvasTopologyHeaderBrush;
        
        public static NxtControl.Drawing.Brush CanvasTopologySeparatorBrush;
        
        public static NxtControl.Drawing.Brush ComboBoxArrowBackBrush;
        
        public static NxtControl.Drawing.Brush ComboBoxArrowBackDisabledBrush;
        
        public static NxtControl.Drawing.Brush ComboBoxBrush;
        
        public static NxtControl.Drawing.Brush ComboBoxDisabledBrush;
        
        public static NxtControl.Drawing.Brush FaceplateBrush;
        
        public static NxtControl.Drawing.Brush FpStyleRectangularHandleBrush;
        
        public static NxtControl.Drawing.Brush FpStyleRoundHandleBrush;
        
        public static NxtControl.Drawing.Brush LabelBrush;
        
        public static NxtControl.Drawing.Brush ButtonPushedBrush;
        
        public static NxtControl.Drawing.Brush LedColor;
        
        static ProjectBrushes() {
            Transparent = NxtControl.Drawing.SystemBrushes.Transparent;
            Black = NxtControl.Drawing.SystemBrushes.Black;
            White = NxtControl.Drawing.SystemBrushes.White;
            TrackerLineBrush = NxtControl.Drawing.SystemBrushes.TrackerLineBrush;
            TrackerLineDisabledBrush = NxtControl.Drawing.SystemBrushes.TrackerLineDisabledBrush;
            RoundKnobBrush = NxtControl.Drawing.SystemBrushes.RoundKnobBrush;
            GroupBoxBrush = NxtControl.Drawing.SystemBrushes.GroupBoxBrush;
            TextBoxBrush = NxtControl.Drawing.SystemBrushes.TextBoxBrush;
            CanvasBrush = NxtControl.Drawing.SystemBrushes.CanvasBrush;
            RuntimeConnectionBrush = NxtControl.Drawing.SystemBrushes.RuntimeConnectionBrush;
            LogStateBrush = NxtControl.Drawing.SystemBrushes.LogStateBrush;
            TrackerHandleBrush = new NxtControl.Drawing.Brush("TrackerHandleBrush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(230)), ((byte)(230))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalTop, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
                                    new NxtControl.Drawing.Color(((byte)(248)), ((byte)(248)), ((byte)(248))),
                                    new NxtControl.Drawing.Color(((byte)(232)), ((byte)(232)), ((byte)(232)))}, new float[] {
                                    0F,
                                    1F}))), NxtControl.Drawing.DrawingObjectType.Project);
            ButtonFalseBrush = new NxtControl.Drawing.Brush("ButtonFalseBrush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)))), NxtControl.Drawing.DrawingObjectType.Project);
            ButtonTrueBrush = new NxtControl.Drawing.Brush("ButtonTrueBrush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(168)), ((byte)(231)))), NxtControl.Drawing.DrawingObjectType.Project);
            ButtonBrush = new NxtControl.Drawing.Brush("ButtonBrush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90)))), NxtControl.Drawing.DrawingObjectType.Project);
            ButtonSwitchBackgroundBrush = new NxtControl.Drawing.Brush("ButtonSwitchBackgroundBrush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(185)), ((byte)(185)), ((byte)(185)))), NxtControl.Drawing.DrawingObjectType.Project);
            TrackerBrush = new NxtControl.Drawing.Brush("TrackerBrush", new NxtControl.Drawing.Brush(), NxtControl.Drawing.DrawingObjectType.Project);
            TrackerLineBackgroundBrush = new NxtControl.Drawing.Brush("TrackerLineBackgroundBrush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(215)), ((byte)(215)), ((byte)(215)))), NxtControl.Drawing.DrawingObjectType.Project);
            TrackerHandleDisabledBrush = new NxtControl.Drawing.Brush("TrackerHandleDisabledBrush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(180)), ((byte)(180)), ((byte)(180))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalTop, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
                                    new NxtControl.Drawing.Color(((byte)(180)), ((byte)(180)), ((byte)(180))),
                                    new NxtControl.Drawing.Color(((byte)(180)), ((byte)(180)), ((byte)(180)))}, new float[] {
                                    0F,
                                    1F}))), NxtControl.Drawing.DrawingObjectType.Project);
            TextBoxReadOnlyBrush = new NxtControl.Drawing.Brush("TextBoxReadOnlyBrush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(220)), ((byte)(220)), ((byte)(220)))), NxtControl.Drawing.DrawingObjectType.Project);
            ButtonSwitchBrush = new NxtControl.Drawing.Brush("ButtonSwitchBrush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)))), NxtControl.Drawing.DrawingObjectType.Project);
            CheckBoxBrush = new NxtControl.Drawing.Brush("CheckBoxBrush", new NxtControl.Drawing.Brush(), NxtControl.Drawing.DrawingObjectType.Project);
            CanvasTopologyButtonBrush = new NxtControl.Drawing.Brush("CanvasTopologyButtonBrush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(230)), ((byte)(230))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalTop, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
                                    new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))),
                                    new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235)))}, new float[] {
                                    0F,
                                    1F}))), NxtControl.Drawing.DrawingObjectType.Project);
            CanvasTopologyButtonCurrentBrush = new NxtControl.Drawing.Brush("CanvasTopologyButtonCurrentBrush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(168)), ((byte)(231)))), NxtControl.Drawing.DrawingObjectType.Project);
            CanvasTopologyRoseBrush = new NxtControl.Drawing.Brush("CanvasTopologyRoseBrush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(230)), ((byte)(230))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalTop, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
                                    new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))),
                                    new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235)))}, new float[] {
                                    0F,
                                    1F}))), NxtControl.Drawing.DrawingObjectType.Project);
            CanvasTopologyHeaderBrush = new NxtControl.Drawing.Brush("CanvasTopologyHeaderBrush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(230)), ((byte)(230))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalTop, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
                                    new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))),
                                    new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235)))}, new float[] {
                                    0F,
                                    1F}))), NxtControl.Drawing.DrawingObjectType.Project);
            CanvasTopologySeparatorBrush = new NxtControl.Drawing.Brush("CanvasTopologySeparatorBrush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(30)), ((byte)(30)), ((byte)(30))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.HorizontalRight, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
                                    new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))),
                                    new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))),
                                    new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))),
                                    new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200)))}, new float[] {
                                    0F,
                                    0.5F,
                                    0.51F,
                                    1F}))), NxtControl.Drawing.DrawingObjectType.Project);
            ComboBoxArrowBackBrush = new NxtControl.Drawing.Brush("ComboBoxArrowBackBrush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(230)), ((byte)(230))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalTop, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
                                    new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))),
                                    new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235)))}, new float[] {
                                    0F,
                                    1F}))), NxtControl.Drawing.DrawingObjectType.Project);
            ComboBoxArrowBackDisabledBrush = new NxtControl.Drawing.Brush("ComboBoxArrowBackDisabledBrush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(230)), ((byte)(230))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalTop, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
                                    new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))),
                                    new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235)))}, new float[] {
                                    0F,
                                    1F}))), NxtControl.Drawing.DrawingObjectType.Project);
            ComboBoxBrush = new NxtControl.Drawing.Brush("ComboBoxBrush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("ComboBoxBackColor")), NxtControl.Drawing.DrawingObjectType.Project);
            ComboBoxDisabledBrush = new NxtControl.Drawing.Brush("ComboBoxDisabledBrush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(220)), ((byte)(220)), ((byte)(220)))), NxtControl.Drawing.DrawingObjectType.Project);
            FaceplateBrush = new NxtControl.Drawing.Brush("FaceplateBrush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("FaceplateBackColor")), NxtControl.Drawing.DrawingObjectType.Project);
            FpStyleRectangularHandleBrush = new NxtControl.Drawing.Brush("FpStyleRectangularHandleBrush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(230)), ((byte)(230))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalTop, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
                                    new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))),
                                    new NxtControl.Drawing.Color(((byte)(140)), ((byte)(140)), ((byte)(140)))}, new float[] {
                                    0F,
                                    1F}))), NxtControl.Drawing.DrawingObjectType.Project);
            FpStyleRoundHandleBrush = new NxtControl.Drawing.Brush("FpStyleRoundHandleBrush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(230)), ((byte)(230))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalTop, new NxtControl.Drawing.GradientFillColorBlend(new NxtControl.Drawing.Color[] {
                                    new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))),
                                    new NxtControl.Drawing.Color(((byte)(140)), ((byte)(140)), ((byte)(140)))}, new float[] {
                                    0F,
                                    1F}))), NxtControl.Drawing.DrawingObjectType.Project);
            LabelBrush = new NxtControl.Drawing.Brush("LabelBrush", new NxtControl.Drawing.Brush(), NxtControl.Drawing.DrawingObjectType.Project);
            ButtonPushedBrush = new NxtControl.Drawing.Brush("ButtonPushedBrush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(168)), ((byte)(230)))), NxtControl.Drawing.DrawingObjectType.Project);
            LedColor = new NxtControl.Drawing.Brush("LedColor", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90)))), NxtControl.Drawing.DrawingObjectType.Project);
        }
    }
    
    public class ProjectPens {
        
        public static NxtControl.Drawing.Pen Transparent;
        
        public static NxtControl.Drawing.Pen Black;
        
        public static NxtControl.Drawing.Pen White;
        
        public static NxtControl.Drawing.Pen GroupBoxPen;
        
        public static NxtControl.Drawing.Pen LabelPen;
        
        public static NxtControl.Drawing.Pen ButtonPen;
        
        public static NxtControl.Drawing.Pen CanvasTopologyButtonPen;
        
        public static NxtControl.Drawing.Pen TrackerHandlePen;
        
        public static NxtControl.Drawing.Pen TrackerLinePen;
        
        public static NxtControl.Drawing.Pen TrackerPen;
        
        public static NxtControl.Drawing.Pen RoundKnobPen;
        
        public static NxtControl.Drawing.Pen TextBoxPen;
        
        public static NxtControl.Drawing.Pen ComboBoxPen;
        
        static ProjectPens() {
            Transparent = NxtControl.Drawing.SystemPens.Transparent;
            Black = NxtControl.Drawing.SystemPens.Black;
            White = NxtControl.Drawing.SystemPens.White;
            GroupBoxPen = NxtControl.Drawing.SystemPens.GroupBoxPen;
            LabelPen = NxtControl.Drawing.SystemPens.LabelPen;
            ButtonPen = new NxtControl.Drawing.Pen("ButtonPen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid), NxtControl.Drawing.DrawingObjectType.Project);
            CanvasTopologyButtonPen = new NxtControl.Drawing.Pen("CanvasTopologyButtonPen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(220)), ((byte)(220)), ((byte)(220))), 1F, NxtControl.Drawing.DashStyle.Solid), NxtControl.Drawing.DrawingObjectType.Project);
            TrackerHandlePen = new NxtControl.Drawing.Pen("TrackerHandlePen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid), NxtControl.Drawing.DrawingObjectType.Project);
            TrackerLinePen = new NxtControl.Drawing.Pen("TrackerLinePen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid), NxtControl.Drawing.DrawingObjectType.Project);
            TrackerPen = new NxtControl.Drawing.Pen("TrackerPen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid), NxtControl.Drawing.DrawingObjectType.Project);
            RoundKnobPen = new NxtControl.Drawing.Pen("RoundKnobPen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("White"), 1F, NxtControl.Drawing.DashStyle.Solid), NxtControl.Drawing.DrawingObjectType.Project);
            TextBoxPen = new NxtControl.Drawing.Pen("TextBoxPen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("TextBoxPenColor"), 0F, NxtControl.Drawing.DashStyle.Solid), NxtControl.Drawing.DrawingObjectType.Project);
            ComboBoxPen = new NxtControl.Drawing.Pen("ComboBoxPen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("ComboBoxPenColor"), 0F, NxtControl.Drawing.DashStyle.Solid), NxtControl.Drawing.DrawingObjectType.Project);
        }
    }
    
    public class ProjectFonts {
        
        public static NxtControl.Drawing.Font SansSerif;
        
        public static NxtControl.Drawing.Font RoundKnobValueFont;
        
        public static NxtControl.Drawing.Font LabelFont;
        
        public static NxtControl.Drawing.Font CanvasTopologyButtonFont;
        
        public static NxtControl.Drawing.Font BigCanvasTopologyButtonFont;
        
        public static NxtControl.Drawing.Font HeaderFont;
        
        public static NxtControl.Drawing.Font ButtonFont;
        
        public static NxtControl.Drawing.Font CheckBoxFont;
        
        public static NxtControl.Drawing.Font RoundKnobFont;
        
        public static NxtControl.Drawing.Font TextBoxFont;
        
        public static NxtControl.Drawing.Font ComboBoxFont;
        
        public static NxtControl.Drawing.Font TrackerValueFont;
        
        public static NxtControl.Drawing.Font TrackerFont;
        
        static ProjectFonts() {
            SansSerif = NxtControl.Drawing.SystemFonts.SansSerif;
            RoundKnobValueFont = NxtControl.Drawing.SystemFonts.RoundKnobValueFont;
            LabelFont = NxtControl.Drawing.SystemFonts.LabelFont;
            CanvasTopologyButtonFont = NxtControl.Drawing.SystemFonts.CanvasTopologyButtonFont;
            BigCanvasTopologyButtonFont = NxtControl.Drawing.SystemFonts.BigCanvasTopologyButtonFont;
            HeaderFont = NxtControl.Drawing.SystemFonts.HeaderFont;
            ButtonFont = new NxtControl.Drawing.Font("ButtonFont", new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold), NxtControl.Drawing.DrawingObjectType.Project);
            CheckBoxFont = new NxtControl.Drawing.Font("CheckBoxFont", new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold), NxtControl.Drawing.DrawingObjectType.Project);
            RoundKnobFont = new NxtControl.Drawing.Font("RoundKnobFont", new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular), NxtControl.Drawing.DrawingObjectType.Project);
            TextBoxFont = new NxtControl.Drawing.Font("TextBoxFont", new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular), NxtControl.Drawing.DrawingObjectType.Project);
            ComboBoxFont = new NxtControl.Drawing.Font("ComboBoxFont", new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular), NxtControl.Drawing.DrawingObjectType.Project);
            TrackerValueFont = new NxtControl.Drawing.Font("TrackerValueFont", new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular), NxtControl.Drawing.DrawingObjectType.Project);
            TrackerFont = new NxtControl.Drawing.Font("TrackerFont", new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular), NxtControl.Drawing.DrawingObjectType.Project);
        }
    }
}
