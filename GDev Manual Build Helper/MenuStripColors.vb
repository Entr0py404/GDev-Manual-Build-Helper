Public Class ColorTable
    Inherits ProfessionalColorTable

    Dim Color1 As Color = Color.FromArgb(28, 30, 34)

    Public Overrides ReadOnly Property MenuBorder() As Color
        Get
            Return Color1
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelectedGradientBegin() As Color
        Get
            Return Color.DodgerBlue
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelectedGradientEnd() As Color
        Get
            Return Color.DodgerBlue
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemSelected() As Color
        Get
            Return Color.DodgerBlue
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemBorder() As Color
        Get
            Return Color1
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientBegin() As Color
        Get
            Return Color.DodgerBlue
        End Get
    End Property

    Public Overrides ReadOnly Property MenuItemPressedGradientEnd() As Color
        Get
            Return Color.DodgerBlue
        End Get
    End Property

    Public Overrides ReadOnly Property SeparatorDark() As Color
        Get
            Return Color1
        End Get
    End Property

    Public Overrides ReadOnly Property ImageMarginGradientBegin As Color
        Get
            Return Color1
        End Get
    End Property
    Public Overrides ReadOnly Property ImageMarginGradientMiddle As Color
        Get
            Return Color1
        End Get
    End Property
    Public Overrides ReadOnly Property ImageMarginGradientEnd As Color
        Get
            Return Color1
        End Get
    End Property

    Public Overrides ReadOnly Property ToolStripDropDownBackground As Color
        Get
            Return Color1
        End Get
    End Property
End Class