Module PatientData
    Public Patients As New List(Of Patient)
End Module

Public Class Patient
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Age As Integer
    Public Property Gender As String
    Public Property Height As Integer
    Public Property Weight As Integer
    Public Property ContactNum As String
    Public Property BloodType As String
    Public Property Allergies As String
    Public Property MedicalConditions As String
    Public Property EmergencyContact As String

    ' Computed full name property
    Public ReadOnly Property FullName As String
        Get
            Return $"{FirstName} {LastName}"
        End Get
    End Property
End Class
