using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedStrokeTextBox : TextBox
{
    public RoundedStrokeTextBox()
    {
        this.BorderStyle = BorderStyle.None;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Criar um gráfico com bordas arredondadas
        using (GraphicsPath path = new GraphicsPath())
        {
            int radius = 10; // Raio do arredondamento das bordas

            // Definir os pontos do retângulo com bordas arredondadas
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90); // Canto superior esquerdo
            path.AddArc(this.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90); // Canto superior direito
            path.AddArc(this.Width - radius * 2, this.Height - radius * 2, radius * 2, radius * 2, 0, 90); // Canto inferior direito
            path.AddArc(0, this.Height - radius * 2, radius * 2, radius * 2, 90, 90); // Canto inferior esquerdo
            path.CloseFigure();

            // Desenhar o contorno arredondado ao redor da TextBox
            e.Graphics.DrawPath(Pens.Black, path);
        }
    }
}
