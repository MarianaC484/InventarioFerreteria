Imports MySqlConnector

''' <summary>
''' ÚNICO lugar del proyecto donde vive la cadena de conexión.
''' Si cambia el servidor, el puerto o el usuario, solo se edita aquí.
''' </summary>
Public Module ConexionBD

    Private Const CadenaConexion As String =
        "Server=localhost;" &
        "Port=3307;" &
        "Database=ferreteria_db;" &
        "Uid=ferre_app;" &
        "Pwd=Ferre2026*;"

    ''' <summary>Devuelve una conexión NUEVA y CERRADA.
    ''' Quien la pide es responsable de abrirla y cerrarla (Using).</summary>
    Public Function ObtenerConexion() As MySqlConnection
        Return New MySqlConnection(CadenaConexion)
    End Function

    ''' <summary>Intenta abrir una conexión y devuelve un mensaje legible.</summary>
    Public Function ProbarConexion(ByRef mensaje As String) As Boolean
        Try
            Using cn As MySqlConnection = ObtenerConexion()
                cn.Open()
                mensaje = $"Conectado a MariaDB {cn.ServerVersion} · base ferreteria_db"
                Return True
            End Using
        Catch ex As MySqlException
            mensaje = $"Error {ex.Number}: {ex.Message}"
            Return False
        End Try
    End Function

End Module
