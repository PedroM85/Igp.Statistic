Imports System.Data.SqlClient
Imports System.IO

Public Class SYS_Piloto


    Public cn As SqlConnection
    Public cmd As SqlCommand
    Public adaptador As SqlDataAdapter
    Public dt As DataTable
    Public rdr As SqlDataReader
    Public Property PictureBox1 As Object

    Sub New()
        Try
            cn = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=IgpManager;User ID=sa;Password=sa")
            cn.Open()


        Catch ex As Exception
            MsgBox("No estamos Conectados: " + ex.ToString)
        End Try
    End Sub

    Function Insertar(ByVal idP As Integer, ByVal Nombre As String, ByVal Nacionalidad As String, ByVal ms1 As String) As String
        Dim salida As String = "Se Guardo Correctamente"

        Try
            cmd = New SqlCommand("SYS_InsertPiloto", cn)
            cmd.CommandType = CommandType.StoredProcedure


            With cmd.Parameters
                .AddWithValue("@idP", idP)
                .AddWithValue("@nPiloto", Nombre)
                .AddWithValue("@naPiloto", Nacionalidad)
                .AddWithValue("@bPiloto", ms1)
            End With

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            salida = "No se guardo por: " + ex.ToString
        End Try

        Return salida
    End Function

    Function Delete(ByVal id As Integer) As String
        Dim Salida As String = "Se elimino el registro"
        Try
            cmd = New SqlCommand("SYS_DeletePiloto", cn)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@id", id)
            End With

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Salida = "No se elimino el registo por: " + ex.ToString
        End Try

        Return Salida
    End Function

    Sub CargarAllPiloto(ByVal dgv As DataGridView)
        Try
            cmd = New SqlCommand("SYS_SelectallPilotos", cn)
            cmd.CommandType = CommandType.StoredProcedure

            adaptador = New SqlDataAdapter
            adaptador.SelectCommand = cmd

            dt = New DataTable
            adaptador.Fill(dt)

            dgv.DataSource = dt

            With dgv
                .Columns(0).Visible = False
                .Columns(1).Visible = True
                .Columns(1).Width = 50

                '.Columns(1).HeaderText = "Piloto"
                '.Columns(1).Width = 150%
                '.Columns(2).HeaderText = "Nacion"
                .Columns(2).Width = 150%
                '.Columns(3).HeaderText = "Bandera"
                .Columns(3).Width = 130
                .Columns(4).Width = 70


                'Dim counter As Integer

                Dim imagecol As New DataGridViewImageColumn

                .Columns.Insert(5, imagecol)
                .CurrentRow.Cells(imagecol).Value = Image.FromFile(Application.StartupPath("\Venezuela.jgp"))


                Dim Img As Image = Image.FromFile(Application.StartupPath("\Venezuela.jgp"))
                .Rows.Add(imagecol, Img)


                'For counter = 0 To dt.Rows.Count - 1
                '    imagecol.Image = Image.FromFile(dt.Rows(counter).Item(4).ToString())
                'Next


            End With

            'dgv.CurrentRow.Cells(imagecol).Value = Image.FromFile(Application.StartupPath "\Venezuela.jgp")

        Catch ex As Exception

        End Try
    End Sub

    Sub CorrelativoP()
        Dim value As String = "0000"
        Dim Num As Integer = 0
        Dim aa, aa1 As String
        Try

            cmd = New SqlCommand("select max(id) from SYS_Piloto", cn)
            If (IsDBNull(cmd.ExecuteScalar)) Then
                Num = 1
                aa = Num.ToString
                aa1 = "EMP-" + Num.ToString
            Else
                Num = cmd.ExecuteScalar + 1
                aa = Num.ToString
                'aa1 = "EMP-" + Num.ToString
            End If




        Catch ex As Exception

        End Try

    End Sub

    Function corre()
        Dim value As String = "0000"
        Dim Num As Integer = 0
        Dim aa, aa1 As String
        Try

            cmd = New SqlCommand("select max(id) from SYS_Piloto", cn)
            If (IsDBNull(cmd.ExecuteScalar)) Then
                Num = 1
                aa = Num.ToString
                aa1 = "EMP-" + Num.ToString
            Else
                Num = cmd.ExecuteScalar + 1
                aa = Num.ToString
                'aa1 = "EMP-" + Num.ToString
            End If



        Catch ex As Exception

        End Try

        Return aa
    End Function

End Class
