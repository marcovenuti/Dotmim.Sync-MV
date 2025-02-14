﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dotmim.Sync.Serialization
{
    public interface IConverter
    {

        /// <summary>
        /// get the unique key for this converter
        /// </summary>
        string Key { get; }

        /// <summary>
        /// Convert a row before being serialized
        /// </summary>
        void BeforeSerialize(object[] row, SyncTable schemaTable);

        /// <summary>
        /// Convert a row afeter being deserialized
        /// </summary>
        void AfterDeserialized(object[] row, SyncTable schemaTable);
    }
}
