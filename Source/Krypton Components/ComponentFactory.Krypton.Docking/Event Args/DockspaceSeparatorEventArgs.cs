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
using System.Drawing;
using System.Diagnostics;
using ComponentFactory.Krypton.Toolkit;
using ComponentFactory.Krypton.Workspace;

namespace ComponentFactory.Krypton.Docking
{
	/// <summary>
    /// Event arguments for a DockspaceSeparatorAdding/DockspaceSeparatorRemoved event.
	/// </summary>
	public class DockspaceSeparatorEventArgs : EventArgs
	{
		#region Instance Fields
        private readonly KryptonSeparator _separator;
        private readonly KryptonDockingDockspace _element;
		#endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the DockspaceSeparatorEventArgs class.
		/// </summary>
        /// <param name="separator">Reference to separator control instance.</param>
        /// <param name="element">Reference to dockspace docking element that is managing the separator.</param>
        public DockspaceSeparatorEventArgs(KryptonSeparator separator,
                                           KryptonDockingDockspace element)
		{
            _separator = separator;
            _element = element;
		}
		#endregion

		#region Public
        /// <summary>
        /// Gets a reference to the KryptonSeparator control..
        /// </summary>
        public KryptonSeparator SeparatorControl
        {
            get { return _separator; }
        }

        /// <summary>
        /// Gets a reference to the KryptonDockingDockspace that is managing the dockspace.
        /// </summary>
        public KryptonDockingDockspace DockspaceElement
        {
            get { return _element; }
        }
        #endregion
	}
}
