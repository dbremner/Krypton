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
using System.Diagnostics;

namespace ComponentFactory.Krypton.Docking
{
	/// <summary>
    /// Event data for saving global docking configuration.
	/// </summary>
	public class DockGlobalSavingEventArgs : EventArgs
	{
		#region Instance Fields
        private readonly KryptonDockingManager _manager;
        private readonly XmlWriter _xmlWriter;
		#endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the DockGlobalSavingEventArgs class.
		/// </summary>
        /// <param name="manager">Reference to owning docking manager instance.</param>
        /// <param name="xmlWriter">Xml writer for persisting custom data.</param>
        public DockGlobalSavingEventArgs(KryptonDockingManager manager,
                                         XmlWriter xmlWriter)
		{
            _manager = manager;
            _xmlWriter = xmlWriter;
		}
		#endregion

		#region Public
		/// <summary>
        /// Gets the docking manager reference.
		/// </summary>
        public KryptonDockingManager DockingManager
		{
            get { return _manager; }
		}

        /// <summary>
        /// Gets the xml writer.
        /// </summary>
        public XmlWriter XmlWriter
        {
            get { return _xmlWriter; }
        }
        #endregion
	}
}
