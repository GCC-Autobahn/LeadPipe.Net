﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICommand.cs" company="Lead Pipe Software">
//   Copyright (c) Lead Pipe Software All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace LeadPipe.Net.Core.Commands
{
	using System.Diagnostics.CodeAnalysis;

	/// <summary>
	/// The marker interface for commands.
	/// </summary>
	[SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "GBM: Suppression is OK here.")]
	public interface ICommand
	{
	}

	/// <summary>
	/// The marker interface for commands.
	/// </summary>
	/// <typeparam name="TResult">The type of the result.</typeparam>
	[SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:FileMayOnlyContainASingleClass", Justification = "GBM: Suppression is OK here.")]
	public interface ICommand<out TResult> : ICommand
	{
	}
}