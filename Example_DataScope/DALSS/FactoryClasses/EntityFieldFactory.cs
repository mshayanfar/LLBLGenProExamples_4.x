﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.0
// Code is generated on: donderdag 19 juli 2012 13:46:12
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Data;
using Northwind.SSDAL;
using Northwind.SSDAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.SSDAL.FactoryClasses
{
	/// <summary>Factory class for IEntityField instances, used in IEntityFields instances.</summary>
	public static partial class EntityFieldFactory
	{
		/// <summary>Creates a new IEntityField instance for usage in the EntityFields object for the entity related to the field index specified.</summary>
		/// <param name="fieldIndex">The field which IEntityField instance should be created</param>
		/// <returns>The IEntityField instance for the field specified in fieldIndex</returns>
		public static IEntityField Create(Enum fieldIndex)
		{
			IFieldInfo info = FieldInfoProviderSingleton.GetInstance().GetFieldInfo(fieldIndex);
			return new EntityField(info, PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(info.ContainingObjectName, info.Name));
		}

		/// <summary>Creates a new IEntityField instance, which represents the field objectName.fieldName</summary>
		/// <param name="objectName">the name of the object the field belongs to, like CustomerEntity or OrdersTypedView</param>
		/// <param name="fieldName">the name of the field to create</param>
		public static IEntityField Create(string objectName, string fieldName)
        {
			return new EntityField(FieldInfoProviderSingleton.GetInstance().GetFieldInfo(objectName, fieldName), PersistenceInfoProviderSingleton.GetInstance().GetFieldPersistenceInfo(objectName, fieldName));
        }

		#region Included Code

		#endregion
	}
}