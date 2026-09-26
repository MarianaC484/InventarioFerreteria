Imports System.Windows.Forms
Imports MySqlConnector

''' <summary>
''' Formulario CRUD de productos.
''' Capa de presentación: trabaja con los controles
''' y llama a los repositorios de la capa de datos.
''' </summary>
Public Class FrmProductos

    '==========================================================
    ' REPOSITORIOS
    '==========================================================

    Private ReadOnly _productos As New ProductoRepositorio()
    Private ReadOnly _categorias As New CategoriaRepositorio()

    ' 0 = nuevo
    ' > 0 = producto seleccionado para editar/eliminar
    Private _idSeleccionado As Integer = 0


    '==========================================================
    ' LOAD
    '==========================================================

    Private Sub FrmProductos_Load(
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

                lblEstado.Text =
                    "Sin conexión: revise MariaDB y ConexionBD.vb"

                grpDatos.Enabled = False
                grpAcciones.Enabled = False
                txtBuscar.Enabled = False
                btnBuscar.Enabled = False

                Return

            End If

            lblEstado.Text = mensaje

            CargarCategorias()
            CargarProductos()

            PrepararNuevo()

        Catch ex As MySqlException

            MostrarErrorBD(ex)

        Catch ex As Exception

            lblEstado.Text = "Error inesperado."

            MessageBox.Show(
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    '==========================================================
    ' CATEGORÍAS
    '==========================================================

    Private Sub CargarCategorias()

        Try

            cboCategoria.DisplayMember = "Nombre"
            cboCategoria.ValueMember = "IdCategoria"

            cboCategoria.DataSource =
                _categorias.Listar()

            cboCategoria.SelectedIndex = -1

        Catch ex As MySqlException

            MostrarErrorBD(ex)

        End Try

    End Sub


    '==========================================================
    ' CARGAR PRODUCTOS
    '==========================================================

    Private Sub CargarProductos(
        Optional filtro As String = ""
    )

        Try

            dgvProductos.DataSource =
                _productos.Listar(filtro)

            FormatearGrid()

            dgvProductos.ClearSelection()

            lblTotal.Text =
                $"{dgvProductos.Rows.Count} producto(s)"

        Catch ex As MySqlException

            MostrarErrorBD(ex)

        End Try

    End Sub


    '==========================================================
    ' CONFIGURAR DATAGRIDVIEW
    '==========================================================

    Private Sub FormatearGrid()

        If dgvProductos.Columns.Count = 0 Then
            Return
        End If

        With dgvProductos

            If .Columns.Contains("id_producto") Then
                .Columns("id_producto").Visible = False
            End If

            If .Columns.Contains("codigo") Then
                .Columns("codigo").HeaderText = "Código"
            End If

            If .Columns.Contains("nombre") Then

                .Columns("nombre").HeaderText = "Producto"
                .Columns("nombre").FillWeight = 220

            End If

            If .Columns.Contains("categoria") Then
                .Columns("categoria").HeaderText = "Categoría"
            End If

            If .Columns.Contains("unidad") Then
                .Columns("unidad").HeaderText = "Unidad"
            End If

            If .Columns.Contains("precio") Then

                .Columns("precio").HeaderText = "Precio"

                .Columns("precio").
                    DefaultCellStyle.
                    Format = "'C$' #,##0.00"

                .Columns("precio").
                    DefaultCellStyle.
                    Alignment =
                    DataGridViewContentAlignment.MiddleRight

            End If

            If .Columns.Contains("existencia") Then

                .Columns("existencia").HeaderText =
                    "Existencia"

                .Columns("existencia").
                    DefaultCellStyle.
                    Alignment =
                    DataGridViewContentAlignment.MiddleRight

            End If

            If .Columns.Contains("activo") Then
                .Columns("activo").HeaderText = "Activo"
            End If

        End With

    End Sub


    '==========================================================
    ' SELECCIONAR PRODUCTO EN LA TABLA
    '==========================================================

    Private Sub dgvProductos_CellClick(
        sender As Object,
        e As DataGridViewCellEventArgs
    ) Handles dgvProductos.CellClick

        If e.RowIndex < 0 Then
            Return
        End If

        If Not dgvProductos.Columns.Contains("id_producto") Then
            Return
        End If

        Dim valorId =
            dgvProductos.Rows(e.RowIndex).
            Cells("id_producto").Value

        If valorId Is Nothing OrElse IsDBNull(valorId) Then
            Return
        End If

        Dim id As Integer = CInt(valorId)

        Try

            Dim p As Producto =
                _productos.ObtenerPorId(id)

            If p Is Nothing Then

                lblEstado.Text =
                    "Ese producto ya no existe; se recargó la lista."

                CargarProductos(txtBuscar.Text)

                Return

            End If

            MostrarProducto(p)

            PrepararEdicion()

        Catch ex As MySqlException

            MostrarErrorBD(ex)

        End Try

    End Sub


    '==========================================================
    ' BUSCAR
    '==========================================================

    Private Sub btnBuscar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnBuscar.Click

        CargarProductos(txtBuscar.Text)

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


    '==========================================================
    ' NUEVO
    '==========================================================

    Private Sub btnNuevo_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNuevo.Click

        PrepararNuevo()

        txtCodigo.Focus()

    End Sub


    '==========================================================
    ' AGREGAR
    '==========================================================

    Private Sub btnAgregar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnAgregar.Click

        Try

            If Not ValidarFormulario() Then
                Return
            End If

            Dim nuevo As Producto =
                LeerFormulario()

            Dim idNuevo As Integer =
                _productos.Insertar(nuevo)

            CargarProductos(txtBuscar.Text)

            PrepararNuevo()

            lblEstado.Text =
                $"Agregado: «{nuevo.Nombre}» con ID {idNuevo}."

            txtCodigo.Focus()

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


    '==========================================================
    ' ACTUALIZAR
    '==========================================================

    Private Sub btnActualizar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnActualizar.Click

        If _idSeleccionado = 0 Then
            Return
        End If

        Try

            If Not ValidarFormulario() Then
                Return
            End If

            Dim editado As Producto =
                LeerFormulario()

            Dim filas As Integer =
                _productos.Actualizar(editado)

            If filas = 0 Then

                MessageBox.Show(
                    "El producto ya no existe en la base de datos.",
                    "Actualizar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

            Else

                lblEstado.Text =
                    $"Actualizado: «{editado.Nombre}»."

            End If

            CargarProductos(txtBuscar.Text)

            SeleccionarFila(editado.IdProducto)

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


    '==========================================================
    ' ELIMINAR
    '==========================================================

    Private Sub btnEliminar_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnEliminar.Click

        If _idSeleccionado = 0 Then
            Return
        End If

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

        If respuesta <> DialogResult.Yes Then
            Return
        End If

        Try

            Dim nombre As String =
                txtNombre.Text

            _productos.Eliminar(_idSeleccionado)

            CargarProductos(txtBuscar.Text)

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


    '==========================================================
    ' LEER FORMULARIO
    '==========================================================

    Private Function LeerFormulario() As Producto

        Return New Producto With {
            .IdProducto = _idSeleccionado,
            .Codigo = txtCodigo.Text.Trim(),
            .Nombre = txtNombre.Text.Trim(),
            .IdCategoria = CInt(cboCategoria.SelectedValue),
            .Unidad = cboUnidad.Text,
            .Precio = nudPrecio.Value,
            .Existencia = CInt(nudExistencia.Value),
            .Activo = chkActivo.Checked
        }

    End Function


    '==========================================================
    ' MOSTRAR PRODUCTO
    '==========================================================

    Private Sub MostrarProducto(
        p As Producto
    )

        _idSeleccionado =
            p.IdProducto

        lblIdValor.Text =
            p.IdProducto.ToString()

        txtCodigo.Text =
            p.Codigo

        txtNombre.Text =
            p.Nombre

        cboCategoria.SelectedValue =
            p.IdCategoria

        cboUnidad.SelectedItem =
            p.Unidad

        nudPrecio.Value =
            p.Precio

        nudExistencia.Value =
            p.Existencia

        chkActivo.Checked =
            p.Activo

        errValidacion.Clear()

    End Sub


    '==========================================================
    ' VALIDAR FORMULARIO
    '==========================================================

    Private Function ValidarFormulario() As Boolean

        errValidacion.Clear()

        Dim valido As Boolean = True

        '------------------------------------------
        ' Código
        '------------------------------------------

        If String.IsNullOrWhiteSpace(txtCodigo.Text) Then

            errValidacion.SetError(
                txtCodigo,
                "El código es obligatorio."
            )

            valido = False

        ElseIf _productos.ExisteCodigo(
            txtCodigo.Text.Trim(),
            _idSeleccionado
        ) Then

            errValidacion.SetError(
                txtCodigo,
                "Otro producto ya usa este código."
            )

            valido = False

        End If


        '------------------------------------------
        ' Nombre
        '------------------------------------------

        If String.IsNullOrWhiteSpace(txtNombre.Text) Then

            errValidacion.SetError(
                txtNombre,
                "Escriba el nombre del producto."
            )

            valido = False

        End If


        '------------------------------------------
        ' Categoría
        '------------------------------------------

        If cboCategoria.SelectedIndex < 0 Then

            errValidacion.SetError(
                cboCategoria,
                "Seleccione una categoría."
            )

            valido = False

        End If


        '------------------------------------------
        ' Unidad
        '------------------------------------------

        If cboUnidad.SelectedIndex < 0 Then

            errValidacion.SetError(
                cboUnidad,
                "Seleccione la unidad de venta."
            )

            valido = False

        End If


        '------------------------------------------
        ' Precio
        '------------------------------------------

        If nudPrecio.Value <= 0D Then

            errValidacion.SetError(
                nudPrecio,
                "El precio debe ser mayor que C$ 0.00."
            )

            valido = False

        End If


        If Not valido Then

            lblEstado.Text =
                "Revise los campos marcados en rojo."

        End If

        Return valido

    End Function


    '==========================================================
    ' MODO NUEVO
    '==========================================================

    Private Sub PrepararNuevo()

        _idSeleccionado = 0

        lblIdValor.Text =
            "(nuevo)"

        txtCodigo.Clear()

        txtNombre.Clear()

        cboCategoria.SelectedIndex = -1

        cboUnidad.SelectedIndex = 0

        nudPrecio.Value = 0D

        nudExistencia.Value = 0D

        chkActivo.Checked = True

        errValidacion.Clear()

        btnAgregar.Enabled = True

        btnActualizar.Enabled = False

        btnEliminar.Enabled = False

        dgvProductos.ClearSelection()

    End Sub


    '==========================================================
    ' MODO EDICIÓN
    '==========================================================

    Private Sub PrepararEdicion()

        btnAgregar.Enabled = False

        btnActualizar.Enabled = True

        btnEliminar.Enabled = True

    End Sub


    '==========================================================
    ' SELECCIONAR FILA DESPUÉS DE ACTUALIZAR
    '==========================================================

    Private Sub SeleccionarFila(
        id As Integer
    )

        For Each fila As DataGridViewRow In dgvProductos.Rows

            If fila.IsNewRow Then
                Continue For
            End If

            If CInt(
                fila.Cells("id_producto").Value
            ) = id Then

                fila.Selected = True

                If fila.Index >= 0 AndAlso
                   fila.Index < dgvProductos.RowCount Then

                    dgvProductos.FirstDisplayedScrollingRowIndex =
                        fila.Index

                End If

                Exit For

            End If

        Next

    End Sub


    '==========================================================
    ' ERRORES DE MARIADB
    '==========================================================

    Private Sub MostrarErrorBD(
        ex As MySqlException
    )

        Dim texto As String

        Select Case ex.Number

            Case 1042

                texto =
                    "No se encontró el servidor MariaDB." &
                    " ¿Está iniciado el servicio?"

            Case 1045

                texto =
                    "Usuario o contraseña de MariaDB incorrectos."

            Case 1049

                texto =
                    "La base ferreteria_db no existe." &
                    " Ejecute database/01_esquema.sql."

            Case 1062

                texto =
                    "Ya existe un producto con ese código."

                errValidacion.SetError(
                    txtCodigo,
                    texto
                )

            Case 1142

                texto =
                    "El usuario ferre_app no tiene permiso" &
                    " para esa operación."

            Case 1451

                texto =
                    "No se puede eliminar: otros registros" &
                    " dependen de este."

            Case 1452

                texto =
                    "La categoría seleccionada no existe."

            Case 4025

                texto =
                    "Un valor no cumple las reglas de la tabla" &
                    " (precio o existencia)."

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