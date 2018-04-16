# How to provide data for a WPF Scheduler via WCF Data Service.


<p>This example illustrates how you can provide data for a WPF Scheduler via WCF Data Service.</p><p>In this sample, the ADO.NET Entity Data Model is used to create a model from SQL database tables. </p><p>This Entity Data Model is exposed by the WCF Data Service via a corresponding DataServiceContext.  </p><br />
<p>To bind a WPF SchedulerControl's AppointmentStorage and ResourcesStorage with the corresponding DataService queries, we recommend using the DataServiceCollection component.<br />
This component represents a dynamic entity collection that provides notifications when items are added, removed, or a list of items is refreshed.</p><p>Please refer to the following topics in the MSDN documentation:<br />
<a href="http://msdn.microsoft.com/en-us/library/vstudio/ee474331(v=vs.90).aspx"><u>DataServiceCollection<T> Class</u></a><br />
<a href="http://msdn.microsoft.com/en-us/library/vstudio/ee373844(v=vs.90).aspx"><u>Binding Data to Controls (ADO.NET Data Services)</u></a></p><p>To save all changes made via the WPF SchedulerControl appointment to the underlying data source, call the DataServiceContext.SaveChanges method.</p><p>In this example we used a "Car" data base provided with our Demo Center</p>

<br/>


