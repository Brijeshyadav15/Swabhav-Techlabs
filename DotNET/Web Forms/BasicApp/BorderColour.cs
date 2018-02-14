using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public enum BorderColour
{
    RED, GREEN, BLUE, WHITE, BLACK, YELLOW
}

static class BorderColourMethod
{

    public static Color GetString(this BorderColour border)
    {
        switch (border)
        {
            case BorderColour.RED:
                return System.Drawing.Color.Red;
            case BorderColour.GREEN:
                return System.Drawing.Color.Green;
            case BorderColour.WHITE:
                return System.Drawing.Color.White;
            case BorderColour.BLUE:
                return System.Drawing.Color.Blue;
            case BorderColour.BLACK:
                return System.Drawing.Color.Black;
            case BorderColour.YELLOW:
                return System.Drawing.Color.Yellow;
            default:
                return System.Drawing.Color.White;
        }
    }
}
