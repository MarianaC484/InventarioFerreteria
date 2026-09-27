Imports System.Windows.Forms
Imports MySqlConnector

Public Class FrmProveedores

    Private ReadOnly _proveedores As New ProveedorRepositorio()

    Private _idSeleccionado As Integer = 0

    Private Sub FrmProveedores_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        Dim mensaje As String = ""

        Try
            If Not ConexionBD.ProbarConexion(mensaje) Then

                MessageBox.Show(
                    "No fue posible conectar con MariaDB." &
                    vbCrLf & mensaje,
                    "Sin conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

                lblEstado.Text = "Sin conexión."

                grpDatos.Enabled = False
                grpAcciones.Enabled = False
                txtBuscar.Enabled = False
                btnBuscar.Enabled = False

                Return
            End If

            lblEstado.Text = mensaje

            CargarProveedores()
            PrepararNuevo()

        Catch ex As MySqlException

            MostrarErrorBD(ex)

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub CargarProveedores(
        Optional filtro As String = ""
    )

        Try

            dgvProveedores.DataSource =
                _proveedores.Listar()

            FormatearGrid()

            dgvProveedores.ClearSelection()

            lblTotal.Text =
                $"{dgvProveedores.Rows.Count} proveedor(es)"

        Catch ex As MySqlException

            MostrarErrorBD(ex)

        End Try

    End Sub

    Private Sub FormatearGrid()

        If dgvProveedores.Columns.Count = 0 Then Return

        With dgvProveedores

            If .Columns.Contains("id_proveedor") Then
                .Columns("id_proveedor").Visible = False
            End If

            If .Columns.Contains("nombre") Then
                .Columns("nombre").HeaderText = "Nombre"
            End If

            If .Columns.Contains("RUC") Then
                .Columns("RUC").HeaderText = "RUC"
            End If

            If .Columns.Contains("telefono") Then
                .Columns("telefono").HeaderText = "Teléfono"
            End If

            If .Columns.Contains("correo") Then
                .Columns("correo").HeaderText = "Correo"
            End If

        End With

    End Sub

    Private Sub dgvProveedores_CellClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles dgvProveedores.CellClick

        If e.RowIndex < 0 Then Return

        If Not dgvProveedores.Columns.Contains(
            "id_proveedor"
        ) Then Return

        Dim valorId =
            dgvProveedores.Rows(e.RowIndex).
            Cells("id_proveedor").Value

        If valorId Is Nothing OrElse IsDBNull(valorId) Then
            Return
        End If

        Dim id As Integer = CInt(valorId)

        Try

            Dim proveedor As Proveedor =
                _proveedores.ObtenerPorId(id)

            If proveedor Is Nothing Then Return

            MostrarProveedor(proveedor)

            PrepararEdicion()

        Catch ex As MySqlException

            MostrarErrorBD(ex)

        End Try

    End Sub

    Private Sub MostrarProveedor(
        p As Proveedor
    )

        _idSeleccionado = p.IdProveedor

        lblIdValor.Text =
            p.IdProveedor.ToString()

        txtNombre.Text =
            p.Nombre

        txtRuc.Text =
            p.Ruc

        txtTelefono.Text =
            p.Telefono

        txtCorreo.Text =
            p.Correo

        errValidacion.Clear()

    End Sub

    Private Function LeerFormulario() As Proveedor

        Return New Proveedor With {
            .IdProveedor = _idSeleccionado,
            .Nombre = txtNombre.Text.Trim(),
            .Ruc = txtRuc.Text.Trim(),
            .Telefono = txtTelefono.Text.Trim(),
            .Correo = txtCorreo.Text.Trim()
        }

    End Function

    Private Function ValidarFormulario() As Boolean

        errValidacion.Clear()

        Dim valido As Boolean = True

        If String.IsNullOrWhiteSpace(
            txtNombre.Text
        ) Then

            errValidacion.SetError(
                txtNombre,
                "El nombre es obligatorio."
            )

            valido = False

        End If

        If String.IsNullOrWhiteSpace(
            txtRuc.Text
        ) Then

            errValidacion.SetError(
                txtRuc,
                "El RUC es obligatorio."
            )

            valido = False

        End If

        If String.IsNullOrWhiteSpace(
            txtTelefono.Text
        ) Then

            errValidacion.SetError(
                txtTelefono,
                "El teléfono es obligatorio."
            )

            valido = False

        ElseIf txtTelefono.Text.Trim().Length <> 8 Then

            errValidacion.SetError(
                txtTelefono,
                "El teléfono debe tener 8 dígitos."
            )

            valido = False

        End If

        If String.IsNullOrWhiteSpace(
            txtCorreo.Text
        ) Then

            errValidacion.SetError(
                txtCorreo,
                "El correo es obligatorio."
            )

            valido = False

        End If

        If Not valido Then

            lblEstado.Text =
                "Revise los campos marcados."

        End If

        Return valido

    End Function

    Private Sub PrepararNuevo()

        _idSeleccionado = 0

        lblIdValor.Text = "(nuevo)"

        txtNombre.Clear()
        txtRuc.Clear()
        txtTelefono.Clear()
        txtCorreo.Clear()

        errValidacion.Clear()

        btnNuevo.Enabled = True
        btnAgregar.Enabled = True
        btnActualizar.Enabled = False
        btnEliminar.Enabled = False

        dgvProveedores.ClearSelection()

    End Sub

    Private Sub PrepararEdicion()

        btnAgregar.Enabled = False
        btnActualizar.Enabled = True
        btnEliminar.Enabled = True

    End Sub

    Private Sub btnNuevo_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNuevo.Click

        PrepararNuevo()

        txtNombre.Focus()

    End Sub

    Private Sub btnAgregar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnAgregar.Click

        Try

            If Not ValidarFormulario() Then Return

            Dim nuevo As Proveedor =
                LeerFormulario()

            _proveedores.Insertar(nuevo)

            CargarProveedores(txtBuscar.Text)

            PrepararNuevo()

            lblEstado.Text =
                $"Agregado: «{nuevo.Nombre}»."

            txtNombre.Focus()

        Catch ex As MySqlException

            MostrarErrorBD(ex)

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub btnActualizar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnActualizar.Click

        If _idSeleccionado = 0 Then Return

        Try

            If Not ValidarFormulario() Then Return

            Dim editado As Proveedor =
                LeerFormulario()

            _proveedores.Actualizar(editado)

            lblEstado.Text =
                $"Actualizado: «{editado.Nombre}»."

            CargarProveedores(txtBuscar.Text)

        Catch ex As MySqlException

            MostrarErrorBD(ex)

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub btnEliminar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnEliminar.Click

        If _idSeleccionado = 0 Then Return

        Dim respuesta As DialogResult =
            MessageBox.Show(
                $"¿Eliminar definitivamente «{txtNombre.Text}»?" &
                vbCrLf &
                "Esta acción no se puede deshacer.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2
            )

        If respuesta <> DialogResult.Yes Then Return

        Try

            Dim nombre As String =
                txtNombre.Text

            _proveedores.Eliminar(
                _idSeleccionado
            )

            CargarProveedores(
                txtBuscar.Text
            )

            PrepararNuevo()

            lblEstado.Text =
                $"Eliminado: «{nombre}»."

        Catch ex As MySqlException

            MostrarErrorBD(ex)

        Catch ex As Exception

            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    Private Sub btnBuscar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBuscar.Click

        CargarProveedores(
            txtBuscar.Text
        )

        PrepararNuevo()

    End Sub

    Private Sub txtBuscar_KeyDown(
        sender As Object,
        e As KeyEventArgs
    ) Handles txtBuscar.KeyDown

        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True

            btnBuscar.PerformClick()

        End If

    End Sub

    Private Sub MostrarErrorBD(
        ex As MySqlException
    )

        Dim texto As String

        Select Case ex.Number

            Case 1062

                texto =
                    "Ya existe un proveedor con ese RUC."

            Case 1451

                texto =
                    "No se puede eliminar este proveedor porque " &
                    "tiene productos asociados."

            Case 1042

                texto =
                    "No se encontró el servidor MariaDB."

            Case 1045

                texto =
                    "Usuario o contraseña de MariaDB incorrectos."

            Case 1049

                texto =
                    "La base de datos ferreteria_db no existe."

            Case 1142

                texto =
                    "El usuario no tiene permisos para esta operación."

            Case Else

                texto = ex.Message

        End Select

        lblEstado.Text =
            $"Error {ex.Number}"

        MessageBox.Show(
            texto,
            $"Error de base de datos ({ex.Number})",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )

    End Sub
End Class