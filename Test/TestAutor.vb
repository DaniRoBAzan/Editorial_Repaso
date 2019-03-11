Imports Editorial
Module TestAutor
    Sub main()
        Try
            Dim autor As New Autor(0, "Nombre Autor")
            Console.WriteLine()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Dim autor As New Autor(123455432, "")
            Console.WriteLine()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Dim autor As New Autor(123455432, "Nombre Autor")
            Dim libro As New Libro("s1234", "Titulo Libro", 600.0)
            Dim Borrador As New Borrador("Titulo Borrador", 200.0)
            autor.addMaterial(libro)
            autor.addMaterial(Borrador)
            Console.WriteLine("-> Listado de Materiales:")
            For Each material In autor.getAllMateriales()
                Console.WriteLine("-{0} + {1}", material.Titulo, material.MontoContrato)
            Next
            Console.WriteLine("Ganancias:" & autor.CalcularGanancia())
            autor.removeMaterial(libro)
            Console.WriteLine("-> Listado de Materiales sin libro:")
            For Each material In autor.getAllMateriales()
                Console.WriteLine("-{0} + {1}", material.Titulo, material.MontoContrato)
            Next
            Console.WriteLine("Ganancias:" & autor.CalcularGanancia())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try


        Console.ReadKey()
    End Sub
End Module
