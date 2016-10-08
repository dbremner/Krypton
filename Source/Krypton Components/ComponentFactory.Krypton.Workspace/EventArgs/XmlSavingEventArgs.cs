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

namespace ComponentFactory.Krypton.Workspace
{
	/// <summary>
	/// Event data for persisting extra data for a workspace.
	/// </summary>
	public class XmlSavingEventArgs : EventArgs
	{
		#region Instance Fields
        private readonly KryptonWorkspace _workspace;
        private readonly XmlWriter _xmlWriter;
		#endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the XmlSavingEventArgs class.
		/// </summary>
        /// <param name="workspace">Reference to owning workspace control.</param>
        /// <param name="xmlWriter">Xml writer for persisting custom data.</param>
        public XmlSavingEventArgs(KryptonWorkspace workspace,
                                  XmlWriter xmlWriter)
		{
            _workspace = workspace;
            _xmlWriter = xmlWriter;
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
        /// Gets the xml writer.
        /// </summary>
        public XmlWriter XmlWriter
        {
            get { return _xmlWriter; }
        }
        #endregion
	}
}
