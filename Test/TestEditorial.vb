Imports Editorial
Module TestEditorial
    Sub main()
        Try
            Dim libro As New Libro("s1233", "La Biblia", 100)
            Dim autor As New Autor(1234456, "fabio")
            autor.AddMaterial(libro)
            Console.WriteLine("GetAutor por dni: ", Editorial.Editorial.GetAutor(14456))

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Dim libro As New Libro("s1233", "La Biblia", 100)
            Dim borrador As New Libro("s4353", "El principito", 100)
            Dim autor As New Autor(1234456, "fabio")
            autor.AddMaterial(libro)
            Editorial.Editorial.AddMaterial(libro)
            Editorial.Editorial.AddMaterial(borrador)
            Console.WriteLine("Listado de materiales: ")
            For Each m In Editorial.Editorial.GetAllMateriales()
                Console.WriteLine(m)
            Next
            Editorial.Editorial.RemoveMaterial(borrador)
            Console.WriteLine("Listado de materiales sin borrador: ")
            For Each m In Editorial.Editorial.GetAllMateriales()
                Console.WriteLine(m)
            Next
            Console.WriteLine("GetAutor por dni: ", Editorial.Editorial.GetAutor(1234456))
            Console.WriteLine("Listado de empleados: ")
            For Each m In Editorial.Editorial.GetAllEmpleados()
                Console.WriteLine(m)
            Next
        Catch ex As Exception
            Console.Write(ex.Message)
        End Try

        Console.ReadKey()
    End Sub
End Module
