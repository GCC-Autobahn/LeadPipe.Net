﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TransitionNotAvailableException.cs" company="Lead Pipe Software">
//   Copyright (c) Lead Pipe Software All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace LeadPipe.Net.Core.FiniteStateMachine
{
	using System;
	using System.Globalization;

	/// <summary>
	/// An base exception for the domain layer.
	/// </summary>
	[Serializable]
	public class TransitionNotAvailableException : Exception
	{
		#region Constructors and Destructors

		/// <summary>
		/// Initializes a new instance of the <see cref="TransitionNotAvailableException"/> class.
		/// </summary>
		public TransitionNotAvailableException()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="TransitionNotAvailableException"/> class. 
		/// </summary>
		/// <param name="message">
		/// The exception message.
		/// </param>
		public TransitionNotAvailableException(string message)
			: base(message)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="TransitionNotAvailableException"/> class.
		/// </summary>
		/// <param name="message">
		/// The exception message.
		/// </param>
		/// <param name="innerException">
		/// The inner exception.
		/// </param>
		public TransitionNotAvailableException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="TransitionNotAvailableException"/> class.
		/// </summary>
		/// <param name="transition">
		/// The transition.
		/// </param>
		/// <param name="state">
		/// The state.
		/// </param>
		public TransitionNotAvailableException(IFiniteStateTransition transition, IFiniteState state)
			: base(
				string.Format(
					CultureInfo.CurrentCulture, "The {0} transition is not available in the {1} state.", transition.Name, state.Name))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="TransitionNotAvailableException"/> class.
		/// </summary>
		/// <param name="transition">
		/// The transition.
		/// </param>
		/// <param name="state">
		/// The state.
		/// </param>
		/// <param name="innerException">
		/// The inner exception.
		/// </param>
		public TransitionNotAvailableException(
			IFiniteStateTransition transition, IFiniteState state, Exception innerException)
			: base(
				string.Format(
					CultureInfo.CurrentCulture, "The {0} transition is not available in the {1} state.", transition.Name, state.Name),
				innerException)
		{
		}

		#endregion
	}
}