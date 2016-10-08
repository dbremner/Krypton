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
    /// Event arguments for a DockableWorkspaceCellAdding/DockableWorkspaceCellRemoving events.
	/// </summary>
	public class DockableWorkspaceCellEventArgs : EventArgs
	{
		#region Instance Fields
        private readonly KryptonDockableWorkspace _workspace;
        private readonly KryptonDockingWorkspace _element;
        private readonly KryptonWorkspaceCell _cell;
        #endregion
		
        #region Identity
		/// <summary>
        /// Initialize a new instance of the DockableWorkspaceCellEventArgs class.
		/// </summary>
        /// <param name="workspace">Reference to existing dockable workspace control instance.</param>
        /// <param name="element">Reference to docking workspace element that is managing the dockable workspace control.</param>
        /// <param name="cell">Reference to workspace control cell instance.</param>
        public DockableWorkspaceCellEventArgs(KryptonDockableWorkspace workspace,
                                              KryptonDockingWorkspace element,
                                              KryptonWorkspaceCell cell)
		{
            _workspace = workspace;
            _element = element;
            _cell = cell;
		}
		#endregion

		#region Public
        /// <summary>
        /// Gets a reference to the KryptonDockableWorkspace that contains the cell.
        /// </summary>
        public KryptonDockableWorkspace DockableWorkspaceControl
        {
            get { return _workspace; }
        }

        /// <summary>
        /// Gets a reference to the KryptonDockingWorkspace that is managing the dockable workspace.
        /// </summary>
        public KryptonDockingWorkspace WorkspaceElement
        {
            get { return _element; }
        }

        /// <summary>
        /// Gets a reference to the KryptonWorkspaceCell control.
        /// </summary>
        public KryptonWorkspaceCell CellControl
        {
            get { return _cell; }
        }
        #endregion
	}
}
