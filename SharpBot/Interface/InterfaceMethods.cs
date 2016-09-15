using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpBot.Interface
{
    public static class InterfaceMethods
    {

        public static void DrawColumnHeader_DrawCenteredColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            ListView list = (ListView)sender;
            ColumnHeader ch = list.Columns[e.ColumnIndex];
            HorizontalAlignment colHal = ch.TextAlign;
            HorizontalAlignment headHal = colHal;

            headHal = HorizontalAlignment.Center;

            SizeF size = e.Graphics.MeasureString(ch.Text, e.Font);

            float x =
                headHal == HorizontalAlignment.Center ? (e.Bounds.Width - size.Width) / 2f :
                headHal == HorizontalAlignment.Right ? (e.Bounds.Width - size.Width) : 0f;

            e.DrawBackground();

            using (SolidBrush brush = new SolidBrush(e.ForeColor))
                e.Graphics.DrawString(ch.Text, e.Font, brush,
                                      e.Bounds.X + x, 5f, StringFormat.GenericDefault);
        }

        public static void ColumnWidthChanging_UnresizeableColumHeader(object sender, ColumnWidthChangingEventArgs e)
        {
            var list = (ListView) sender;
            e.NewWidth = list.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }


    }
}
