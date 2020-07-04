﻿using SeizeTheDay.Core.Entities;

namespace SeizeTheDay.Core.Domain.Forums
{
    public partial class ForumPost : BaseEntity
    {
        /// <summary>
        /// Gets or sets the title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the title
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets the show in portal
        /// </summary>
        public bool ShowInPortal { get; set; }

        /// <summary>
        /// Gets or sets the post locked status
        /// </summary>
        public bool PostLocked { get; set; }

        /// <summary>
        /// Gets or sets the review count
        /// </summary>
        public int ReviewCount { get; set; }

        /// <summary>
        /// Gets or sets the review count
        /// </summary>
        public int IsDefault { get; set; }

        /// <summary>
        /// Gets or sets the forum identifier
        /// </summary>
        public int ForumId { get; set; }

        /// <summary>
        /// Gets or sets the forum topic identifier
        /// </summary>
        public int ForumTopicId { get; set; }

        /// <summary>
        /// Gets or sets the user identifier
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets the forum
        /// </summary>
        public virtual Forum Forum { get; set; }

        /// <summary>
        /// Gets the forum
        /// </summary>
        public virtual ForumTopic ForumTopic { get; set; }

        //TODO
        /// <summary>
        /// Gets the customer
        /// </summary>
        //public virtual User User { get; set; }
    }
}
