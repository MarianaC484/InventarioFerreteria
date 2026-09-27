Imports System.Data
Imports System.Windows.Forms
Imports MySqlConnector

''' <summary>
''' Repositorio de productos: contiene TODO el SQL de la tabla productos.
''' El formulario nunca escribe SQL; solo llama a estos métodos.
''' </summary>
Public Class ProductoRepositorio

    ' =========================================================
    ' R — READ (lista para el DataGridView) · modo DESCONECTADO
    ' =========================================================
    Public Function Listar(Optional filtro As String = "", Optional soloActivos As Boolean = False) As List(Of Producto)
        Dim lista As New List(Of Producto)()
        Dim sql As String = "SELECT p.id_producto, p.codigo, p.nombre, c.nombre AS categoria, " &
                        "p.unidad, p.precio, p.existencia, p.activo " &
                        "FROM productos p " &
                        "INNER JOIN categorias c ON c.id_categoria = p.id_categoria "
        sql &= "WHERE (p.codigo LIKE @filtro OR p.nombre LIKE @filtro) "

        If soloActivos Then
            sql &= "AND p.activo = 1 "
        End If

        sql &= "ORDER BY p.nombre;"

        Dim tabla As New DataTable()

        Using cn As MySqlConnection = ObtenerConexion()

            Dim da As New MySqlDataAdapter(sql, cn)

            da.SelectCommand.Parameters.AddWithValue("@filtro", "%" & filtro & "%")

            da.Fill(tabla)

        End Using
        ' RECORRIDO CON PROTECCIÓN DE EXCEPCIONES INTEGRAL
        For Each row As DataRow In tabla.Rows
            Try
                ' 1. Evaluar el estado de activo de forma segura
                Dim esActivo As Boolean = False
                If Not IsDBNull(row("activo")) Then
                    Dim strActivo As String = row("activo").ToString().Trim()
                    If strActivo = "1" OrElse strActivo.ToLower() = "true" Then
                        esActivo = True
                    End If
                End If

                ' 2. Mapear el objeto producto
                Dim prod As New Producto() With {
                    .IdProducto = If(IsDBNull(row("id_producto")), 0, Convert.ToInt32(row("id_producto"))),
                    .Codigo = If(IsDBNull(row("codigo")), "", row("codigo").ToString()),
                    .Nombre = If(IsDBNull(row("nombre")), "", row("nombre").ToString()),
                    .Unidad = If(IsDBNull(row("unidad")), "", row("unidad").ToString()),
                    .Precio = If(IsDBNull(row("precio")), 0D, Convert.ToDecimal(row("precio"))),
                    .Existencia = If(IsDBNull(row("existencia")), 0, Convert.ToInt32(row("existencia"))),
                    .Activo = esActivo
                }
                lista.Add(prod)
            Catch ex As Exception
                ' Si alguna fila da un error de conversión, se salta silenciosamente para no bloquear la pantalla
                Continue For
            End Try
        Next

        Return lista
    End Function

    ' =========================================================
    ' R — READ (un solo registro) · modo CONECTADO
    ' =========================================================
    Public Function ObtenerPorId(id As Integer) As Producto
        Const sql As String =
            "SELECT id_producto, codigo, nombre, id_categoria, unidad, " &
            "       precio, existencia, activo " &
            "FROM productos WHERE id_producto = @id;"

        Using cn As MySqlConnection = ObtenerConexion(),
              cmd As New MySqlCommand(sql, cn)

            cmd.Parameters.AddWithValue("@id", id)
            cn.Open()

            Using dr As MySqlDataReader = cmd.ExecuteReader()
                If Not dr.Read() Then Return Nothing   ' no existe

                Return New Producto With {
                    .IdProducto = dr.GetInt32("id_producto"),
                    .Codigo = dr.GetString("codigo"),
                    .Nombre = dr.GetString("nombre"),
                    .IdCategoria = dr.GetInt32("id_categoria"),
                    .Unidad = dr.GetString("unidad"),
                    .Precio = dr.GetDecimal("precio"),
                    .Existencia = dr.GetInt32("existencia"),
                    .Activo = dr.GetBoolean("activo")
                }
            End Using
        End Using
    End Function

    ' =========================================================
    ' Validación de negocio: ¿el código ya lo usa OTRO producto?
    ' ExecuteScalar devuelve la primera columna de la primera fila.
    ' =========================================================
    Public Function ExisteCodigo(codigo As String, idExcluir As Integer) As Boolean
        Const sql As String =
            "SELECT COUNT(*) FROM productos " &
            "WHERE codigo = @codigo AND id_producto <> @id;"

        Using cn As MySqlConnection = ObtenerConexion(),
              cmd As New MySqlCommand(sql, cn)

            cmd.Parameters.AddWithValue("@codigo", codigo)
            cmd.Parameters.AddWithValue("@id", idExcluir)
            cn.Open()
            Return Convert.ToInt64(cmd.ExecuteScalar()) > 0
        End Using
    End Function

    ' =========================================================
    ' C — CREATE
    ' Devuelve el id generado por AUTO_INCREMENT.
    ' =========================================================
    Public Function Insertar(p As Producto) As Integer
        Const sql As String =
            "INSERT INTO productos " &
            "  (codigo, nombre, id_categoria, unidad, precio, existencia, activo) " &
            "VALUES " &
            "  (@codigo, @nombre, @idCategoria, @unidad, @precio, @existencia, @activo);"

        Using cn As MySqlConnection = ObtenerConexion(),
              cmd As New MySqlCommand(sql, cn)

            AgregarParametros(cmd, p)
            cn.Open()
            cmd.ExecuteNonQuery()
            Return CInt(cmd.LastInsertedId)
        End Using
    End Function

    ' =========================================================
    ' U — UPDATE
    ' Devuelve cuántas filas encontró el WHERE (0 = ya no existe).
    ' =========================================================
    Public Function Actualizar(p As Producto) As Integer
        Const sql As String =
            "UPDATE productos SET " &
            "   codigo = @codigo, nombre = @nombre, id_categoria = @idCategoria, " &
            "   unidad = @unidad, precio = @precio, existencia = @existencia, " &
            "   activo = @activo " &
            "WHERE id_producto = @id;"

        Using cn As MySqlConnection = ObtenerConexion(),
              cmd As New MySqlCommand(sql, cn)

            AgregarParametros(cmd, p)
            cmd.Parameters.AddWithValue("@id", p.IdProducto)
            cn.Open()
            Return cmd.ExecuteNonQuery()
        End Using
    End Function

    ' =========================================================
    ' D — DELETE
    ' =========================================================
    Public Function Eliminar(id As Integer) As Integer
        Const sql As String = "DELETE FROM productos WHERE id_producto = @id;"

        Using cn As MySqlConnection = ObtenerConexion(),
              cmd As New MySqlCommand(sql, cn)

            cmd.Parameters.AddWithValue("@id", id)
            cn.Open()
            Return cmd.ExecuteNonQuery()
        End Using
    End Function

    ' Parámetros comunes a INSERT y UPDATE (evita repetir código)
    Private Sub AgregarParametros(cmd As MySqlCommand, p As Producto)
        cmd.Parameters.AddWithValue("@codigo", p.Codigo)
        cmd.Parameters.AddWithValue("@nombre", p.Nombre)
        cmd.Parameters.AddWithValue("@idCategoria", p.IdCategoria)
        cmd.Parameters.AddWithValue("@unidad", p.Unidad)
        cmd.Parameters.AddWithValue("@precio", p.Precio)
        cmd.Parameters.AddWithValue("@existencia", p.Existencia)
        cmd.Parameters.AddWithValue("@activo", p.Activo)
    End Sub

End Class