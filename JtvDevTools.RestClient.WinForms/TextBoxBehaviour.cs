using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.RestClient.WinForms;

public enum TextBoxType
{
    Undefined = 0,
    ID = 1,
    Name = 2
}

public class TextBoxBehaviour
{
    private TextBox textBox;
    private TextBoxType type;

    public TextBoxBehaviour(TextBox textBox, TextBoxType type, bool trimOnLeave)
    {
        this.textBox = textBox;
        this.type = type;

        switch (type)
        {
            case TextBoxType.ID:
                textBox.MaxLength = 10;
                textBox.KeyDown += TextBox_ID_KeyDown;
                textBox.TextChanged += TextBox_ID_TextChanged;
                break;

            case TextBoxType.Name:
                textBox.MaxLength = 255;
                break;
        }

        if (trimOnLeave)
        {
            textBox.Leave += TextBox_Leave;
        }

    }

    private void TextBox_Leave(object? sender, EventArgs e)
    {
        textBox.Text = (textBox.Text ?? "").Trim();
    }

    private void TextBox_ID_TextChanged(object sender, EventArgs e)
    {
        int value;
        bool valid = int.TryParse(textBox.Text, out value);

        if (valid && value > 0)
        {
            textBox.BackColor = Color.White;
        }
        else
        {
            textBox.BackColor = Color.Tomato;
        }
    }

    private void TextBox_ID_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Back) return;
        if (e.KeyCode == Keys.Tab) return;

        if (e.KeyCode == Keys.Delete)
        {
            textBox.Text = "";
        }

        switch (e.KeyCode)
        {
            case Keys.D1:
            case Keys.D2:
            case Keys.D3:
            case Keys.D4:
            case Keys.D5:
            case Keys.D6:
            case Keys.D7:
            case Keys.D8:
            case Keys.D9:
            case Keys.D0:
            case Keys.NumPad1:
            case Keys.NumPad2:
            case Keys.NumPad3:
            case Keys.NumPad4:
            case Keys.NumPad5:
            case Keys.NumPad6:
            case Keys.NumPad7:
            case Keys.NumPad8:
            case Keys.NumPad9:
            case Keys.NumPad0:
                break;

            default:
                e.Handled = true;
                e.SuppressKeyPress = true;
                break;
        }
    }
}