Imports MySqlConnector
Imports System.Data

Public Class ProveedorRepositorio

    Private ReadOnly _conexion As String =
        "Server=localhost;Database=inventario_ferreteria;User ID=ferre_app;Password=TU_CONTRASEÑA;"

    Public Function Listar() As DataTable

        Dim tabla As New DataTable()

        Using cn As New MySqlConnection(_conexion)

            Dim sql As String =
                "SELECT id_proveedor, nombre, ruc, telefono, correo " &
                "FROM proveedores " &
                "ORDER BY nombre;"

            Using cmd As New MySqlCommand(sql, cn)
                Using adapter As New MySqlDataAdapter(cmd)

                    adapter.Fill(tabla)

                End Using
            End Using

        End Using

        Return tabla

    End Function


    Public Function ObtenerPorId(idProveedor As Integer) As Proveedor

        Using cn As New MySqlConnection(_conexion)

            Dim sql As String =
                "SELECT id_proveedor, nombre, ruc, telefono, correo " &
                "FROM proveedores " &
                "WHERE id_proveedor = @idProveedor;"

            Using cmd As New MySqlCommand(sql, cn)

                cmd.Parameters.AddWithValue("@idProveedor", idProveedor)

                cn.Open()

                Using reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.Read() Then

                        Return New Proveedor With {
                            .IdProveedor = Convert.ToInt32(reader("id_proveedor")),
                            .Nombre = reader("nombre").ToString(),
                            .Ruc = reader("ruc").ToString(),
                            .Telefono = reader("telefono").ToString(),
                            .Correo = reader("correo").ToString()
                        }

                    End If

                End Using

            End Using

        End Using

        Return Nothing

    End Function


    Public Sub Insertar(proveedor As Proveedor)

        Using cn As New MySqlConnection(_conexion)

            Dim sql As String =
                "INSERT INTO proveedores " &
                "(nombre, ruc, telefono, correo) " &
                "VALUES " &
                "(@nombre, @ruc, @telefono, @correo);"

            Using cmd As New MySqlCommand(sql, cn)

                cmd.Parameters.AddWithValue("@nombre", proveedor.Nombre)
                cmd.Parameters.AddWithValue("@ruc", proveedor.Ruc)
                cmd.Parameters.AddWithValue("@telefono", proveedor.Telefono)
                cmd.Parameters.AddWithValue("@correo", proveedor.Correo)

                cn.Open()
                cmd.ExecuteNonQuery()

            End Using

        End Using

    End Sub


    Public Sub Actualizar(proveedor As Proveedor)

        Using cn As New MySqlConnection(_conexion)

            Dim sql As String =
                "UPDATE proveedores SET " &
                "nombre = @nombre, " &
                "ruc = @ruc, " &
                "telefono = @telefono, " &
                "correo = @correo " &
                "WHERE id_proveedor = @idProveedor;"

            Using cmd As New MySqlCommand(sql, cn)

                cmd.Parameters.AddWithValue("@idProveedor", proveedor.IdProveedor)
                cmd.Parameters.AddWithValue("@nombre", proveedor.Nombre)
                cmd.Parameters.AddWithValue("@ruc", proveedor.Ruc)
                cmd.Parameters.AddWithValue("@telefono", proveedor.Telefono)
                cmd.Parameters.AddWithValue("@correo", proveedor.Correo)

                cn.Open()
                cmd.ExecuteNonQuery()

            End Using

        End Using

    End Sub


    Public Sub Eliminar(idProveedor As Integer)

        Using cn As New MySqlConnection(_conexion)

            Dim sql As String =
                "DELETE FROM proveedores " &
                "WHERE id_proveedor = @idProveedor;"

            Using cmd As New MySqlCommand(sql, cn)

                cmd.Parameters.AddWithValue("@idProveedor", idProveedor)

                cn.Open()
                cmd.ExecuteNonQuery()

            End Using

        End Using

    End Sub

End Class