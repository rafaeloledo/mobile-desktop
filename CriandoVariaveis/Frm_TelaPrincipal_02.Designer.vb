﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_TelaPrincipal_02
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Btn_NumerosInteiros = New System.Windows.Forms.Button()
        Me.Lbl_NomeProjeto = New System.Windows.Forms.Label()
        Me.Btn_PontoFlutuante = New System.Windows.Forms.Button()
        Me.Btn_ConversaoNumeros = New System.Windows.Forms.Button()
        Me.Txt_Numerador = New System.Windows.Forms.TextBox()
        Me.Txt_Denominador = New System.Windows.Forms.TextBox()
        Me.Btn_Resultado = New System.Windows.Forms.Button()
        Me.Txt_ResultadoDecimal = New System.Windows.Forms.TextBox()
        Me.Txt_ResultadoDouble = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btn_NumerosInteiros
        '
        Me.Btn_NumerosInteiros.Location = New System.Drawing.Point(12, 61)
        Me.Btn_NumerosInteiros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_NumerosInteiros.Name = "Btn_NumerosInteiros"
        Me.Btn_NumerosInteiros.Size = New System.Drawing.Size(215, 43)
        Me.Btn_NumerosInteiros.TabIndex = 0
        Me.Btn_NumerosInteiros.Text = "Exemplos Números Inteiros"
        Me.Btn_NumerosInteiros.UseVisualStyleBackColor = True
        '
        'Lbl_NomeProjeto
        '
        Me.Lbl_NomeProjeto.AutoSize = True
        Me.Lbl_NomeProjeto.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_NomeProjeto.Name = "Lbl_NomeProjeto"
        Me.Lbl_NomeProjeto.Size = New System.Drawing.Size(97, 15)
        Me.Lbl_NomeProjeto.TabIndex = 2
        Me.Lbl_NomeProjeto.Text = "Criando Variáveis"
        '
        'Btn_PontoFlutuante
        '
        Me.Btn_PontoFlutuante.Location = New System.Drawing.Point(12, 124)
        Me.Btn_PontoFlutuante.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_PontoFlutuante.Name = "Btn_PontoFlutuante"
        Me.Btn_PontoFlutuante.Size = New System.Drawing.Size(215, 43)
        Me.Btn_PontoFlutuante.TabIndex = 3
        Me.Btn_PontoFlutuante.Text = "Exemplos Números Ponto Flutuante"
        Me.Btn_PontoFlutuante.UseVisualStyleBackColor = True
        '
        'Btn_ConversaoNumeros
        '
        Me.Btn_ConversaoNumeros.Location = New System.Drawing.Point(12, 187)
        Me.Btn_ConversaoNumeros.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_ConversaoNumeros.Name = "Btn_ConversaoNumeros"
        Me.Btn_ConversaoNumeros.Size = New System.Drawing.Size(215, 43)
        Me.Btn_ConversaoNumeros.TabIndex = 4
        Me.Btn_ConversaoNumeros.Text = "Exemplo Conversão Números"
        Me.Btn_ConversaoNumeros.UseVisualStyleBackColor = True
        '
        'Txt_Numerador
        '
        Me.Txt_Numerador.Location = New System.Drawing.Point(334, 72)
        Me.Txt_Numerador.Name = "Txt_Numerador"
        Me.Txt_Numerador.Size = New System.Drawing.Size(164, 23)
        Me.Txt_Numerador.TabIndex = 5
        '
        'Txt_Denominador
        '
        Me.Txt_Denominador.Location = New System.Drawing.Point(334, 101)
        Me.Txt_Denominador.Name = "Txt_Denominador"
        Me.Txt_Denominador.Size = New System.Drawing.Size(164, 23)
        Me.Txt_Denominador.TabIndex = 6
        '
        'Btn_Resultado
        '
        Me.Btn_Resultado.Location = New System.Drawing.Point(334, 130)
        Me.Btn_Resultado.Name = "Btn_Resultado"
        Me.Btn_Resultado.Size = New System.Drawing.Size(162, 23)
        Me.Btn_Resultado.TabIndex = 7
        Me.Btn_Resultado.Text = "Resultado"
        Me.Btn_Resultado.UseVisualStyleBackColor = True
        '
        'Txt_ResultadoDecimal
        '
        Me.Txt_ResultadoDecimal.Location = New System.Drawing.Point(334, 172)
        Me.Txt_ResultadoDecimal.Name = "Txt_ResultadoDecimal"
        Me.Txt_ResultadoDecimal.ReadOnly = True
        Me.Txt_ResultadoDecimal.Size = New System.Drawing.Size(354, 23)
        Me.Txt_ResultadoDecimal.TabIndex = 8
        '
        'Txt_ResultadoDouble
        '
        Me.Txt_ResultadoDouble.Location = New System.Drawing.Point(332, 201)
        Me.Txt_ResultadoDouble.Name = "Txt_ResultadoDouble"
        Me.Txt_ResultadoDouble.ReadOnly = True
        Me.Txt_ResultadoDouble.Size = New System.Drawing.Size(356, 23)
        Me.Txt_ResultadoDouble.TabIndex = 9
        '
        'Frm_TelaPrincipal_02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 338)
        Me.Controls.Add(Me.Txt_ResultadoDouble)
        Me.Controls.Add(Me.Txt_ResultadoDecimal)
        Me.Controls.Add(Me.Btn_Resultado)
        Me.Controls.Add(Me.Txt_Denominador)
        Me.Controls.Add(Me.Txt_Numerador)
        Me.Controls.Add(Me.Btn_ConversaoNumeros)
        Me.Controls.Add(Me.Btn_PontoFlutuante)
        Me.Controls.Add(Me.Lbl_NomeProjeto)
        Me.Controls.Add(Me.Btn_NumerosInteiros)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Frm_TelaPrincipal_02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicação Olá Mundo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_NumerosInteiros As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Btn_PontoFlutuante As Button
    Friend WithEvents Btn_ConversaoNumeros As Button
    Friend WithEvents Txt_Numerador As TextBox
    Friend WithEvents Txt_Denominador As TextBox
    Friend WithEvents Btn_Resultado As Button
    Friend WithEvents Txt_ResultadoDecimal As TextBox
    Friend WithEvents Txt_ResultadoDouble As TextBox
End Class
