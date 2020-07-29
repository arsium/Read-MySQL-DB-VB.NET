Imports System.Security.Cryptography
Imports MySql.Data
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Form1
    ''''Thx to : http://zetcode.com/csharp/mysql/ to help me in my researches , the code is in C# !!
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim server As String = "server=192.168.0.16;userid=arsium;password=123456;database=testdb;"
        ''So here is the url to your db , default userid is "root" and password is empty like : "server=192.168.0.16;userid=root;password=;database=tuto;"
        ''192.168.0.16 is the local ip of my other computer
        Using dataDBConnection = New MySqlConnection(server)

            dataDBConnection.Open()

            ' MessageBox.Show(ze.ServerVersion)


            Dim o As String = "SELECT * FROM tutoytb"
            '' the membre is your table so let's rename

            Using ExecuteCMD = New MySqlCommand(o, dataDBConnection)

                Using i = ExecuteCMD.ExecuteReader
                    'so as you can see,there are so many dependencies !
                    Dim hashzz As New System.Security.Cryptography.SHA256Managed
                    '123456789 is the password 
                    '  MessageBox.Show(GetHash(hashzz, TextBox2.Text))
                    '' so you will get an array of 4 strings : ID = 0 , Name = 1 , Password = 2 and email = 3
                    While i.Read
                        'i is the table being read so i(1) = name 
                        If TB_Name.Text = i(1).ToString And GetHash(hashzz, TB_Pass.Text) = i(2).ToString.ToLower Then
                            'getHash comes from microsoft and allow me to return the hash :hashzz in string
                            MessageBox.Show("Connected !" & " ID = " & i(0) & " Email = " & i(3))
                            'so let's  test
                            'as you see, it works , let's add many users  now !
                            'usertest  : testpassword

                            'id is auto incrementing and is my primary lign (when I've created my table I did so but you canchange  , like you want !
                            'note that you do not need to re-generate your app to distribute it , just add users in your DB !!
                            'hope it will help you!
                            'You can ask me for help if needed !!!
                        End If
                    End While
                End Using




            End Using
        End Using
    End Sub



    ''https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.hashalgorithm.transformblock?view=netcore-3.1
    Private Function GetHash(ByVal hashAlgorithm As HashAlgorithm, ByVal input As String) As String

        ' Convert the input string to a byte array and compute the hash.
        Dim data As Byte() = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input))

        ' Create a new Stringbuilder to collect the bytes
        ' and create a string.
        Dim sBuilder As New StringBuilder()

        ' Loop through each byte of the hashed data 
        ' and format each one as a hexadecimal string.
        For i As Integer = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next

        ' Return the hexadecimal string.
        Return sBuilder.ToString()
    End Function
End Class
