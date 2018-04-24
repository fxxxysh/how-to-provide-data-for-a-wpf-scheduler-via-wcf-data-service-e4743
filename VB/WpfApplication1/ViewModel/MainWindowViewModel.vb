Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports WpfApplication1.CarsModelService1
Imports System.Data.Services.Client
Imports System.Windows.Input
Imports DevExpress.Xpf.Core.Commands

Namespace WpfApplication1.ViewModel
    Public Class MainWindowViewModel
        Private context As CarsModelEntities

        Private privateAppointments As DataServiceCollection(Of CarScheduling)
        Public Property Appointments() As DataServiceCollection(Of CarScheduling)
            Get
                Return privateAppointments
            End Get
            Private Set(ByVal value As DataServiceCollection(Of CarScheduling))
                privateAppointments = value
            End Set
        End Property
        Private privateResources As DataServiceCollection(Of Car)
        Public Property Resources() As DataServiceCollection(Of Car)
            Get
                Return privateResources
            End Get
            Private Set(ByVal value As DataServiceCollection(Of Car))
                privateResources = value
            End Set
        End Property
        Public Property StartDate() As Date?
        Private privateSaveChangesCommand As ICommand
        Public Property SaveChangesCommand() As ICommand
            Get
                Return privateSaveChangesCommand
            End Get
            Private Set(ByVal value As ICommand)
                privateSaveChangesCommand = value
            End Set
        End Property

        Public Sub New()
            InitViewModel()
        End Sub

        Private Sub InitViewModel()
            context = New CarsModelEntities(New Uri("http://localhost:52731/CarsModelService.svc"))
            Appointments = New DataServiceCollection(Of CarScheduling)(context.CarSchedulings)
            Resources = New DataServiceCollection(Of Car)(context.Cars)
            StartDate = Appointments(0).StartTime
            SaveChangesCommand = New DelegateCommand(Of Object)(Sub(arg)
                context.SaveChanges()
            End Sub)
        End Sub
    End Class
End Namespace
