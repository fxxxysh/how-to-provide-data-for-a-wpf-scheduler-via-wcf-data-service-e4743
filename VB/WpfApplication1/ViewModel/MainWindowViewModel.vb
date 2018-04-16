Imports Microsoft.VisualBasic
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
		Private privateStartDate? As DateTime
		Public Property StartDate() As DateTime?
			Get
				Return privateStartDate
			End Get
			Set(ByVal value? As DateTime)
				privateStartDate = value
			End Set
		End Property
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
			SaveChangesCommand = New DelegateCommand(Of Object)(Function(arg) AnonymousMethod1(arg))
		End Sub
		
		Private Function AnonymousMethod1(ByVal arg As Object) As Boolean
			context.SaveChanges()
			Return True
		End Function
	End Class
End Namespace
