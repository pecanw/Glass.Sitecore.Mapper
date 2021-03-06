﻿/*
   Copyright 2011 Michael Edwards
 
   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glass.Sitecore.Mapper.Configuration.Attributes
{
    /// <summary>
    /// Indicates that a query should be execute to load data into the property.
    /// The query can be either absolute or relative to the current item.
    /// </summary>
    public class SitecoreQueryAttribute : AbstractSitecorePropertyAttribute
    {
        /// <summary>
        /// The query to execute
        /// </summary>
        public string Query { get; set; }

        /// <summary>
        /// Indicates that the results should be loaded lazily
        /// </summary>
        public bool IsLazy { get; set; }
        /// <summary>
        /// Indicates that the field is relative to the current item.
        /// </summary>
        public bool IsRelative { get; set; }

        /// <summary>
        /// Indicates the type should be inferred from the item template
        /// </summary>
        public bool InferType { get; set; }

        /// <summary>
        /// Use the Sitecore.Data.Query.QueryContext when querying for data
        /// </summary>
        public bool UseQueryContext { get; set; }

        /// <summary>
        /// Indicates that the property should be populated with the result of a query.
        /// </summary>
        /// <param name="query">The query to execute</param>
        public SitecoreQueryAttribute(string query)
        {
            Query = query;
            IsLazy = true;
            UseQueryContext = false;
        }

        internal SitecoreQueryAttribute()
        {
            IsLazy = true;
        }
    }
}
