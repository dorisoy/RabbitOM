﻿using System;
using System.Collections.Generic;

namespace RabbitOM.Net.Sdp
{
	/// <summary>
	/// Represent the collection for phone field
	/// </summary>
	public sealed class PhoneFieldCollection : FieldCollection<PhoneField>
	{
		private readonly FieldCollectionInternal<PhoneField> _collection = new FieldCollectionInternal<PhoneField>();




		/// <summary>
		/// Initialize a new instance of the collection
		/// </summary>
		public PhoneFieldCollection()
		{
		}

		/// <summary>
		/// Initialize a new instance of the collection
		/// </summary>
		/// <param name="fields">the collection of field</param>
		public PhoneFieldCollection(IEnumerable<PhoneField> fields)
		{
			AddRange(fields);
		}




		/// <summary>
		/// Gets a field
		/// </summary>
		/// <param name="index">the index</param>
		/// <returns>returns an instance</returns>
		public override PhoneField this[int index]
		{
			get => _collection[index];
		}






		/// <summary>
		/// Gets the sync root
		/// </summary>
		public override object SyncRoot
		{
			get => _collection.SyncRoot;
		}

		/// <summary>
		/// Check if the collection is thread safe
		/// </summary>
		public override bool IsSynchronized
		{
			get => _collection.IsSynchronized;
		}

		/// <summary>
		/// Check if the collection is just a read only collection
		/// </summary>
		public override bool IsReadOnly
		{
			get => _collection.IsReadOnly;
		}

		/// <summary>
		/// Check if the collection is empty
		/// </summary>
		public override bool IsEmpty
		{
			get => _collection.IsEmpty;
		}

		/// <summary>
		/// Gets the number of fields
		/// </summary>
		public override int Count
		{
			get => _collection.Count;
		}





		/// <summary>
		/// Add a field
		/// <param name="field">the field</param>
		/// </summary>
		public override void Add(PhoneField field)
		{
			_collection.Add(field);
		}

		/// <summary>
		/// Add a collection of field
		/// </summary>
		/// <param name="fields">the field collection</param>
		public override void AddRange(IEnumerable<PhoneField> fields)
		{
			_collection.AddRange(fields);
		}

		/// <summary>
		/// Remove all fields
		/// </summary>
		public override void Clear()
		{
			_collection.Clear();
		}

		/// <summary>
		/// Check if a field exists
		/// </summary>
		/// <param name="field">the field</param>
		/// <returns>returns true for a success, otherwise false</returns>
		public override bool Contains(PhoneField field)
		{
			return _collection.Contains(field);
		}

		/// <summary>
		/// Copy the content to an array
		/// </summary>
		/// <param name="array">the target array</param>
		/// <param name="arrayIndex">the start index to begin the copy</param>
		public override void CopyTo(Array array, int arrayIndex)
		{
			_collection.CopyTo(array, arrayIndex);
		}

		/// <summary>
		/// Copy the content to an array
		/// </summary>
		/// <param name="array">the target array</param>
		/// <param name="arrayIndex">the start index to begin the copy</param>
		public override void CopyTo(PhoneField[] array, int arrayIndex)
		{
			_collection.CopyTo(array, arrayIndex);
		}

		/// <summary>
		/// Remove an existing field
		/// </summary>
		/// <param name="field">the field</param>
		/// <returns>returns true for a success, otherwis false</returns>
		public override bool Remove(PhoneField field)
		{
			return _collection.Remove(field);
		}

		/// <summary>
		/// Remove all fields
		/// </summary>
		/// <param name="fields">a field collection</param>
		/// <returns>returns the number of fields removed</returns>
		public override int RemoveAll(IEnumerable<PhoneField> fields)
		{
			return _collection.RemoveAll(fields);
		}

		/// <summary>
		/// Remove all fields
		/// </summary>
		/// <param name="predicate">the predicate that select the fields to be removed</param>
		/// <returns>returns the number of fields removed</returns>
		public override int RemoveAll(Predicate<PhoneField> predicate)
		{
			return _collection.RemoveAll(predicate);
		}

		/// <summary>
		/// Gets the enumerator
		/// </summary>
		/// <returns>returns an enumerator</returns>
		public override IEnumerator<PhoneField> GetEnumerator()
		{
			return _collection.GetEnumerator();
		}

		/// <summary>
		/// Gets a field at the desired index
		/// </summary>
		/// <param name="index">the index</param>
		/// <returns>returns an instance</returns>
		public override PhoneField GetAt(int index)
		{
			return _collection.GetAt(index);
		}

		/// <summary>
		/// Find a field at the desired index
		/// </summary>
		/// <param name="index">the index</param>
		/// <returns>returns an instance, otherwise null is return</returns>
		public override PhoneField FindAt(int index)
		{
			return _collection.FindAt(index);
		}

		/// <summary>
		/// Find all fields
		/// </summary>
		/// <param name="predicate">the predicate used for selection</param>
		/// <returns>returns a collection of field</returns>
		public override IEnumerable<PhoneField> FindAll(Predicate<PhoneField> predicate)
		{
			return _collection.FindAll(predicate);
		}

		/// <summary>
		/// Try to add a field
		/// </summary>
		/// <param name="field">the field</param>
		/// <returns>returns true for a success, otherwise false</returns>
		public override bool TryAdd(PhoneField field)
		{
			return _collection.TryAdd(field);
		}

		/// <summary>
		/// Try to add a collection of fields
		/// </summary>
		/// <param name="fields">the collection of fields</param>
		/// <returns>returns true for a success, otherwise false</returns>
		public override bool TryAddRange(IEnumerable<PhoneField> fields)
		{
			return _collection.TryAddRange(fields);
		}

		/// <summary>
		/// Try to add a collection of fields
		/// </summary>
		/// <param name="fields">the collection of fields</param>
		/// <param name="result">the number of fields added</param>
		/// <returns>returns true for a success, otherwise false</returns>
		public override bool TryAddRange(IEnumerable<PhoneField> fields, out int result)
		{
			return _collection.TryAddRange(fields, out result);
		}

		/// <summary>
		/// Try to get a field at the desired index
		/// </summary>
		/// <param name="index">the index</param>
		/// <param name="result">the result</param>
		/// <returns>returns true for a success, otherwise false</returns>
		public override bool TryGetAt(int index, out PhoneField result)
		{
			return _collection.TryGetAt(index, out result);
		}
	}
}
