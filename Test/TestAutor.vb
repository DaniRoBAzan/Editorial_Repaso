Imports Editorial
Module TestAutor
    Sub Main()
        Try
            Dim autor As New Autor(234234, "fa")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Try
            Dim autor As New Autor(12345678, "fabio")
            Dim libro As New Libro("s1233", "el principito", 200)
            Dim libro2 As New Libro("s1233", " princesa", 50)
            Libro.PorcentajeEditorPorLibro = 10
            autor.AddMaterial(libro)
            autor.AddMaterial(libro2)
            Console.WriteLine("Calculo ganancia: {0}", autor.CalcularGanancia)
            Console.WriteLine("Listado de materiales: ")
            For Each material In autor.GetAllMateriales()
                Console.WriteLine(material)
            Next
            autor.RemoveMaterial(libro2)
            Console.WriteLine("Listado de materiales sin libro2: ")
            For Each material In autor.GetAllMateriales()
                Console.WriteLine(material)
            Next
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.ReadKey()
    End Sub
End Module
