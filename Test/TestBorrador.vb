Imports Editorial
Module TestBorrador
    Sub main()
        Try

            Dim autor1 As New Autor(1234567, "Autor1")
            Dim borrador1 As New Borrador("Titulo Borrador", 500.0)
            autor1.addMaterial(borrador1)
            borrador1.PorcentajeEditorPorLibro = 5
            Console.WriteLine("Ganancias: {0}", borrador1.GananciaPorcentajePorAutor())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadKey()
    End Sub
End Module
