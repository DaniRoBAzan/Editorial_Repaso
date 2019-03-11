Imports Editorial
Module TestLibro

    Sub main()
        Try
            Dim autor1 As New Autor(1234567, "Autor1")
            Dim libro1 As New Libro("s1234", "Titulo Borrador", 500.0)
            autor1.addMaterial(libro1)
            libro1.PorcentajeEditorPorLibro = 5
            Console.WriteLine("Ganancias: {0}", libro1.GananciaPorcentajePorAutor())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadKey()
    End Sub

End Module
