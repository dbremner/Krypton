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

namespace ComponentFactory.Krypton.Toolkit
{
	/// <summary>
	/// Details for need layout events.
	/// </summary>
	public class NeedLayoutEventArgs : EventArgs
	{
		#region Instance Fields
		private readonly bool _needLayout;
        private readonly Rectangle _invalidRect;
		#endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the NeedLayoutEventArgs class.
		/// </summary>
        /// <param name="needLayout">Does the layout need regenerating.</param>
        public NeedLayoutEventArgs(bool needLayout)
            : this(needLayout, Rectangle.Empty)
		{
		}

        /// <summary>
        /// Initialize a new instance of the NeedLayoutEventArgs class.
        /// </summary>
        /// <param name="needLayout">Does the layout need regenerating.</param>
        /// <param name="invalidRect">Specifies an invalidation rectangle.</param>
        public NeedLayoutEventArgs(bool needLayout,
                                   Rectangle invalidRect)
        {
            _needLayout = needLayout;
            _invalidRect = invalidRect;
        }
        #endregion

		#region Public
		/// <summary>
		/// Gets a value indicating if the layout needs regenerating.
		/// </summary>
		public bool NeedLayout
		{
            get { return _needLayout; }
		}

        /// <summary>
        /// Gets the rectangle to be invalidated.
        /// </summary>
        public Rectangle InvalidRect
        {
            get { return _invalidRect; }
        }
		#endregion
	}
}
