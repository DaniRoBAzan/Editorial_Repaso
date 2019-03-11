Imports Editorial
Module TestLibro
    Sub main()
        Try
            Dim libro As New Libro("s34", "El", 200)
            Dim autor As New Autor(12345678, "Gustavo")
            libro.AddAutor(Autor)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Dim libro As New Libro("s1234", "El principito", 200)
            Dim autor As New Autor(12345678, "Gustavo")
            Dim autor2 As New Autor(2344578, "Luciano")
            libro.AddAutor(autor)
            libro.AddAutor(autor2)
            Console.WriteLine("Listado autores:")
            For Each m In libro.GetAllAutores()
                Console.WriteLine(m)
            Next
            Console.WriteLine("ganancia % x autor: {0}", libro.GananciaPorcentajePorAutor())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadKey()

    End Sub
End Module
