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
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Navigator
{
	/// <summary>
    /// Details for an event that provides pages and cell associated with a page dragging event.
	/// </summary>
    public class PageDragEndData
	{
		#region Instance Fields
        private readonly object _source;
        private readonly KryptonNavigator _navigator;
        private readonly KryptonPageCollection _pages;
        #endregion

		#region Identity
		/// <summary>
        /// Initialize a new instance of the PageDragEndData class.
		/// </summary>
        /// <param name="source">Source object for the drag data..</param>
        /// <param name="pages">Collection of pages.</param>
        public PageDragEndData(object source,
                               KryptonPageCollection pages)
            : this(source, null, pages)
		{
		}

        /// <summary>
        /// Initialize a new instance of the PageDragEndData class.
        /// </summary>
        /// <param name="source">Source object for the drag data..</param>
        /// <param name="navigator">Navigator associated with pages.</param>
        /// <param name="pages">Collection of pages.</param>
        public PageDragEndData(object source,
                               KryptonNavigator navigator,
                               KryptonPageCollection pages)
        {
            _source = source;
            _navigator = navigator;
            _pages = pages;
        }
        #endregion

        #region Public
        /// <summary>
        /// Gets access to the source of the drag data.
        /// </summary>
        public object Source
        {
            get { return _source; }
        }

        /// <summary>
        /// Gets access to any associated KryptonNavigator instance.
        /// </summary>
        public KryptonNavigator Navigator
        {
            get { return _navigator; }
        }

        /// <summary>
        /// Gets access to the collection of pages.
        /// </summary>
        public KryptonPageCollection Pages
        {
            get { return _pages; }
        }
        #endregion
    }
}
