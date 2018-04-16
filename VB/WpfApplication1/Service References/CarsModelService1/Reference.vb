'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18010
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

' Original file name:
' Generation date: 6/21/2013 6:52:03 PM

Imports Microsoft.VisualBasic
Imports System
Namespace WpfApplication1.CarsModelService1

	''' <summary>
	''' There are no comments for CarsModelEntities in the schema.
	''' </summary>
	Partial Public Class CarsModelEntities
		Inherits System.Data.Services.Client.DataServiceContext
		''' <summary>
		''' Initialize a new CarsModelEntities object.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Sub New(ByVal serviceRoot As Global.System.Uri)
			MyBase.New(serviceRoot)
			Me.ResolveName = New Global.System.Func(Of Global.System.Type, String)(AddressOf Me.ResolveNameFromType)
			Me.ResolveType = New Global.System.Func(Of String, Global.System.Type)(AddressOf Me.ResolveTypeFromName)
			Me.OnContextCreated()
		End Sub
		Partial Private Sub OnContextCreated()
		End Sub
		''' <summary>
		''' Since the namespace configured for this service reference
		''' in Visual Studio is different from the one indicated in the
		''' server schema, use type-mappers to map between the two.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Protected Function ResolveTypeFromName(ByVal typeName As String) As Global.System.Type
			If typeName.StartsWith("CarsModelModel", Global.System.StringComparison.Ordinal) Then
				Return Me.GetType().Assembly.GetType(String.Concat("WpfApplication1.CarsModelService1", typeName.Substring(14)), False)
			End If
			Return Nothing
		End Function
		''' <summary>
		''' Since the namespace configured for this service reference
		''' in Visual Studio is different from the one indicated in the
		''' server schema, use type-mappers to map between the two.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Protected Function ResolveNameFromType(ByVal clientType As Global.System.Type) As String
			If clientType.Namespace.Equals("WpfApplication1.CarsModelService1", Global.System.StringComparison.Ordinal) Then
				Return String.Concat("CarsModelModel.", clientType.Name)
			End If
			Return Nothing
		End Function
		''' <summary>
		''' There are no comments for Cars in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public ReadOnly Property Cars() As Global.System.Data.Services.Client.DataServiceQuery(Of Car)
			Get
				If (Me._Cars Is Nothing) Then
					Me._Cars = MyBase.CreateQuery(Of Car)("Cars")
				End If
				Return Me._Cars
			End Get
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _Cars As Global.System.Data.Services.Client.DataServiceQuery(Of Car)
		''' <summary>
		''' There are no comments for CarSchedulings in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public ReadOnly Property CarSchedulings() As Global.System.Data.Services.Client.DataServiceQuery(Of CarScheduling)
			Get
				If (Me._CarSchedulings Is Nothing) Then
					Me._CarSchedulings = MyBase.CreateQuery(Of CarScheduling)("CarSchedulings")
				End If
				Return Me._CarSchedulings
			End Get
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _CarSchedulings As Global.System.Data.Services.Client.DataServiceQuery(Of CarScheduling)
		''' <summary>
		''' There are no comments for Cars in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Sub AddToCars(ByVal car As Car)
			MyBase.AddObject("Cars", car)
		End Sub
		''' <summary>
		''' There are no comments for CarSchedulings in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Sub AddToCarSchedulings(ByVal carScheduling As CarScheduling)
			MyBase.AddObject("CarSchedulings", carScheduling)
		End Sub
	End Class
	''' <summary>
	''' There are no comments for CarsModelModel.Car in the schema.
	''' </summary>
	''' <KeyProperties>
	''' ID
	''' </KeyProperties>
	<Global.System.Data.Services.Common.EntitySetAttribute("Cars"), Global.System.Data.Services.Common.DataServiceKeyAttribute("ID")> _
	Partial Public Class Car
		Implements System.ComponentModel.INotifyPropertyChanged
		''' <summary>
		''' Create a new Car object.
		''' </summary>
		''' <param name="ID">Initial value of ID.</param>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Shared Function CreateCar(ByVal ID As Integer) As Car
			Dim car As New Car()
			car.ID = ID
			Return car
		End Function
		''' <summary>
		''' There are no comments for Property ID in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property ID() As Integer
			Get
				Return Me._ID
			End Get
			Set(ByVal value As Integer)
				Me.OnIDChanging(value)
				Me._ID = value
				Me.OnIDChanged()
				Me.OnPropertyChanged("ID")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _ID As Integer
		Partial Private Sub OnIDChanging(ByVal value As Integer)
		End Sub
		Partial Private Sub OnIDChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Trademark in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property Trademark() As String
			Get
				Return Me._Trademark
			End Get
			Set(ByVal value As String)
				Me.OnTrademarkChanging(value)
				Me._Trademark = value
				Me.OnTrademarkChanged()
				Me.OnPropertyChanged("Trademark")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _Trademark As String
		Partial Private Sub OnTrademarkChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnTrademarkChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Model in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property Model() As String
			Get
				Return Me._Model
			End Get
			Set(ByVal value As String)
				Me.OnModelChanging(value)
				Me._Model = value
				Me.OnModelChanged()
				Me.OnPropertyChanged("Model")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _Model As String
		Partial Private Sub OnModelChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnModelChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property HP in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property HP() As Short?
			Get
				Return Me._HP
			End Get
			Set(ByVal value? As Short)
				Me.OnHPChanging(value)
				Me._HP = value
				Me.OnHPChanged()
				Me.OnPropertyChanged("HP")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _HP? As Short
		Partial Private Sub OnHPChanging(ByVal value? As Short)
		End Sub
		Partial Private Sub OnHPChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Liter in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property Liter() As Double?
			Get
				Return Me._Liter
			End Get
			Set(ByVal value? As Double)
				Me.OnLiterChanging(value)
				Me._Liter = value
				Me.OnLiterChanged()
				Me.OnPropertyChanged("Liter")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _Liter? As Double
		Partial Private Sub OnLiterChanging(ByVal value? As Double)
		End Sub
		Partial Private Sub OnLiterChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Cyl in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property Cyl() As Byte?
			Get
				Return Me._Cyl
			End Get
			Set(ByVal value? As Byte)
				Me.OnCylChanging(value)
				Me._Cyl = value
				Me.OnCylChanged()
				Me.OnPropertyChanged("Cyl")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _Cyl? As Byte
		Partial Private Sub OnCylChanging(ByVal value? As Byte)
		End Sub
		Partial Private Sub OnCylChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property TransmissSpeedCount in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property TransmissSpeedCount() As Byte?
			Get
				Return Me._TransmissSpeedCount
			End Get
			Set(ByVal value? As Byte)
				Me.OnTransmissSpeedCountChanging(value)
				Me._TransmissSpeedCount = value
				Me.OnTransmissSpeedCountChanged()
				Me.OnPropertyChanged("TransmissSpeedCount")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _TransmissSpeedCount? As Byte
		Partial Private Sub OnTransmissSpeedCountChanging(ByVal value? As Byte)
		End Sub
		Partial Private Sub OnTransmissSpeedCountChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property TransmissAutomatic in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property TransmissAutomatic() As String
			Get
				Return Me._TransmissAutomatic
			End Get
			Set(ByVal value As String)
				Me.OnTransmissAutomaticChanging(value)
				Me._TransmissAutomatic = value
				Me.OnTransmissAutomaticChanged()
				Me.OnPropertyChanged("TransmissAutomatic")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _TransmissAutomatic As String
		Partial Private Sub OnTransmissAutomaticChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnTransmissAutomaticChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property MPG_City in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property MPG_City() As Byte?
			Get
				Return Me._MPG_City
			End Get
			Set(ByVal value? As Byte)
				Me.OnMPG_CityChanging(value)
				Me._MPG_City = value
				Me.OnMPG_CityChanged()
				Me.OnPropertyChanged("MPG_City")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _MPG_City? As Byte
		Partial Private Sub OnMPG_CityChanging(ByVal value? As Byte)
		End Sub
		Partial Private Sub OnMPG_CityChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property MPG_Highway in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property MPG_Highway() As Byte?
			Get
				Return Me._MPG_Highway
			End Get
			Set(ByVal value? As Byte)
				Me.OnMPG_HighwayChanging(value)
				Me._MPG_Highway = value
				Me.OnMPG_HighwayChanged()
				Me.OnPropertyChanged("MPG_Highway")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _MPG_Highway? As Byte
		Partial Private Sub OnMPG_HighwayChanging(ByVal value? As Byte)
		End Sub
		Partial Private Sub OnMPG_HighwayChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Category in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property Category() As String
			Get
				Return Me._Category
			End Get
			Set(ByVal value As String)
				Me.OnCategoryChanging(value)
				Me._Category = value
				Me.OnCategoryChanged()
				Me.OnPropertyChanged("Category")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _Category As String
		Partial Private Sub OnCategoryChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnCategoryChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Description in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property Description() As String
			Get
				Return Me._Description
			End Get
			Set(ByVal value As String)
				Me.OnDescriptionChanging(value)
				Me._Description = value
				Me.OnDescriptionChanged()
				Me.OnPropertyChanged("Description")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _Description As String
		Partial Private Sub OnDescriptionChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnDescriptionChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Hyperlink in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property Hyperlink() As String
			Get
				Return Me._Hyperlink
			End Get
			Set(ByVal value As String)
				Me.OnHyperlinkChanging(value)
				Me._Hyperlink = value
				Me.OnHyperlinkChanged()
				Me.OnPropertyChanged("Hyperlink")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _Hyperlink As String
		Partial Private Sub OnHyperlinkChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnHyperlinkChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Picture in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property Picture() As Byte()
			Get
				If (Me._Picture IsNot Nothing) Then
					Return (CType(Me._Picture.Clone(), Byte()))
				Else
					Return Nothing
				End If
			End Get
			Set(ByVal value As Byte())
				Me.OnPictureChanging(value)
				Me._Picture = value
				Me.OnPictureChanged()
				Me.OnPropertyChanged("Picture")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _Picture() As Byte
		Partial Private Sub OnPictureChanging(ByVal value() As Byte)
		End Sub
		Partial Private Sub OnPictureChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Price in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property Price() As Decimal?
			Get
				Return Me._Price
			End Get
			Set(ByVal value? As Decimal)
				Me.OnPriceChanging(value)
				Me._Price = value
				Me.OnPriceChanged()
				Me.OnPropertyChanged("Price")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _Price? As Decimal
		Partial Private Sub OnPriceChanging(ByVal value? As Decimal)
		End Sub
		Partial Private Sub OnPriceChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property RtfContent in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property RtfContent() As String
			Get
				Return Me._RtfContent
			End Get
			Set(ByVal value As String)
				Me.OnRtfContentChanging(value)
				Me._RtfContent = value
				Me.OnRtfContentChanged()
				Me.OnPropertyChanged("RtfContent")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _RtfContent As String
		Partial Private Sub OnRtfContentChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnRtfContentChanged()
		End Sub
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Event PropertyChanged As Global.System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Protected Overridable Sub OnPropertyChanged(ByVal [property] As String)
			If (Me.PropertyChangedEvent IsNot Nothing) Then
				RaiseEvent PropertyChanged(Me, New Global.System.ComponentModel.PropertyChangedEventArgs([property]))
			End If
		End Sub
	End Class
	''' <summary>
	''' There are no comments for CarsModelModel.CarScheduling in the schema.
	''' </summary>
	''' <KeyProperties>
	''' ID
	''' </KeyProperties>
	<Global.System.Data.Services.Common.EntitySetAttribute("CarSchedulings"), Global.System.Data.Services.Common.DataServiceKeyAttribute("ID")> _
	Partial Public Class CarScheduling
		Implements System.ComponentModel.INotifyPropertyChanged
		''' <summary>
		''' Create a new CarScheduling object.
		''' </summary>
		''' <param name="ID">Initial value of ID.</param>
		''' <param name="allDay">Initial value of AllDay.</param>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Shared Function CreateCarScheduling(ByVal ID As Integer, ByVal allDay As Boolean) As CarScheduling
			Dim carScheduling As New CarScheduling()
			carScheduling.ID = ID
			carScheduling.AllDay = allDay
			Return carScheduling
		End Function
		''' <summary>
		''' There are no comments for Property ID in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property ID() As Integer
			Get
				Return Me._ID
			End Get
			Set(ByVal value As Integer)
				Me.OnIDChanging(value)
				Me._ID = value
				Me.OnIDChanged()
				Me.OnPropertyChanged("ID")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _ID As Integer
		Partial Private Sub OnIDChanging(ByVal value As Integer)
		End Sub
		Partial Private Sub OnIDChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property CarId in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property CarId() As Integer?
			Get
				Return Me._CarId
			End Get
			Set(ByVal value? As Integer)
				Me.OnCarIdChanging(value)
				Me._CarId = value
				Me.OnCarIdChanged()
				Me.OnPropertyChanged("CarId")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _CarId? As Integer
		Partial Private Sub OnCarIdChanging(ByVal value? As Integer)
		End Sub
		Partial Private Sub OnCarIdChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property UserId in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property UserId() As Integer?
			Get
				Return Me._UserId
			End Get
			Set(ByVal value? As Integer)
				Me.OnUserIdChanging(value)
				Me._UserId = value
				Me.OnUserIdChanged()
				Me.OnPropertyChanged("UserId")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _UserId? As Integer
		Partial Private Sub OnUserIdChanging(ByVal value? As Integer)
		End Sub
		Partial Private Sub OnUserIdChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Status in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property Status() As Integer?
			Get
				Return Me._Status
			End Get
			Set(ByVal value? As Integer)
				Me.OnStatusChanging(value)
				Me._Status = value
				Me.OnStatusChanged()
				Me.OnPropertyChanged("Status")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _Status? As Integer
		Partial Private Sub OnStatusChanging(ByVal value? As Integer)
		End Sub
		Partial Private Sub OnStatusChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Subject in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property Subject() As String
			Get
				Return Me._Subject
			End Get
			Set(ByVal value As String)
				Me.OnSubjectChanging(value)
				Me._Subject = value
				Me.OnSubjectChanged()
				Me.OnPropertyChanged("Subject")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _Subject As String
		Partial Private Sub OnSubjectChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnSubjectChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Description in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property Description() As String
			Get
				Return Me._Description
			End Get
			Set(ByVal value As String)
				Me.OnDescriptionChanging(value)
				Me._Description = value
				Me.OnDescriptionChanged()
				Me.OnPropertyChanged("Description")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _Description As String
		Partial Private Sub OnDescriptionChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnDescriptionChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Label in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property Label() As Integer?
			Get
				Return Me._Label
			End Get
			Set(ByVal value? As Integer)
				Me.OnLabelChanging(value)
				Me._Label = value
				Me.OnLabelChanged()
				Me.OnPropertyChanged("Label")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _Label? As Integer
		Partial Private Sub OnLabelChanging(ByVal value? As Integer)
		End Sub
		Partial Private Sub OnLabelChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property StartTime in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property StartTime() As Global.System.DateTime?
			Get
				Return Me._StartTime
			End Get
			Set(ByVal value? As System.DateTime)
				Me.OnStartTimeChanging(value)
				Me._StartTime = value
				Me.OnStartTimeChanged()
				Me.OnPropertyChanged("StartTime")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _StartTime? As Global.System.DateTime
		Partial Private Sub OnStartTimeChanging(ByVal value? As Global.System.DateTime)
		End Sub
		Partial Private Sub OnStartTimeChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property EndTime in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property EndTime() As Global.System.DateTime?
			Get
				Return Me._EndTime
			End Get
			Set(ByVal value? As System.DateTime)
				Me.OnEndTimeChanging(value)
				Me._EndTime = value
				Me.OnEndTimeChanged()
				Me.OnPropertyChanged("EndTime")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _EndTime? As Global.System.DateTime
		Partial Private Sub OnEndTimeChanging(ByVal value? As Global.System.DateTime)
		End Sub
		Partial Private Sub OnEndTimeChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Location in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property Location() As String
			Get
				Return Me._Location
			End Get
			Set(ByVal value As String)
				Me.OnLocationChanging(value)
				Me._Location = value
				Me.OnLocationChanged()
				Me.OnPropertyChanged("Location")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _Location As String
		Partial Private Sub OnLocationChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnLocationChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property AllDay in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property AllDay() As Boolean
			Get
				Return Me._AllDay
			End Get
			Set(ByVal value As Boolean)
				Me.OnAllDayChanging(value)
				Me._AllDay = value
				Me.OnAllDayChanged()
				Me.OnPropertyChanged("AllDay")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _AllDay As Boolean
		Partial Private Sub OnAllDayChanging(ByVal value As Boolean)
		End Sub
		Partial Private Sub OnAllDayChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property EventType in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property EventType() As Integer?
			Get
				Return Me._EventType
			End Get
			Set(ByVal value? As Integer)
				Me.OnEventTypeChanging(value)
				Me._EventType = value
				Me.OnEventTypeChanged()
				Me.OnPropertyChanged("EventType")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _EventType? As Integer
		Partial Private Sub OnEventTypeChanging(ByVal value? As Integer)
		End Sub
		Partial Private Sub OnEventTypeChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property RecurrenceInfo in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property RecurrenceInfo() As String
			Get
				Return Me._RecurrenceInfo
			End Get
			Set(ByVal value As String)
				Me.OnRecurrenceInfoChanging(value)
				Me._RecurrenceInfo = value
				Me.OnRecurrenceInfoChanged()
				Me.OnPropertyChanged("RecurrenceInfo")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _RecurrenceInfo As String
		Partial Private Sub OnRecurrenceInfoChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnRecurrenceInfoChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property ReminderInfo in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property ReminderInfo() As String
			Get
				Return Me._ReminderInfo
			End Get
			Set(ByVal value As String)
				Me.OnReminderInfoChanging(value)
				Me._ReminderInfo = value
				Me.OnReminderInfoChanged()
				Me.OnPropertyChanged("ReminderInfo")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _ReminderInfo As String
		Partial Private Sub OnReminderInfoChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnReminderInfoChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property Price in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property Price() As Decimal?
			Get
				Return Me._Price
			End Get
			Set(ByVal value? As Decimal)
				Me.OnPriceChanging(value)
				Me._Price = value
				Me.OnPriceChanged()
				Me.OnPropertyChanged("Price")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _Price? As Decimal
		Partial Private Sub OnPriceChanging(ByVal value? As Decimal)
		End Sub
		Partial Private Sub OnPriceChanged()
		End Sub
		''' <summary>
		''' There are no comments for Property ContactInfo in the schema.
		''' </summary>
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Property ContactInfo() As String
			Get
				Return Me._ContactInfo
			End Get
			Set(ByVal value As String)
				Me.OnContactInfoChanging(value)
				Me._ContactInfo = value
				Me.OnContactInfoChanged()
				Me.OnPropertyChanged("ContactInfo")
			End Set
		End Property
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Private _ContactInfo As String
		Partial Private Sub OnContactInfoChanging(ByVal value As String)
		End Sub
		Partial Private Sub OnContactInfoChanged()
		End Sub
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Public Event PropertyChanged As Global.System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
		<System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")> _
		Protected Overridable Sub OnPropertyChanged(ByVal [property] As String)
			If (Me.PropertyChangedEvent IsNot Nothing) Then
				RaiseEvent PropertyChanged(Me, New Global.System.ComponentModel.PropertyChangedEventArgs([property]))
			End If
		End Sub
	End Class
End Namespace