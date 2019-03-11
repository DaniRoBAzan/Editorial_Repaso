Imports Editorial
Module TestBorrador
    Sub main()
        Try
            Dim borrador As New Borrador("fa", 100)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Dim borrador As New Borrador("El principito", 100)
            Dim autor As New Autor(1234456, "fabio")
            borrador.AddAutor(autor)
            Console.WriteLine("ganancia editor: {0}", borrador.GananciaEditor())
            Console.WriteLine("ganancia % autor: {0}", borrador.GananciaPorcentajePorAutor())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadKey()

    End Sub
End Module
