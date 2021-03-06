﻿// --------------------------------------------------------------------------------------------------------------------
// Copyright (c) Lead Pipe Software. All rights reserved.
// Licensed under the MIT License. Please see the LICENSE file in the project root for full license information.
// --------------------------------------------------------------------------------------------------------------------

using System;

namespace LeadPipe.Net.FiniteStateMachine
{
    /// <summary>
    /// The state changed event args.
    /// </summary>
    public class StateChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateChangedEventArgs"/> class.
        /// </summary>
        /// <param name="transition">The transition.</param>
        /// <param name="transitionResult">The transition result.</param>
        /// <param name="comment">The comment.</param>
        public StateChangedEventArgs(IFiniteStateTransition transition, IFiniteState transitionResult, string comment = null)
        {
            this.Transition = transition;
            this.TransitionResult = transitionResult;
            this.Comment = comment;
        }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the transition.
        /// </summary>
        public IFiniteStateTransition Transition { get; set; }

        /// <summary>
        /// Gets or sets the transition result.
        /// </summary>
        public IFiniteState TransitionResult { get; set; }
    }
}