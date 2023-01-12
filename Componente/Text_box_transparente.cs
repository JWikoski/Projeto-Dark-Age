using System;
using System.Windows.Forms;
using System.Drawing;


namespace transbox
{
public class TransparentTextBox : TextBox
{
    private Label _layerLabel;

    public TransparentTextBox()
    {
        // Cria uma camada de controle transparente para exibir o texto
        _layerLabel = new Label();
        _layerLabel.BackColor = Color.Transparent;
        _layerLabel.ForeColor = this.ForeColor;
        _layerLabel.Location = new Point(0, 0);
        _layerLabel.AutoSize = false;
        _layerLabel.Text = this.Text;
        _layerLabel.Visible = true;
        _layerLabel.Font = this.Font;
        _layerLabel.Size = this.Size;
        this.Controls.Add(_layerLabel);
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        _layerLabel.Size = this.Size;
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        // Desenha o fundo transparente
        this.BackColor = Color.Transparent;
    }

    protected override void OnTextChanged(EventArgs e)
    {
        base.OnTextChanged(e);
        _layerLabel.Text = this.Text;
    }

    protected override void OnForeColorChanged(EventArgs e)
    {
        base.OnForeColorChanged(e);
        _layerLabel.ForeColor = this.ForeColor;
    }

    protected override void OnFontChanged(EventArgs e)
    {
        base.OnFontChanged(e);
        _layerLabel.Font = this.Font;
    }
    }

}