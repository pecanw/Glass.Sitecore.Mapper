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
using Glass.Sitecore.Mapper.FieldTypes;
using Sitecore.Data.Items;
using Sitecore.Resources.Media;
using Sitecore.Data.Fields;
using System.IO;
using Glass.Sitecore.Mapper.Configuration;

namespace Glass.Sitecore.Mapper.Data
{
    public class SitecoreFieldStreamHandler : AbstractSitecoreField
    {

        public override object GetValue( global::Sitecore.Data.Items.Item item,  ISitecoreService service)
        {
            var itemField = base.GetField(item);

            if (itemField == null) return null;

            Field field = itemField;

            return field.GetBlobStream();          
        }

        public override void SetValue(Item item, object value, ISitecoreService service)
        {
            if (value == null) return;

            Field field = base.GetField(item);

            if (field == null) return;

            field.SetBlobStream(value as Stream);
        }

        public override object GetFieldValue(string fieldValue, global::Sitecore.Data.Items.Item item, ISitecoreService service)
        {
            throw new NotImplementedException();
        }

        public override string SetFieldValue( object value, ISitecoreService service)
        {
            throw new NotImplementedException();
        }

        public override Type TypeHandled
        {
            get {return typeof(Stream); }
        }
    }
}
