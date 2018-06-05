Public Class Form1
    Dim strength2 As Integer
    Dim agility2 As Integer
    Dim power2 As Integer
    Dim intellect2 As Integer
    Dim will2 As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("This program is designed to calculate the maximum % value for pet talents, based on the pets stats.", "Read Me")
    End Sub

    Private Sub Calculate_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Dim r_spequation As Double
        Dim r_defyequation As Double
        Dim r_wardequation As Double

        'Converting values from string to Integer
        strength2 = Integer.Parse(Strength.Text)
        agility2 = Integer.Parse(Agility.Text)
        power2 = Integer.Parse(Power.Text)
        intellect2 = Integer.Parse(Intellect.Text)
        will2 = Integer.Parse(Will.Text)

        ' Equations for calculating the different pet talents.

        'Resist Section
        'Spell Proof -> Works for all 10% resist talents
        r_spequation = ((2 * strength2) + (2 * agility2) + power2) / 125
        'Spell Defy
        r_defyequation = ((2 * strength2) + (2 * agility2) + power2) / 250
        'Ward Talents -> Works for all 15% resist talents
        r_wardequation = (((2 * strength2) + (2 * agility2) + power2) * 3) / 250
        'Damage Section
        'Critical Section
        'Healing Section

        '//Output for the Program'
        'Proof Level column output
        sp_p.Text = r_spequation.ToString
        f_p.Text = sp_p.Text
        i_p.Text = sp_p.Text
        s_p.Text = sp_p.Text
        l_p.Text = sp_p.Text
        d_p.Text = sp_p.Text
        m_p.Text = sp_p.Text
        b_p.Text = sp_p.Text

        ' Output for ward talents
        f_w.Text = r_wardequation.ToString
        i_w.Text = f_w.Text
        s_w.Text = f_w.Text
        l_w.Text = f_w.Text
        d_w.Text = f_w.Text
        m_w.Text = f_w.Text
        b_w.Text = f_w.Text

        'Defy column value copied down -> Output
        r_defy.Text = r_defyequation.ToString
        f_a.Text = r_defy.Text
        i_a.Text = r_defy.Text
        s_a.Text = r_defy.Text
        l_a.Text = r_defy.Text
        d_a.Text = r_defy.Text
        m_a.Text = r_defy.Text
        b_o.Text = r_defy.Text
        'f_a.Text = i_a.Text = s_a.Text = l_a.Text = d_a.Text = m_a.Text = b_o.Text = r_defy.Text
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        Strength.Clear()
        Intellect.Clear()
        Will.Clear()
        Agility.Clear()
        Power.Clear()
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Application.Exit()
    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Sub Strength_TextChanged(sender As Object, e As EventArgs) Handles Strength.GotFocus, Strength.TextChanged
        Strength.Focus()

    End Sub

    Private Sub Power_TextChanged(sender As Object, e As EventArgs) Handles Power.TextChanged

    End Sub

    Private Sub s_a_Click(sender As Object, e As EventArgs) Handles s_a.Click

    End Sub
End Class
