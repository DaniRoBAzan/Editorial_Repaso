Imports Editorial
Module TestEditor
    Sub main()
        Try
            Dim Editor As New Editor(38987098, "Nombre Editor")
            Dim libro As New Libro("s123", "Nombre Libro", 20.0)
            Dim borrador As New Borrador("Nombre Borrador", 900.0)
            Editor.addMaterial(libro)
            Editor.addMaterial(borrador)
            Editor.addMaterial(libro)
            Borrador.PorcentajeEditorPorBorrador = 5
            Libro.PorcentajeEditorPorLibro = 21
            Console.WriteLine("-> Listado de Materiales:")
            For Each material In Editor.getAllMateriales()
                Console.WriteLine("-{0} + ${1}", material.Titulo, material.MontoContrato)
            Next
            Console.WriteLine("Ganancias:" & Editor.CalcularGanancia())
            Editor.removeMaterial(libro)
            Console.WriteLine("-> Listado de Materiales eliminando un libro:")
            For Each material In Editor.getAllMateriales()
                Console.WriteLine("-{0} + ${1}", material.Titulo, material.MontoContrato)
            Next
            Console.WriteLine("Ganancias:" & Editor.CalcularGanancia())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Console.ReadKey()
    End Sub
End Module
