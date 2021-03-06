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
    /// Indicates that the property should pull from the item links list.
    /// </summary>
    public class SitecoreLinkedAttribute : AbstractSitecorePropertyAttribute
    {
        
        public SitecoreLinkedAttribute()
        {
            this.IsLazy = true;
            Option = SitecoreLinkedOptions.All;
        }

        /// <summary>
        /// Indicates if linked items should be loaded lazily. Default value is true. If false linked items will be loaded when the contain object is created.
        /// </summary>
        public bool IsLazy
        {
            get;
            set;
        }

        /// <summary>
        /// Indicates the type should be inferred from the item template
        /// </summary>
        public bool InferType { get; set; }

        /// <summary>
        /// Indicate weather All, References or Referred should be loaded
        /// </summary>
        public SitecoreLinkedOptions Option { get; set; }
       
    }
}
