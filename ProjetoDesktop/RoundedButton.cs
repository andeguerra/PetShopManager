using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundedButton : Button
{
    private int cornerRadius = 10; // Raio dos cantos

    public int CornerRadius
    {
        get { return cornerRadius; }
        set
        {
            cornerRadius = value;
            this.Invalidate(); // Redesenha o controle quando o raio é alterado
        }
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        UpdateRegion(); // Atualiza a região quando o controle é redimensionado
    }

    protected override void OnSizeChanged(EventArgs e)
    {
        base.OnSizeChanged(e);
        UpdateRegion(); // Atualiza a região quando o tamanho do controle é alterado
    }

    private void UpdateRegion()
    {
        GraphicsPath path = new GraphicsPath();
        int diameter = cornerRadius * 2;

        // Cria um caminho com cantos arredondados
        path.AddArc(0, 0, diameter, diameter, 180, 90); // Canto superior esquerdo
        path.AddArc(Width - diameter, 0, diameter, diameter, 270, 90); // Canto superior direito
        path.AddArc(Width - diameter, Height - diameter, diameter, diameter, 0, 90); // Canto inferior direito
        path.AddArc(0, Height - diameter, diameter, diameter, 90, 90); // Canto inferior esquerdo
        path.CloseFigure();

        this.Region = new Region(path); // Define a região para cliques corretamente moldada
    }
}