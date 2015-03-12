Module Module1

    Class CompanyInfo
        Public companyName As String
        Public companyOwner As String
        Public companyContactNumber As New Integer
        Public companyAddress As New Integer
        Public hourlyRate As New Integer

    End Class
    Dim company As New CompanyInfo



    Sub IntroductionPage()


        'A welcoming intro
        Console.SetCursorPosition(25, 1)
        Console.WriteLine("Welcome to Fun With Lawns v0.1")
        Console.SetCursorPosition(20, 2)
        Console.WriteLine("Your all in one lawn management system.")
        Console.WriteLine()
        Console.SetCursorPosition(25, 4)
        Console.WriteLine("Press any key to continue...")

        Console.ReadKey()

        MakeCompany()

    End Sub

    Sub MakeCompany()

        'If no prior use, will tell you and let you set up profile

        Console.Clear()

        Console.WriteLine("No company information has been provided. We'll set up a profil before we begin.")
        Console.WriteLine()
        Console.WriteLine("Press any key to continue...")

        Console.ReadKey()

        ProfileSetUp()

    End Sub

    Sub ProfileSetUp()
        Console.Clear()

        'Setting up company information

        Console.WriteLine("Enter your company details:")
        Console.WriteLine()
        Console.Write("Company name: ")
        company.companyName = Console.ReadLine


        Console.Write("Company owner: ")
        company.companyOwner = Console.ReadLine


        Console.Write("Company contact number: ")
        company.companyContactNumber = Console.ReadLine

        Console.Write("Company address: ")
        company.companyAddress = Console.ReadLine

        Console.Write("Company hourly rate: ")
        company.hourlyRate = Console.ReadLine




        Console.ReadLine()


    End Sub

    Sub MainMenu()
        Console.WriteLine("Main menu")

    End Sub




    Sub Main()
        IntroductionPage()

    End Sub

End Module
