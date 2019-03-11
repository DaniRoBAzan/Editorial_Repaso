Imports Editorial
Module TestEditor
    Sub main()
        Try
            Dim editor As New Editor(4345234, "fa")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Dim editor As New Editor(12345678, "fabio")
            Dim borrador As New Borrador("El principito", 100)
            Dim libro As New Libro("s123", "El atajo", 100)
            editor.AddMaterial(borrador)
            editor.AddMaterial(libro)
            'borrador.Editor(editor)

            Console.WriteLine("Listado materiales: ")
            For Each material In editor.GetAllMateriales()
                Console.WriteLine(material)
            Next
            editor.RemoveMaterial(borrador)
            Console.WriteLine("Listado materiales sin borrador: ")
            For Each material In editor.GetAllMateriales()
                Console.WriteLine(material)
            Next
            Console.WriteLine("ganancia: {0}", editor.CalcularGanancia)
            Console.WriteLine(editor.ToString)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadKey()
    End Sub
End Module
