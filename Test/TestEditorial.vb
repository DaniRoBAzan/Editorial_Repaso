Imports Editorial
Module TestEditorial
    Sub main()
        Dim autor1 As New Autor(1234567, "fabio")
        Dim autor2 As New Autor(2341232, "denher")
        Dim editor1 As New Editor(13211211, "coky")
        Dim libro1 As New Libro("asd123", "librito", 3000)
        Dim borrador1 As New Borrador("borradorsin", 5000)
        Dim borrador2 As New Borrador("borram", 2000)
        autor1.addMaterial(libro1)
        autor1.addMaterial(borrador1)
        autor1.addMaterial(borrador2)
        autor1.addMaterial(libro1)
        autor1.addMaterial(borrador1)
        autor1.addMaterial(borrador2)
        editor1.addMaterial(libro1)
        editor1.addMaterial(borrador1)
        Editorial.Editorial.AddMaterial(libro1)
        Editorial.Editorial.AddMaterial(borrador1)
        Editorial.Editorial.AddMaterial(borrador2)
        Console.WriteLine("listado de materiales:")
        For Each material In Editorial.Editorial.GetAllMateriales()
            Console.WriteLine(material)
        Next
        Editorial.Editorial.RemoveMaterial(borrador2)
        Console.WriteLine("listado de materiales sin borrador2:")
        For Each material In Editorial.Editorial.GetAllMateriales()
            Console.WriteLine(material)
        Next
        Console.WriteLine("listado de materiales del autor1: ")
        For Each material In Editorial.Editorial.GetAllMateriales(autor1)
            Console.WriteLine(material)
        Next
        Console.WriteLine("Autor con dni 1234567: {0}", Editorial.Editorial.GetAutor(1234567))
        Console.WriteLine("listado de empleados:")
        For Each empleado In Editorial.Editorial.GetAllEmpleados()
            Console.WriteLine(empleado)
        Next
        Console.ReadKey()
    End Sub
End Module
