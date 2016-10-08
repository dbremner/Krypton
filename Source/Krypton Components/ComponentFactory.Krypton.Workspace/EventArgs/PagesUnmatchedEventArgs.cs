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
using System.IO;
using System.Xml;
using System.Drawing;
using System.Collections.Generic;
using System.Diagnostics;
using ComponentFactory.Krypton.Navigator;

namespace ComponentFactory.Krypton.Workspace
{
	/// <summary>
	/// Event data for listing pages unmatched during the load process.
	/// </summary>
	public class PagesUnmatchedEventArgs : EventArgs
	{
		#region Instance Fields
        private readonly KryptonWorkspace _workspace;
        private readonly List<KryptonPage> _unmatched;
		#endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the PagesUnmatchedEventArgs class.
		/// </summary>
        /// <param name="workspace">Reference to owning workspace control.</param>
        /// <param name="unmatched">List of pages unmatched during the load process.</param>
        public PagesUnmatchedEventArgs(KryptonWorkspace workspace,
                                       List<KryptonPage> unmatched)
		{
            _workspace = workspace;
            _unmatched = unmatched;
		}
		#endregion

		#region Public
		/// <summary>
        /// Gets the workspace reference.
		/// </summary>
        public KryptonWorkspace Workspace
		{
            get { return _workspace; }
		}

        /// <summary>
        /// Gets the xml reader.
        /// </summary>
        public List<KryptonPage> Unmatched
        {
            get { return _unmatched; }
        }
        #endregion
	}
}
