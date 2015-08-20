using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Drawing;
using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;

namespace HotelManager.General
{
    public class GridViewColumnExtend
    {
        GridView view;
        SkinButtonObjectPainter customButtonPainter;
        EditorButtonObjectInfoArgs args;
        Size buttonSize;

        public GridViewColumnExtend(GridView view)
        {
            this.view = view;
            buttonSize = new Size(14, 14);
            
        }

        public void AddCustomButton() {
            CreateButtonPainter();
            CreateButtonInfoArgs();
            SubscribeToEvents();
        }

        private void CreateButtonInfoArgs() {
            EditorButton btn = new EditorButton(ButtonPredefines.Glyph);
            args = new EditorButtonObjectInfoArgs(btn, new DevExpress.Utils.AppearanceObject());
        }

        private void CreateButtonPainter() {
            customButtonPainter = new SkinButtonObjectPainter(DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveLookAndFeel);
        }

        private void SubscribeToEvents() {
            view.CustomDrawColumnHeader += OnCustomDrawColumnHeader;
            view.CustomDrawFooter += view_CustomDrawFooter;
            view.MouseDown += OnMouseDown;
            view.MouseUp += OnMouseUp;
            view.MouseMove += OnMouseMove;
        }

        void OnMouseUp(object sender, MouseEventArgs e) {
            GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
            if(hitInfo.HitTest != GridHitTest.Column) return;
            GridColumn column = hitInfo.Column;
            if(IsButtonRect(e.Location, column)) {
                SetButtonState(column, ObjectState.Normal);
                XtraMessageBox.Show(string.Format("Custom Button in {0}", column.FieldName));
                // your code here
                DXMouseEventArgs.GetMouseArgs(e).Handled = true;
            }
        }

        void OnMouseMove(object sender, MouseEventArgs e) {
            GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
            if(hitInfo.HitTest != GridHitTest.Column) return;
            GridColumn column = hitInfo.Column;
            if(IsButtonRect(e.Location, column))
                SetButtonState(column, ObjectState.Hot);
            else
                SetButtonState(column, ObjectState.Normal);
        }

        void OnMouseDown(object sender, MouseEventArgs e) {
            GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
            if(hitInfo.HitTest != GridHitTest.Column) return;
            GridColumn column = hitInfo.Column;
            if(IsButtonRect(e.Location, column)) 
                SetButtonState(column, ObjectState.Pressed);
        }

        private void SetButtonState(GridColumn column, ObjectState state) {
            column.Tag = state;
            view.InvalidateColumnHeader(column);
        }

        private bool IsButtonRect(Point point, GridColumn column) {
            GraphicsInfo info = new GraphicsInfo();
            info.AddGraphics(null);
            GridViewInfo viewInfo = view.GetViewInfo() as GridViewInfo;
            GridColumnInfoArgs columnArgs = viewInfo.ColumnsInfo[column];
            Rectangle buttonRect = CalcButtonRect(columnArgs, info.Graphics);
            info.ReleaseGraphics();
            return buttonRect.Contains(point);
        }

        private Rectangle CalcButtonRect(GridColumnInfoArgs columnArgs, Graphics gr) {
            Rectangle columnRect = columnArgs.Bounds;
            int innerElementsWidth = CalcInnerElementsMinWidth(columnArgs, gr);
            Rectangle buttonRect = new Rectangle(columnRect.Right - innerElementsWidth - buttonSize.Width - 2,
                columnRect.Y + columnRect.Height / 2 - buttonSize.Height / 2, buttonSize.Width, buttonSize.Height);
            return buttonRect;
        }

        private int CalcInnerElementsMinWidth(GridColumnInfoArgs columnArgs, Graphics gr) {
            bool canDrawMode = true;
            return columnArgs.InnerElements.CalcMinSize(gr, ref canDrawMode).Width;
        }

        void OnCustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e) {
            if(e.Column == null) return;
            DefaultDrawColumnHeader(e);
            DrawCustomButton(e);
            e.Handled = true;
        }

        private void DrawCustomButton(ColumnHeaderCustomDrawEventArgs e) {
            SetUpButtonInfoArgs(e);
            customButtonPainter.DrawObject(args);
        }

        private void SetUpButtonInfoArgs(ColumnHeaderCustomDrawEventArgs e) {
            args.Cache = e.Cache;
            args.Bounds = CalcButtonRect(e.Info, e.Graphics);
            ObjectState state = ObjectState.Normal;
            if(e.Column.Tag is ObjectState)
                state = (ObjectState)e.Column.Tag;
            args.State = state;
        }

        private static void DefaultDrawColumnHeader(ColumnHeaderCustomDrawEventArgs e) {
            e.Painter.DrawObject(e.Info);
        }

        private void UnsubscribeFromEvents() {
            view.CustomDrawColumnHeader -= OnCustomDrawColumnHeader;
            view.MouseDown -= OnMouseDown;
            view.MouseUp -= OnMouseUp;
            view.MouseMove -= OnMouseMove;
        }

        public void RemoveCustomButton() {
            UnsubscribeFromEvents();

        }



        public void DrawCustomButton(DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            SetUpButtonInfoArgs(e);
            customButtonPainter.DrawObject(args);
            StringFormat f = new StringFormat();
            //calc text bounds here
            Rectangle textBounds = args.Bounds;
            textBounds.Inflate(-3, -3);
            int imageWidth = 12;
            int imageHeight = 12;
            customButtonPainter.DrawCaption(args, "Your Text", e.Appearance.Font, customButtonPainter.GetForeBrush(args), textBounds, f);
            e.Graphics.DrawImage(new Bitmap(@"E:\SEMESTER_8\OOAD\Hotel-Manager\trunk\Technical\HotelManager\Resources\1438116541_hotel1.png"), new Rectangle(args.Bounds.Right - imageWidth - 5, args.Bounds.Y + 3, imageWidth, imageHeight));
            customButtonPainter.DrawElementInfoBitmap(args);
            customButtonPainter.DrawElementIntoBitmap(args, ObjectState.Normal);
        }

        private void SetUpButtonInfoArgs(DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            args.Cache = e.Cache;
            ObjectState state = ObjectState.Normal;
            args.State = state;
        }

        void view_CustomDrawFooter(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
        {
            DrawCustomButton(e);
        }
    }
}
