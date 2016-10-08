﻿// *****************************************************************************
// 
//  © Component Factory Pty Ltd 2012. All rights reserved.
//	The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 17/267 Nepean Hwy, 
//  Seaford, Vic 3198, Australia and are supplied subject to licence terms.
// 
//  Version 4.4.0.0 	www.ComponentFactory.com
// *****************************************************************************

using System;
using System.Windows.Forms;
using System.Diagnostics;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Navigator
{
	/// <summary>
	/// Represents a collection of child controls for the navigator.
	/// </summary>
    public class KryptonNavigatorControlCollection : KryptonControlCollection
	{
		#region Instance Fields
		private KryptonNavigator _owner;
		#endregion

		#region Identity
		/// <summary>
		/// Initialize a new instance of the KryptonNavigatorControlCollection class.
		/// </summary>
		/// <param name="owner">Control containing this collection.</param>
		public KryptonNavigatorControlCollection(KryptonNavigator owner)
			: base(owner)
		{
			Debug.Assert(owner != null);

			// Remember the collection owner
			_owner = owner;
		}
		#endregion

		#region Public Overrides
		/// <summary>
		/// Adds the specified control to the control collection.
		/// </summary>
		/// <param name="value">The KryptonPage to add to the control collection.</param>
		public override void Add(Control value)
		{
			Debug.Assert(value != null);

			// Cast to correct type
			KryptonPage page = (KryptonPage)value;

			// We only allow KryptonPage controls to be added
			if (page == null)
				throw new ArgumentException("Only KryptonPage controls can be added.", nameof(value));

			// Let base class perform actual add
			base.Add(value);
		}
		#endregion
	}
}
