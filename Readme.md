<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128575569/18.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E381)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->
# How to show arbitrary data from the underlying datasource in a series point's label


<p>This example demonstrates how to display custom data in a series point's label. To accomplish this task, it is necessary to handle the <strong>CustomDrawSeriesPoint</strong> event, then obtain any data field via the <strong>e.SeriesPoint.Tag</strong> property, and assign a custom string to the <strong>e.LabelText</strong> value.</p>

<br/>


