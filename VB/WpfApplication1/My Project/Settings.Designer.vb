﻿' Developer Express Code Central Example:
' How to group ComboBoxEditor items
' 
' This example demonstrates how to group ComboBoxEditor items. DxEditors support
' binding to ICollectionView, so the main idea of this feature realization is the
' use of ListCollectionView. The basic logic is implemented in
' ComboBoxEditGroupingBehavior, which is attached to the editor.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4282

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.269
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace My


	<System.Runtime.CompilerServices.CompilerGeneratedAttribute()>
	<System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")>
	Friend NotInheritable Partial Class Settings
		Inherits System.Configuration.ApplicationSettingsBase

		Private Shared defaultInstance As Settings = (CType(System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings))

		Public Shared ReadOnly Property [Default]() As Settings
			Get
				Return defaultInstance
			End Get
		End Property
	End Class
End Namespace
