Namespace Controls
    Public Class PersonalViewControl
        Private Property _cliente As New Logica.Cliente
        Private Sub PersonalViewControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            PopulateRol()
            PopulateUserGrid()
        End Sub

        Public Sub PopulateRol()
            Me.RolDTOBindingSource.DataSource = _cliente.GetRol()
            Me.ComboBox_Rol.DataSource = Me.RolDTOBindingSource.DataSource
        End Sub
        Public Sub PopulateUserGrid()
            Dim listUserDto As List(Of Models.UserDTO) = _cliente.GetUsuarios()
            If listUserDto IsNot Nothing Then
                Me.PersonalControl1.UserDTOBindingSource.DataSource = listUserDto
                Me.PersonalControl1.GridView1.RefreshEditor(True)
            End If

        End Sub

        Private Sub SimpleButton_Guardar_Click(sender As Object, e As EventArgs) Handles SimpleButton_Guardar.Click
            Dim run As String = TextEdit_Rut.Text
            Dim nombre As String = TextEdit_Nombre.Text
            Dim userName As String = TextEdit_UserName.Text
            Dim pass As String = TextEdit_Pass.Text
            Dim rolId As Integer = CInt(ComboBox_Rol.SelectedValue)

            Dim userDto As New Models.UserDTO With {.Nombre = nombre,
                                                    .Run = run,
                                                    .UserName = userName,
                                                    .Password = pass,
                                                    .FechaCreacion = Date.Now(),
                                                    .RolID = rolId,
                                                    .Rol = New Models.RolDTO With {.ID = rolId, .Nombre = ComboBox_Rol.Text}}

            userDto = _cliente.GuardarUsuario(userDto)
            Me.PersonalControl1.UserDTOBindingSource.Add(userDto)
            Me.PersonalControl1.GridView1.RefreshEditor(True)
        End Sub

        Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
            Dim userDto As Models.UserDTO = CType(PersonalControl1.UserDTOBindingSource.Current, Models.UserDTO)
            Dim id As Integer = userDto.ID
            If id <> 0 Then _cliente.EliminarUsuario(id)
            PersonalControl1.GridView1.DeleteRow(PersonalControl1.GridView1.FocusedRowHandle)
            Me.PersonalControl1.GridView1.RefreshEditor(True)
        End Sub
    End Class
End Namespace