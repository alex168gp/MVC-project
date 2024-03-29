﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Domain
{
    /// <summary>
    /// Some project that should be done
    /// </summary>
    public class Project: BaseEntity
    {
        #region Private Members

        /// <summary>
        /// A difficulty of a project
        /// </summary>
        private int mDifficulty;

        #endregion

        #region Public Properties

        /// <summary>
        /// A name of a project
        /// </summary>
        public string Name { get; set; }

        [Range(1, 5)]
        /// <summary>
        /// A difficulty of a project
        /// </summary>
        public int Difficulty
        {
            get
            {
                return mDifficulty;
            }
            set
            {
                // only 1-5
                if (value <1 && value > 5)
                {
                    Console.WriteLine("Something went wrong");
                    return;
                }

                // set value
                mDifficulty = value;
            }
        }

        /// <summary>
        /// When team started to work on a project
        /// </summary>
        public DateTime StartDate { get; set; } = DateTime.UtcNow.AddDays(7);

        /// <summary>
        /// Estimated time that need team to complete project
        /// </summary>
        public DateTime ProjectTimeDuration { get; set; } = DateTime.UtcNow.AddDays(37);

        /// <summary>
        /// A description of a project
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A price of a project
        /// </summary>
        public int Price { get; set; }

        #endregion
    }
}