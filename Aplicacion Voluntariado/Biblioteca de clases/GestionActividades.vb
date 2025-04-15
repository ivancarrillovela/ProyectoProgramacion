﻿Imports System.Data.SqlClient

Public Class GestionActividades

    Public Shared servidor = "KUM" ' Aquí pondremos el nombre de nuestro servidor de SqlServer
    Public Shared cadenaConexion = $"Data Source = {servidor}; Initial Catalog = PROYECTOINTER; Integrated Security = SSPI; MultipleActiveResultSets=true" ' Cadena de conexión para indicar la base de datos, en este caso Estado, con la que vamos a conectar

    Private Shared comando As Object



    ''Gestiones para actividades:

    Public Shared Function ListaActividades() As List(Of Actividad)

        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()

        Dim consulta As String = "SELECT ACTIVIDADES.* FROM ACTIVIDADES"

        Dim cmdObtener As New SqlCommand(consulta, conexion)

        Dim drActividad As SqlDataReader = cmdObtener.ExecuteReader

        Dim actividades As New List(Of Actividad)

        While drActividad.Read
            Dim actividad As New Actividad(drActividad("CODACTIVIDAD"), drActividad("NOMBRE"), drActividad("ESTADO"), drActividad("DIRECCION"), drActividad("MAX_PARTICIPANTES"), drActividad("FECHA_INICIO"), drActividad("FECHA_FIN"), drActividad("CIF_EMPRESA"))
            actividades.Add(actividad)
        End While

        conexion.Close()

        Return actividades

    End Function

    Public Shared Function ListaVoluntariosPorActividad() As List(Of Actividad)

        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()

        Dim consulta As String = "SELECT * FROM ACTIVIDADES"

        Dim cmdObtener As New SqlCommand(consulta, conexion)

        Dim drActividad As SqlDataReader = cmdObtener.ExecuteReader

        Dim actividades As New List(Of Actividad)

        While drActividad.Read
            Dim actividad As New Actividad(drActividad("CODACTIVIDAD"), drActividad("NOMBRE"), drActividad("ESTADO"), drActividad("DIRECCION"), drActividad("MAX_PARTICIPANTES"), drActividad("FECHA_INICIO"), drActividad("FECHA_FIN"), drActividad("CIF_EMPRESA"))
            actividades.Add(actividad)
        End While

        conexion.Close()

        Return actividades

    End Function
    Public Shared Function BuscarActividad(codActividad As Integer) As Actividad

        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()

        Dim consulta As String = $"SELECT ACTIVIDADES.* FROM ACTIVIDADES WHERE ACTIVIDADES.CODACTIVIDAD={codActividad}"

        Dim cmdObtener As New SqlCommand(consulta, conexion)

        Dim drActividad As SqlDataReader = cmdObtener.ExecuteReader

        Dim actividad As Actividad = Nothing

        If drActividad.Read Then
            actividad = New Actividad(drActividad("CODACTIVIDAD"), drActividad("NOMBRE"), drActividad("ESTADO"), drActividad("DIRECCION"), drActividad("MAX_PARTICIPANTES"), drActividad("FECHA_INICIO"), drActividad("FECHA_FIN"), drActividad("CIF_EMPRESA"))
        End If

        conexion.Close()
        Return actividad

    End Function
    Public Shared Function ModificarEstadoActividad(codActividad As Integer, estadoActividad As String) As String

        Dim estado As String = ""

        Select Case estadoActividad.ToLower
            Case "en curso"
                estado = "En Curso"
            Case "pendiente"
                estado = "Pendiente"
            Case "archivado"
                estado = "Archivado"
        End Select

        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()

        Dim consulta As String = $"UPDATE ACTIVIDADES SET ACTIVIDADES.ESTADO='{estado}' WHERE ACTIVIDADES.CODACTIVIDAD={codActividad}"

        Dim cmdModificar As New SqlCommand(consulta, conexion)

        Dim drActividad As Integer = cmdModificar.ExecuteNonQuery

        conexion.Close()

        If drActividad = 1 Then
            Return True
        End If

        Return False

    End Function

    Public Shared Function AnadirActividad(actividad As Actividad) As Boolean

        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()

        Dim consulta As String = $"INSERT INTO ACTIVIDADES (NOMBRE,ESTADO,DIRECCION,MAX_PARTICIPANTES,FECHA_INICIO,FECHA_FIN,CIF_EMPRESA) VALUES ('{actividad.Nombre}','{actividad.Estado}','{actividad.Direccion}',{actividad.Max_participantes},'{actividad.Fecha_incio:yyyy-MM-dd HH:mm:ss}','{actividad.Fecha_fin:yyyy-MM-dd HH:mm}','{actividad.Cif}')"

        Dim cmdObtener As New SqlCommand(consulta, conexion)

        Dim drActividad As Integer = cmdObtener.ExecuteNonQuery
        conexion.Close()

        If drActividad > 0 Then
            Return True
        End If

        Return False

    End Function
    Public Shared Function BorrarActividad(codActividad As Integer) As Boolean

        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()

        Dim consulta As String = $"DELETE FROM ACTIVIDADES WHERE ACTIVIDADES.CODACTIVIDAD={codActividad}"

        Dim cmdModificar As New SqlCommand(consulta, conexion)

        Dim drActividad As Integer = cmdModificar.ExecuteNonQuery

        conexion.Close()

        If drActividad = 1 Then
            Return True
        End If

        Return False

    End Function




    ''Gestiones para organizaciones:
    Public Shared Function ListaOrganizaciones() As List(Of Organizacion)

        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()

        Dim consulta As String = $"SELECT ORGANIZACIONES.* FROM ORGANIZACIONES"

        Dim cmdObtener As New SqlCommand(consulta, conexion)

        Dim drOrganizacion As SqlDataReader = cmdObtener.ExecuteReader

        Dim organizaciones As New List(Of Organizacion)

        While drOrganizacion.Read
            Dim organizacion As New Organizacion(drOrganizacion("CIF"), drOrganizacion("NOMBRE"), drOrganizacion("DIRECCION"), drOrganizacion("CP"), drOrganizacion("LOCALIDAD"), drOrganizacion("DESCRIPCION"), drOrganizacion("CONTACTO"))
            organizaciones.Add(organizacion)
        End While

        conexion.Close()

        Return organizaciones

    End Function




    ''Gestiones para ods:
    Public Shared Function ListaOds() As List(Of Ods)

        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()

        Dim consulta As String = $"SELECT ODS.* FROM ODS"

        Dim cmdObtener As New SqlCommand(consulta, conexion)

        Dim drOds As SqlDataReader = cmdObtener.ExecuteReader

        Dim odss As New List(Of Ods)

        While drOds.Read
            Dim ods As New Ods(drOds("NUMODS"), drOds("NOMBRE"), drOds("DESCRIPCION"))
            odss.Add(ods)
        End While

        conexion.Close()

        Return odss

    End Function

    Public Shared Function AnadirOds(codActividad As String, nombreOds As String) As Boolean

        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()

        Dim consulta As String = $"INSERT INTO ODS_ACTIVIDAD (CODACTIVIDAD,NOMBRE_ODS) VALUES ('{codActividad}','{nombreOds}"

        Dim cmdObtener As New SqlCommand(consulta, conexion)

        Dim drOds As Integer = cmdObtener.ExecuteNonQuery

        conexion.Close()

        If drOds = 1 Then
            Return True
        End If

        Return False

    End Function

    Public Shared Function QuitarOds(codActividad As String, nombreOds As String) As Boolean

        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()

        Dim consulta As String = $"DELETE FROM ODS_ACTIVIDAD WHERE CODACTIVIDAD='{codActividad}' AND NOMBRE_ODS='{nombreOds}'"

        Dim cmdObtener As New SqlCommand(consulta, conexion)

        Dim drOds As Integer = cmdObtener.ExecuteNonQuery

        conexion.Close()

        If drOds = 1 Then
            Return True
        End If

        Return False

    End Function




    ''Gestiones para voluntarios:
    Public Shared Function ListaVoluntarios() As List(Of Voluntario)

        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()

        Dim consulta As String = $"SELECT VOLUNTARIOS.* FROM VOLUNTARIOS"

        Dim cmdObtener As New SqlCommand(consulta, conexion)

        Dim drVoluntarios As SqlDataReader = cmdObtener.ExecuteReader

        Dim voluntarios As New List(Of Voluntario)

        While drVoluntarios.Read
            Dim voluntario As New Voluntario(drVoluntarios("DNI"), drVoluntarios("NOMBRE"), drVoluntarios("APELLIDO1"), drVoluntarios("APELLIDO2"), drVoluntarios("CORREO"), drVoluntarios("COCHE"), drVoluntarios("FECHA_NACIMIENTO"), drVoluntarios("EXPERIENCIA"), drVoluntarios("NOMBRE_CICLO"))
            voluntarios.Add(voluntario)
        End While

        conexion.Close()

        Return voluntarios

    End Function
    Public Shared Function AnadirVoluntario(codActividad As Integer, dniVoluntario As String) As Boolean

        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()

        Dim consulta As String = $"INSERT INTO VOLUNTARIOS_ACTIVIDAD (DNI_VOLUNTARIO,CODACTIVIDAD) VALUES ('{dniVoluntario}','{codActividad}')"

        Dim cmdObtener As New SqlCommand(consulta, conexion)

        Dim drVoluntario As Integer = cmdObtener.ExecuteNonQuery

        conexion.Close()

        If drVoluntario = 1 Then
            Return True
        End If

        Return False

    End Function

    Public Shared Function QuitarVoluntario(codActividad As Integer, dniVoluntario As String) As Boolean

        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()

        Dim consulta As String = $"DELETE FROM VOLUNTARIOS_ACTIVIDAD WHERE CODACTIVIDAD='{codActividad}' AND DNI_VOLUNTARIO='{dniVoluntario}'"

        Dim cmdObtener As New SqlCommand(consulta, conexion)

        Dim drVoluntario As Integer = cmdObtener.ExecuteNonQuery

        conexion.Close()

        If drVoluntario = 1 Then
            Return True
        End If

        Return False

    End Function

    Public Shared Function voluntariosPorActividad(actividad As Actividad) As List(Of Voluntario)
        Dim voluntarios As New List(Of Voluntario)()

        Using conexion As New SqlConnection(cadenaConexion)
            conexion.Open()

            Dim consulta As String = "SELECT * FROM VOLUNTARIOS WHERE DNI IN (SELECT DNI_VOLUNTARIO FROM VOLUNTARIOS_ACTIVIDADES WHERE CODACTIVIDAD = @codActividad)"
            Using cmdObtener As New SqlCommand(consulta, conexion)
                cmdObtener.Parameters.AddWithValue("@codActividad", actividad.CodActividad)

                Using lector As SqlDataReader = cmdObtener.ExecuteReader()
                    While lector.Read()
                        Dim voluntario As New Voluntario(
                        lector("DNI"),
                        lector("NOMBRE"),
                        lector("APELLIDO1"),
                        lector("APELLIDO2"),
                        lector("CORREO"),
                        lector("COCHE"),
                        lector("FECHA_NACIMIENTO"),
                        lector("EXPERIENCIA"),
                        lector("NOMBRE_CIClOS")
                    )
                        voluntarios.Add(voluntario)
                    End While
                End Using
            End Using
        End Using

        Return voluntarios
    End Function



    ''Gestiones para voluntarios:
    Public Shared Function ListaCiclos() As List(Of Ciclo)

        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()

        Dim consulta As String = $"SELECT CICLOS.* FROM CICLOS"

        Dim cmdObtener As New SqlCommand(consulta, conexion)

        Dim drCiclos As SqlDataReader = cmdObtener.ExecuteReader

        Dim ciclos As New List(Of Ciclo)

        While drCiclos.Read
            Dim ciclo As New Ciclo(drCiclos("NOMBRE"))
            ciclos.Add(ciclo)
        End While

        conexion.Close()

        Return ciclos

    End Function


    ''Gestiones para filtros:
    Public Shared Function ActividadesPorCiclo(nombreCiclo As String) As List(Of Actividad)

        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()

        Dim consulta As String = $"SELECT ACTIVIDADES.* FROM ACTIVIDADES " &
                                 $"INNER JOIN (VOLUNTARIOS_ACTIVIDADES INNER JOIN " &
                                 $"(VOLUNTARIOS INNER JOIN CICLOS ON VOLUNTARIOS.NOMBRE_CICLOS=CICLOS.NOMBRE) " &
                                 $"ON VOLUNTARIOS_ACTIVIDADES.DNI_VOLUNTARIO=VOLUNTARIOS.DNI) " &
                                 $"ON ACTIVIDADES.CODACTIVIDAD=VOLUNTARIOS_ACTIVIDADES.CODACTIVIDAD " &
                                 $"WHERE CICLOS.NOMBRE='{nombreCiclo}'"

        Dim cmdObtener As New SqlCommand(consulta, conexion)

        Dim drActividad As SqlDataReader = cmdObtener.ExecuteReader

        Dim actividades As New List(Of Actividad)

        While drActividad.Read
            Dim actividad As New Actividad(drActividad("CODACTIVIDAD"), drActividad("NOMBRE"), drActividad("ESTADO"), drActividad("DIRECCION"), drActividad("MAX_PARTICIPANTES"), drActividad("FECHA_INICIO"), drActividad("FECHA_FIN"), drActividad("CIF_EMPRESA"))
            actividades.Add(actividad)
        End While

        conexion.Close()

        Return actividades

    End Function

    Public Shared Function FiltrarActividades(nombreOds As String) As List(Of Actividad)

        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()

        Dim consulta As String = $"SELECT ACTIVIDADES.* FROM ACTIVIDADES INNER JOIN (ODS_ACTIVIDAD INNER JOIN ODS ON ODS_ACTIVIDAD.NUMODS=ODS.NUMODS) ON ACTIVIDADES.CODACTIVIDAD=ODS_ACTIVIDAD.CODACTIVIDAD WHERE ODS.NOMBRE='{nombreOds}'"

        Dim cmdObtener As New SqlCommand(consulta, conexion)

        Dim drActividad As SqlDataReader = cmdObtener.ExecuteReader

        Dim actividades As New List(Of Actividad)

        While drActividad.Read
            Dim actividad As New Actividad(drActividad("CODACTIVIDAD"), drActividad("NOMBRE"), drActividad("ESTADO"), drActividad("DIRECCION"), drActividad("MAX_PARTICIPANTES"), drActividad("FECHA_INICIO"), drActividad("FECHA_FIN"), drActividad("CIF_EMPRESA"))
            actividades.Add(actividad)
        End While

        conexion.Close()

        Return actividades

    End Function

    Public Shared Function ODSPorActividad(actividad As Actividad) As List(Of Ods)
        Dim listaODS As New List(Of Ods)()

        Using conexion As New SqlConnection(cadenaConexion)
            conexion.Open()

            Dim consulta As String = "SELECT * FROM ODS WHERE NUMODS IN (SELECT NUMODS FROM ODS_ACTIVIDAD WHERE CODACTIVIDAD = @codActividad)"
            Using cmdObtener As New SqlCommand(consulta, conexion)
                cmdObtener.Parameters.AddWithValue("@codActividad", actividad.CodActividad)

                Using lector As SqlDataReader = cmdObtener.ExecuteReader()
                    While lector.Read()
                        Dim ods As New Ods(lector("NUMODS"), lector("NOMBRE"), lector("DESCRIPCION"))
                        listaODS.Add(ods)
                    End While
                End Using
            End Using
        End Using

        Return listaODS
    End Function

    Public Shared Function OrganizacionPorActividad(actividad As Actividad) As String
        Dim organizacion As String = String.Empty

        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()

        Dim consulta As String = $"SELECT ORGANIZACIONES.NOMBRE FROM ORGANIZACIONES WHERE CIF = (SELECT CIF_EMPRESA FROM ACTIVIDADES WHERE CODACTIVIDAD = '{actividad.CodActividad}')"

        Dim cmdObtener As New SqlCommand(consulta, conexion)
        Dim lector As Object = cmdObtener.ExecuteScalar

        If lector IsNot Nothing Then
            organizacion = lector.ToString
        End If
        conexion.Close()
        Return organizacion
    End Function

    Public Shared Function organizacionesLista(nombreOrgActual As String) As List(Of String)
        Dim nombres As New List(Of String)

        Using conexion As New SqlConnection(cadenaConexion)
            conexion.Open()

            Dim consulta As String = "SELECT NOMBRE FROM ORGANIZACIONES"

            Using cmdObtener As New SqlCommand(consulta, conexion)
                cmdObtener.Parameters.AddWithValue("@nombreOrgActual", nombreOrgActual)

                Using lector As SqlDataReader = cmdObtener.ExecuteReader()
                    While lector.Read()
                        nombres.Add(lector("NOMBRE").ToString())
                    End While
                End Using
            End Using
        End Using

        Return nombres
    End Function

    Public Shared Function cifOrganizacionPorNombre(nombreOrg As String) As String
        Dim cif As String = String.Empty

        Using conexion As New SqlConnection(cadenaConexion)
            conexion.Open()

            Dim consulta As String = "SELECT ORGANIZACIONES.CIF FROM ORGANIZACIONES WHERE NOMBRE = @nombreOrg"
            Using cmdObtener As New SqlCommand(consulta, conexion)
                cmdObtener.Parameters.AddWithValue("@nombreOrg", nombreOrg)

                Dim resultado As Object = cmdObtener.ExecuteScalar()

                If resultado IsNot Nothing Then
                    cif = Convert.ToString(resultado)
                End If
            End Using
        End Using

        Return cif
    End Function

    Public Shared Sub actualizarActividad(act As Actividad)

        Using conexion As New SqlConnection(cadenaConexion)
            conexion.Open()

            Dim consulta As String = "
            UPDATE ACTIVIDADES SET 
                NOMBRE = @nombre,
                ESTADO = @estado,
                DIRECCION = @direccion,
                MAX_PARTICIPANTES = @maxParticipantes,
                FECHA_INICIO = @fechaInicio,
                FECHA_FIN = @fechaFin,
                CIF_EMPRESA = @cifEmpresa
            WHERE CODACTIVIDAD = @codActividad"

            Using cmd As New SqlCommand(consulta, conexion)
                cmd.Parameters.AddWithValue("@nombre", act.Nombre)
                cmd.Parameters.AddWithValue("@estado", act.Estado)
                cmd.Parameters.AddWithValue("@direccion", act.Direccion)
                cmd.Parameters.AddWithValue("@maxParticipantes", act.Max_participantes)
                cmd.Parameters.AddWithValue("@fechaInicio", act.Fecha_incio)
                cmd.Parameters.AddWithValue("@fechaFin", act.Fecha_fin)
                cmd.Parameters.AddWithValue("@cifEmpresa", act.Cif)
                cmd.Parameters.AddWithValue("@codActividad", act.CodActividad)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Shared Function ODSNoActividad(Actividad As Actividad) As List(Of Ods)
        Dim listaODS As New List(Of Ods)()

        Using conexion As New SqlConnection(cadenaConexion)
            conexion.Open()

            Dim consulta As String = "SELECT * FROM ODS WHERE NUMODS NOT IN (SELECT NUMODS FROM ODS_ACTIVIDAD WHERE CODACTIVIDAD = @codActividad)"
            Using cmdObtener As New SqlCommand(consulta, conexion)
                cmdObtener.Parameters.AddWithValue("@codActividad", Actividad.CodActividad)

                Using lector As SqlDataReader = cmdObtener.ExecuteReader()
                    While lector.Read()
                        Dim ods As New Ods(lector("NUMODS"), lector("NOMBRE"), lector("DESCRIPCION"))
                        listaODS.Add(ods)
                    End While
                End Using
            End Using
        End Using

        Return listaODS
    End Function

    Public Shared Function voluntariosNoActividad(Actividad As Actividad) As List(Of Voluntario)
        Dim voluntarios As New List(Of Voluntario)()

        Using conexion As New SqlConnection(cadenaConexion)
            conexion.Open()

            Dim consulta As String = "
            SELECT * FROM VOLUNTARIOS
            WHERE DNI NOT IN (
                SELECT DNI_VOLUNTARIO
                FROM VOLUNTARIOS_ACTIVIDADES
                WHERE CODACTIVIDAD = @codActividad)"
            Using cmdObtener As New SqlCommand(consulta, conexion)
                cmdObtener.Parameters.AddWithValue("@codActividad", Actividad.CodActividad)

                Using lector As SqlDataReader = cmdObtener.ExecuteReader()

                    While lector.Read()
                        Dim voluntario As New Voluntario(
                                    lector("DNI").ToString(), lector("NOMBRE").ToString(), lector("APELLIDO1").ToString(),
                                    lector("APELLIDO2").ToString(), lector("CORREO").ToString(), lector("COCHE").ToString(),
                                    Convert.ToDateTime(lector("FECHA_NACIMIENTO")), lector("EXPERIENCIA").ToString(), lector("NOMBRE_CICLOS").ToString())
                        voluntarios.Add(voluntario)
                    End While
                End Using
            End Using
        End Using

        Return voluntarios
    End Function


End Class
