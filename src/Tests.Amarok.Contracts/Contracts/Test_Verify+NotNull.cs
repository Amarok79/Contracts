﻿/* Copyright(c) 2018, Olaf Kober
 * Licensed under GNU Lesser General Public License v3.0 (LPGL-3.0).
 * https://github.com/Amarok79/Contracts
 */

using System;
using NFluent;
using NUnit.Framework;


namespace Amarok.Contracts
{
	public class Test_Verify
	{
		[TestFixture]
		public class NotNull
		{
			[Test]
			public void DoesNotThrow()
			{
				Check.ThatCode(() => Verify.NotNull("abc", "name"))
					.DoesNotThrow();
			}

			[Test]
			public void Throws()
			{
				var exception = Check.ThatCode(() => Verify.NotNull((String)null, "name"))
					.Throws<ArgumentNullException>()
					.Value;

				Check.That(exception.Message)
					.Not.IsEmpty();
				Check.That(exception.ParamName)
					.IsEqualTo("name");
				Check.That(exception.InnerException)
					.IsNull();
			}
		}
	}
}
