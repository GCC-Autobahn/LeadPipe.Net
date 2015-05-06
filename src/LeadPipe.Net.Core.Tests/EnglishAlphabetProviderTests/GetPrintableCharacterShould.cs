// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetPrintableCharacterShould.cs" company="Lead Pipe Software">
//   Copyright (c) Lead Pipe Software All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace LeadPipe.Net.Core.Tests.EnglishAlphabetProviderTests
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	using LeadPipe.Net.Core.Extensions;

	using LeadPipeSoftware.Net.Core;

	using NUnit.Framework;

	/// <summary>
	/// GetPrintableCharacters tests.
	/// </summary>
	[TestFixture]
	public class GetPrintableCharacterShould
	{
		#region Public Methods and Operators

		/// <summary>
		/// Tests to make sure we can get all the Printable characters.
		/// </summary>
		[Test]
		public void ReturnPrintableCharacters()
		{
			// Arrange
			var expectedCharacters = new List<char>();

			// Ascii values of all upper and lower case alphabets, numbers 0 - 9 and special characters till the max ascii value of 126 
			for (int i = 32; i <= 126; i++)
			{
				// convert to a character
				char c = Convert.ToChar(i);

				// add to the list
				expectedCharacters.Add(c);
			}

			IAlphabetProvider provider = new EnglishAlphabetProvider();

			// Act
			var result = new string(provider.GetPrintableCharacters().ToArray());

			// Assert
			Assert.AreEqual(expectedCharacters, result);
		}

		#endregion
	}
}