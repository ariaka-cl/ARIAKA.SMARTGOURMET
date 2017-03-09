Namespace Controls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ResumenMesaViewControl
        Inherits DevExpress.XtraEditors.XtraUserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.TableLayoutPanel_ResumenContainer = New System.Windows.Forms.TableLayoutPanel()
            Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            Me.ResumenMesaGridControl1 = New ARIAKA.SMARTGOURMET.Win.Controls.ResumenMesaGridControl()
            Me.TableLayoutPanel_ResumenContainer.SuspendLayout()
            Me.SuspendLayout()
            '
            'TableLayoutPanel_ResumenContainer
            '
            Me.TableLayoutPanel_ResumenContainer.AutoScroll = True
            Me.TableLayoutPanel_ResumenContainer.AutoSize = True
            Me.TableLayoutPanel_ResumenContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.TableLayoutPanel_ResumenContainer.ColumnCount = 1
            Me.TableLayoutPanel_ResumenContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
            Me.TableLayoutPanel_ResumenContainer.Controls.Add(Me.DateTimePicker1, 0, 0)
            Me.TableLayoutPanel_ResumenContainer.Controls.Add(Me.ResumenMesaGridControl1, 0, 1)
            Me.TableLayoutPanel_ResumenContainer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TableLayoutPanel_ResumenContainer.Location = New System.Drawing.Point(0, 0)
            Me.TableLayoutPanel_ResumenContainer.Name = "TableLayoutPanel_ResumenContainer"
            Me.TableLayoutPanel_ResumenContainer.RowCount = 2
            Me.TableLayoutPanel_ResumenContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.071749!))
            Me.TableLayoutPanel_ResumenContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.92825!))
            Me.TableLayoutPanel_ResumenContainer.Size = New System.Drawing.Size(675, 446)
            Me.TableLayoutPanel_ResumenContainer.TabIndex = 0
            '
            'DateTimePicker1
            '
            Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.DateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
            Me.DateTimePicker1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.DateTimePicker1.Location = New System.Drawing.Point(275, 4)
            Me.DateTimePicker1.Name = "DateTimePicker1"
            Me.DateTimePicker1.Size = New System.Drawing.Size(124, 26)
            Me.DateTimePicker1.TabIndex = 0
            '
            'ResumenMesaGridControl1
            '
            Me.ResumenMesaGridControl1.AutoSize = True
            Me.ResumenMesaGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ResumenMesaGridControl1.Location = New System.Drawing.Point(3, 38)
            Me.ResumenMesaGridControl1.Name = "ResumenMesaGridControl1"
            Me.ResumenMesaGridControl1.Size = New System.Drawing.Size(669, 405)
            Me.ResumenMesaGridControl1.TabIndex = 1
            '
            'ResumenMesaViewControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TableLayoutPanel_ResumenContainer)
            Me.Name = "ResumenMesaViewControl"
            Me.Size = New System.Drawing.Size(675, 446)
            Me.TableLayoutPanel_ResumenContainer.ResumeLayout(False)
            Me.TableLayoutPanel_ResumenContainer.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents TableLayoutPanel_ResumenContainer As Windows.Forms.TableLayoutPanel
        Friend WithEvents DateTimePicker1 As Windows.Forms.DateTimePicker
        Friend WithEvents ResumenMesaGridControl1 As ResumenMesaGridControl
    End Class
End Namespace